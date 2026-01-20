using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace GsbRapports
{
    public partial class frmVisualiser : Form
    {
        private gsbrapports2026Entities mesDonneesEF = new gsbrapports2026Entities();
        private string idVisiteur;
        public frmVisualiser()
        {
            InitializeComponent();

            // Charger les noms dans cmbNom
            var listeNoms = mesDonneesEF.visiteurs
                .OrderBy(v => v.nom)
                .Select(v => v.nom)
                .Distinct()
                .ToList();

            cmbNom.DataSource = listeNoms;

            // Quand on change de nom, charger les prénoms correspondants
            cmbNom.SelectedIndexChanged += (s, e) =>
            {
                string nomSelectionne = cmbNom.Text;

                var listePrenoms = mesDonneesEF.visiteurs
                    .Where(v => v.nom == nomSelectionne)
                    .Select(v => v.prenom)
                    .ToList();

                cmbPrenom.DataSource = listePrenoms;
            };

            // DataGridView en lecture seule
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom = cmbNom.Text;
            string prenom = cmbPrenom.Text;
            DateTime dateChoisie = dtDate.Value.Date;

            var visiteur = mesDonneesEF.visiteurs
                .FirstOrDefault(v => v.nom == nom && v.prenom == prenom);

            if (visiteur == null)
            {
                MessageBox.Show("Visiteur introuvable.");
                return;
            }

            var rapports = mesDonneesEF.rapports
                .Where(r => r.idVisiteur == visiteur.id
                         && r.date == dateChoisie);

            dataGridView1.DataSource = rapports.ToList();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MessageBox.Show("Rapports affichés !");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var rapport = (rapport)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fichier XML (*.xml)|*.xml";
            sfd.FileName = "rapport_" + rapport.id + ".xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportRapportEnXml(rapport, sfd.FileName);
                MessageBox.Show("Rapport téléchargé en XML !");
            }
        }
        private void ExportRapportEnXml(rapport r, string chemin)
        {
            var doc = new System.Xml.Linq.XDocument(
                new System.Xml.Linq.XElement("Rapport",
                    new System.Xml.Linq.XElement("Id", r.id),
                    new System.Xml.Linq.XElement("Date", r.date),
                    new System.Xml.Linq.XElement("Motif", r.motif),
                    new System.Xml.Linq.XElement("Bilan", r.bilan),
                    new System.Xml.Linq.XElement("Visiteur", r.idVisiteur),
                    new System.Xml.Linq.XElement("Medecin", r.idMedecin)
                )
            );

            doc.Save(chemin);
        }
    }
}
