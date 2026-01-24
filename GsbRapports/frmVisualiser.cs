using System;
using System.Linq;
using System.Windows.Forms;

namespace GsbRapports
{
    public partial class frmVisualiser : Form
    {
        private gsbrapports2026Entities mesDonneesEF = new gsbrapports2026Entities();

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

            // Charger les prénoms quand le nom change
            cmbNom.SelectedIndexChanged += (s, e) =>
            {
                string nomSelectionne = cmbNom.Text;

                var listePrenoms = mesDonneesEF.visiteurs
                    .Where(v => v.nom == nomSelectionne)
                    .Select(v => v.prenom)
                    .ToList();

                cmbPrenom.DataSource = listePrenoms;
            };

            // Configuration du DataGridView
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Bouton VALIDER (filtrage)
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

            var listeRapports = mesDonneesEF.rapports
                .Where(r => r.idVisiteur == visiteur.id
                         && r.date == dateChoisie)
                .ToList();

            dataGridView1.DataSource = listeRapports;

            MessageBox.Show("Rapports affichés !");
        }

        // Bouton TELECHARGER XML
        private void btnTelechargerXml_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un rapport.");
                return;
            }

            rapport rapportSelectionne =
                dataGridView1.SelectedRows[0].DataBoundItem as rapport;

            if (rapportSelectionne == null)
            {
                MessageBox.Show("Erreur lors de la récupération du rapport.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fichier XML (*.xml)|*.xml";
            sfd.FileName = "rapport_" + rapportSelectionne.id + ".xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportRapportEnXml(rapportSelectionne, sfd.FileName);
                MessageBox.Show("Rapport téléchargé en XML !");
            }
        }

        // Export XML
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
