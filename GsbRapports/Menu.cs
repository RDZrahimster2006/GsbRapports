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
    public partial class Menu : Form
    {
       
        private gsbrapports2026Entities mesDonneesEF= new gsbrapports2026Entities();
        
        public Menu()
        {
            InitializeComponent();
           // this.mesDonneesEF = new gsbrapports2026Entities();
        }


        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutRapports ajout = new frmAjoutRapports(mesDonneesEF);
            ajout.MdiParent = this;
            ajout.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifier modif = new frmModifier(mesDonneesEF);
            modif.MdiParent = this;
            modif.Show();
        }
    }
}
