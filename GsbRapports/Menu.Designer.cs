namespace GsbRapports
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripRapports = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripRapports.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripRapports
            // 
            this.menuStripRapports.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripRapports.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripRapports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.visualisationToolStripMenuItem});
            this.menuStripRapports.Location = new System.Drawing.Point(0, 0);
            this.menuStripRapports.Name = "menuStripRapports";
            this.menuStripRapports.Size = new System.Drawing.Size(872, 36);
            this.menuStripRapports.TabIndex = 0;
            this.menuStripRapports.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // visualisationToolStripMenuItem
            // 
            this.visualisationToolStripMenuItem.Name = "visualisationToolStripMenuItem";
            this.visualisationToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.visualisationToolStripMenuItem.Text = "Visualisation";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 496);
            this.Controls.Add(this.menuStripRapports);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripRapports;
            this.Name = "Menu";
            this.Text = "Gestion des Rapports";
            
            this.menuStripRapports.ResumeLayout(false);
            this.menuStripRapports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripRapports;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisationToolStripMenuItem;
    }
}

