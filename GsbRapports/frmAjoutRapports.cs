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
    public partial class frmAjoutRapports : Form
    {
        private gsbrapports2026Entities mesDonneesEF { get; set; }
        public frmAjoutRapports(gsbrapports2026Entities mesDonnesEFF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonnesEFF;
            this.bdgSourceVisiteur.DataSource = mesDonneesEF.visiteurs.ToList();
            this.bdgSourceMedecin.DataSource = mesDonneesEF.medecins.ToList();
            this.bdgSourceMedicament.DataSource = mesDonneesEF.medicaments.ToList();
        }

        

       
    }
}
