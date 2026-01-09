using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsbRapports
{
    public partial class frmAjoutRapports : Form
    {
        private gsbrapports2026Entities mesDonneesEF;
        public frmAjoutRapports(gsbrapports2026Entities mesDonneeEFF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneeEFF;
            bdgSourceVisiteur = new BindingSource();
            bdgSourceMedecin = new BindingSource();
            bdgSourceMedicament = new BindingSource();

            var listeVisiteurs = (from v in mesDonneesEF.visiteurs
                                  orderby v.nom
                                  select v.nom)
                      .Distinct()
                      .Select(n => new
                      {
                          NomComplet = n
                      })
                      .ToList();

            this.bdgSourceVisiteur.DataSource = listeVisiteurs;
            cmbNomVisiteur.DisplayMember = "NomComplet";
            cmbNomVisiteur.ValueMember = "Id";
            cmbNomVisiteur.DataSource = bdgSourceVisiteur;




            var listeMedecins = (from m in mesDonneesEF.medecins
                                 orderby m.nom
                                 select m.nom)          
                     .Distinct()            
                     .Select(n => new       
                     {
                         NomComplet = n
                     })
                     .ToList();


            this.bdgSourceMedecin.DataSource = listeMedecins;
            cmbNomMedecin.DisplayMember = "NomComplet";
            cmbNomMedecin.ValueMember = "Id";
            cmbNomMedecin.DataSource = bdgSourceMedecin;

            var listeMedicaments = (from med in mesDonneesEF.medicaments
                                    orderby med.nomCommercial
                                    select new
                                    {
                                        Id = med.id,
                                        Nom = med.nomCommercial
                                    }).ToList();

            this.bdgSourceMedicament.DataSource = listeMedicaments;
            cmbNomMedicament.DisplayMember = "Nom";
            cmbNomMedicament.ValueMember = "Id";
            cmbNomMedicament.DataSource = bdgSourceMedicament;
        }
        private void frmAjoutRapports_Load(object sender, EventArgs e)
        {

        }

        private void cmbNomVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomSelectionne = cmbNomVisiteur.Text;
            var listePrenoms = (from v in mesDonneesEF.visiteurs
                                where v.nom == nomSelectionne
                                select new
                                {
                                    Prenom = v.prenom
                                }).ToList();
            cmbPrenomVisiteur.DisplayMember = "Prenom";
            cmbPrenomVisiteur.ValueMember = "Prenom";
            cmbPrenomVisiteur.DataSource = listePrenoms;
        }

        private void cmbNomMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomSelectionne = cmbNomMedecin.Text;

            var listePrenomsMedecins = (from m in mesDonneesEF.medecins
                                        where m.nom == nomSelectionne
                                        select new
                                        {
                                            Prenom = m.prenom
                                        }).ToList();
            cmbPrenomMedecin.DisplayMember = "Prenom";
            cmbPrenomMedecin.ValueMember = "Prenom";
            cmbPrenomMedecin.DataSource = listePrenomsMedecins;

        }

        private void cmbPrenomMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomSelectionne = cmbNomMedecin.Text;
            string prenomSelectionne = cmbPrenomMedecin.Text;

            var adresseMedecin = (from m in mesDonneesEF.medecins
                                  where m.nom == nomSelectionne
                                     && m.prenom == prenomSelectionne
                                  select m.adresse)
                                  .FirstOrDefault();

            cmbAdresseMedecin.Text = adresseMedecin;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lstMedicament.Items.Add(cmbNomMedicament.Text);
            lstMedicament.SelectedIndex = lstMedicament.Items.Count - 1;
            lstMedicament.Items.Add(QuantiteMedicament.Value.ToString());   


        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            rapport visiteRapport = new rapport();
            string nomVisiteur = cmbNomVisiteur.Text;
            string prenomVisiteur = cmbPrenomVisiteur.Text;
            var visiteur = mesDonneesEF.visiteurs
                .FirstOrDefault(v => v.nom == nomVisiteur && v.prenom == prenomVisiteur);
            if (visiteur != null)
            {
                visiteRapport.idVisiteur = visiteur.id;
            }
            string nomMedecin = cmbNomMedecin.Text;
            string prenomMedecin = cmbPrenomMedecin.Text;
            var medecin = mesDonneesEF.medecins
                .FirstOrDefault(m => m.nom == nomMedecin && m.prenom == prenomMedecin);
            if (medecin != null)
            {
                visiteRapport.idMedecin = medecin.id;
            }
            visiteRapport.id = (mesDonneesEF.rapports.Max(r => r.id)+1);
            visiteRapport.date = dateVisite.Value;
            visiteRapport.bilan = txtBilan.Text;
            visiteRapport.motif = txtMotif.Text;
            mesDonneesEF.rapports.Add(visiteRapport);
            mesDonneesEF.SaveChanges();
            MessageBox.Show("Rapport ajouté avec succès !");
        }
    }
}
