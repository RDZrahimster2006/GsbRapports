using System;
using System.Linq;
using System.Windows.Forms;

namespace GsbRapports
{
    public partial class frmModifier : Form
    {
        private gsbrapports2026Entities mesDonneesEF;
        private string idVisiteur;

        public frmModifier(gsbrapports2026Entities mesDonneeEF, string idVisiteur)
        {
            InitializeComponent();

            this.mesDonneesEF = mesDonneeEF;
            this.idVisiteur = idVisiteur;

            // Charger les noms dans cmbNom
            var listeNoms = mesDonneesEF.visiteurs
                .OrderBy(v => v.nom)
                .Select(v => v.nom)
                .Distinct()
                .ToList();

            cmbNom.DataSource = listeNoms;

            // Quand on change le nom, remplir le ComboBox prénom
            cmbNom.SelectedIndexChanged += (s, e) =>
            {
                string nomSelectionne = cmbNom.Text;
                var listePrenoms = mesDonneesEF.visiteurs
                    .Where(v => v.nom == nomSelectionne)
                    .Select(v => v.prenom)
                    .ToList();

                cmbPrenom.DataSource = listePrenoms;
            };

            // Configurer DataGridView
            dataGridView1.ReadOnly = false; // modifiable
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Bouton pour filtrer les rapports par nom, prénom et date
        private void vldValider_Click(object sender, EventArgs e)
        {
            string nomVisiteur = cmbNom.Text;
            string prenomVisiteur = cmbPrenom.Text;
            DateTime dateChoisie = dtDate.Value.Date;

            // Récupérer le visiteur correspondant
            var visiteur = mesDonneesEF.visiteurs
                .FirstOrDefault(v => v.nom == nomVisiteur && v.prenom == prenomVisiteur);

            if (visiteur == null)
            {
                MessageBox.Show("Visiteur introuvable.");
                return;
            }

            idVisiteur = visiteur.id;

            // Filtrer les rapports du visiteur pour la date sélectionnée
            var listeRapports = mesDonneesEF.rapports
                .Where(r => r.idVisiteur == idVisiteur && r.date == dateChoisie)
                .ToList();

            dataGridView1.DataSource = listeRapports;
        }

        // Bouton pour enregistrer les modifications
        private void btnRapports_Click(object sender, EventArgs e)
        {
            try
            {
                mesDonneesEF.SaveChanges();
                MessageBox.Show("Toutes les modifications ont été enregistrées dans la base !");
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
        }
    }
}
