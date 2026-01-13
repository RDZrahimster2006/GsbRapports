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
    public partial class frmModifier2 : Form
    {
        private gsbrapports2026Entities mesDonneesEF;
        private string idVisiteur;

        public frmModifier2(gsbrapports2026Entities mesDonneeEF, string idVisiteur)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneeEF;
            this.idVisiteur = idVisiteur;

            var rapports = mesDonneesEF.rapports
            .Where(r => r.idVisiteur == idVisiteur)
            .Select(r => new
            {
                r.id,
                r.date,
                r.motif,
                r.bilan,
                r.idVisiteur,
                r.idMedecin
                
            })
            .ToList();

            bdgSourceGrid = new BindingSource();
            bdgSourceGrid.DataSource = rapports;

            dataGridView1.DataSource = bdgSourceGrid;

            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                mesDonneesEF.SaveChanges(); 
                MessageBox.Show("Modifications enregistrées dans la base !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
        }
    }
}
