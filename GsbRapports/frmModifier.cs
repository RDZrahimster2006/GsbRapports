using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            bdgSourceModifier = new BindingSource();
            this.idVisiteur = idVisiteur;

            var listeVisiteurs = (from v in mesDonneesEF.visiteurs
                                  orderby v.nom
                                  select v.nom)
                     .Distinct()
                     .Select(n => new
                     {
                         NomComplet = n
                     })
                     .ToList();
            var rapports = mesDonneesEF.rapports
            .Where(r => r.idVisiteur == idVisiteur)
            .ToList();

            this.bdgSourceModifier.DataSource = listeVisiteurs;
            cmbNom.DisplayMember = "NomComplet";
            cmbNom.ValueMember = "Id";
            cmbNom.DataSource = bdgSourceModifier;
           
            dataGridView1.DataSource = mesDonneesEF.rapports
                .Where(r => r.idVisiteur == idVisiteur)
                .ToList(); 

            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

       

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmModifier_Load(object sender, EventArgs e)
        {

        }

        private void cmbNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomSelectionne = cmbNom.Text;
            var listePrenoms = (from v in mesDonneesEF.visiteurs
                                where v.nom == nomSelectionne
                                select new
                                {
                                    Prenom = v.prenom
                                }).ToList();
            cmbPrenom.DisplayMember = "Prenom";
            cmbPrenom.ValueMember = "Prenom";
            cmbPrenom.DataSource = listePrenoms;
        }

        private void vldValider_Click(object sender, EventArgs e)
        {
            string nomVisiteur = cmbNom.Text;
            string prenomVisiteur = cmbPrenom.Text;

            var visiteur = mesDonneesEF.visiteurs
                .FirstOrDefault(v => v.nom == nomVisiteur && v.prenom == prenomVisiteur);

            if (visiteur == null)
            {
                MessageBox.Show("Visiteur introuvable.");
                return;
            }

            string idVisiteur = visiteur.id;

            
            frmModifier frmModifierNew = new frmModifier(mesDonneesEF, idVisiteur);
            
           this.Close();
           frmModifierNew.Show();


    }
      

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
