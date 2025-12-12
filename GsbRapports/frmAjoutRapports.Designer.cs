namespace GsbRapports
{
    partial class frmAjoutRapports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbNomVisiteur = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBilan = new System.Windows.Forms.Label();
            this.cmbPrenomVisiteur = new System.Windows.Forms.ComboBox();
            this.grpVisiteur = new System.Windows.Forms.GroupBox();
            this.lblPrenomVisiteur = new System.Windows.Forms.Label();
            this.lblNomVisiteur = new System.Windows.Forms.Label();
            this.grpMedecin = new System.Windows.Forms.GroupBox();
            this.lblAdresseMedecin = new System.Windows.Forms.Label();
            this.lblPrenomMedecin = new System.Windows.Forms.Label();
            this.lblNomMedecin = new System.Windows.Forms.Label();
            this.cmbAdresseMedecin = new System.Windows.Forms.ComboBox();
            this.cmbPrenomMedecin = new System.Windows.Forms.ComboBox();
            this.cmbNomMedecin = new System.Windows.Forms.ComboBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.dateVisite = new System.Windows.Forms.DateTimePicker();
            this.lstMedicament = new System.Windows.Forms.ListBox();
            this.lblMedicament = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.cmbNomMedicament = new System.Windows.Forms.ComboBox();
            this.QuantiteMedicament = new System.Windows.Forms.NumericUpDown();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpDetailVisite = new System.Windows.Forms.GroupBox();
            this.lblMedicamentsOffert = new System.Windows.Forms.Label();
            this.bdgSourceMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSourceMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSourceVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.grpVisiteur.SuspendLayout();
            this.grpMedecin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteMedicament)).BeginInit();
            this.grpDetailVisite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNomVisiteur
            // 
            this.cmbNomVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceVisiteur, "nom", true));
            this.cmbNomVisiteur.FormattingEnabled = true;
            this.cmbNomVisiteur.Location = new System.Drawing.Point(159, 49);
            this.cmbNomVisiteur.Name = "cmbNomVisiteur";
            this.cmbNomVisiteur.Size = new System.Drawing.Size(129, 28);
            this.cmbNomVisiteur.TabIndex = 2;
            this.cmbNomVisiteur.SelectedIndexChanged += new System.EventHandler(this.cmbNomVisiteur_SelectedIndexChanged);
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(54, 292);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(129, 20);
            this.lblMotif.TabIndex = 4;
            this.lblMotif.Text = "Motif de la visite :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(54, 358);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date de la visite :";
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(54, 426);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(52, 20);
            this.lblBilan.TabIndex = 6;
            this.lblBilan.Text = "Bilan :";
            // 
            // cmbPrenomVisiteur
            // 
            this.cmbPrenomVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceVisiteur, "prenom", true));
            this.cmbPrenomVisiteur.FormattingEnabled = true;
            this.cmbPrenomVisiteur.Location = new System.Drawing.Point(522, 49);
            this.cmbPrenomVisiteur.Name = "cmbPrenomVisiteur";
            this.cmbPrenomVisiteur.Size = new System.Drawing.Size(129, 28);
            this.cmbPrenomVisiteur.TabIndex = 7;
            // 
            // grpVisiteur
            // 
            this.grpVisiteur.Controls.Add(this.lblPrenomVisiteur);
            this.grpVisiteur.Controls.Add(this.lblNomVisiteur);
            this.grpVisiteur.Controls.Add(this.cmbPrenomVisiteur);
            this.grpVisiteur.Controls.Add(this.cmbNomVisiteur);
            this.grpVisiteur.Location = new System.Drawing.Point(58, 40);
            this.grpVisiteur.Name = "grpVisiteur";
            this.grpVisiteur.Size = new System.Drawing.Size(860, 104);
            this.grpVisiteur.TabIndex = 8;
            this.grpVisiteur.TabStop = false;
            this.grpVisiteur.Text = "Visiteur";
            // 
            // lblPrenomVisiteur
            // 
            this.lblPrenomVisiteur.AutoSize = true;
            this.lblPrenomVisiteur.Location = new System.Drawing.Point(398, 49);
            this.lblPrenomVisiteur.Name = "lblPrenomVisiteur";
            this.lblPrenomVisiteur.Size = new System.Drawing.Size(76, 20);
            this.lblPrenomVisiteur.TabIndex = 9;
            this.lblPrenomVisiteur.Text = "Prenom : ";
            // 
            // lblNomVisiteur
            // 
            this.lblNomVisiteur.AutoSize = true;
            this.lblNomVisiteur.Location = new System.Drawing.Point(65, 49);
            this.lblNomVisiteur.Name = "lblNomVisiteur";
            this.lblNomVisiteur.Size = new System.Drawing.Size(50, 20);
            this.lblNomVisiteur.TabIndex = 8;
            this.lblNomVisiteur.Text = "Nom :";
            // 
            // grpMedecin
            // 
            this.grpMedecin.Controls.Add(this.lblAdresseMedecin);
            this.grpMedecin.Controls.Add(this.lblPrenomMedecin);
            this.grpMedecin.Controls.Add(this.lblNomMedecin);
            this.grpMedecin.Controls.Add(this.cmbAdresseMedecin);
            this.grpMedecin.Controls.Add(this.cmbPrenomMedecin);
            this.grpMedecin.Controls.Add(this.cmbNomMedecin);
            this.grpMedecin.Location = new System.Drawing.Point(58, 150);
            this.grpMedecin.Name = "grpMedecin";
            this.grpMedecin.Size = new System.Drawing.Size(860, 112);
            this.grpMedecin.TabIndex = 9;
            this.grpMedecin.TabStop = false;
            this.grpMedecin.Text = "Medecin";
            // 
            // lblAdresseMedecin
            // 
            this.lblAdresseMedecin.AutoSize = true;
            this.lblAdresseMedecin.Location = new System.Drawing.Point(463, 51);
            this.lblAdresseMedecin.Name = "lblAdresseMedecin";
            this.lblAdresseMedecin.Size = new System.Drawing.Size(80, 20);
            this.lblAdresseMedecin.TabIndex = 5;
            this.lblAdresseMedecin.Text = "Adresse : ";
            // 
            // lblPrenomMedecin
            // 
            this.lblPrenomMedecin.AutoSize = true;
            this.lblPrenomMedecin.Location = new System.Drawing.Point(225, 51);
            this.lblPrenomMedecin.Name = "lblPrenomMedecin";
            this.lblPrenomMedecin.Size = new System.Drawing.Size(76, 20);
            this.lblPrenomMedecin.TabIndex = 4;
            this.lblPrenomMedecin.Text = "Prenom : ";
            // 
            // lblNomMedecin
            // 
            this.lblNomMedecin.AutoSize = true;
            this.lblNomMedecin.Location = new System.Drawing.Point(6, 51);
            this.lblNomMedecin.Name = "lblNomMedecin";
            this.lblNomMedecin.Size = new System.Drawing.Size(50, 20);
            this.lblNomMedecin.TabIndex = 3;
            this.lblNomMedecin.Text = "Nom :";
            // 
            // cmbAdresseMedecin
            // 
            this.cmbAdresseMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceMedecin, "adresse", true));
            this.cmbAdresseMedecin.FormattingEnabled = true;
            this.cmbAdresseMedecin.Location = new System.Drawing.Point(549, 48);
            this.cmbAdresseMedecin.Name = "cmbAdresseMedecin";
            this.cmbAdresseMedecin.Size = new System.Drawing.Size(305, 28);
            this.cmbAdresseMedecin.TabIndex = 2;
            // 
            // cmbPrenomMedecin
            // 
            this.cmbPrenomMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceMedecin, "prenom", true));
            this.cmbPrenomMedecin.FormattingEnabled = true;
            this.cmbPrenomMedecin.Location = new System.Drawing.Point(321, 48);
            this.cmbPrenomMedecin.Name = "cmbPrenomMedecin";
            this.cmbPrenomMedecin.Size = new System.Drawing.Size(121, 28);
            this.cmbPrenomMedecin.TabIndex = 1;
            this.cmbPrenomMedecin.SelectedIndexChanged += new System.EventHandler(this.cmbPrenomMedecin_SelectedIndexChanged);
            // 
            // cmbNomMedecin
            // 
            this.cmbNomMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceMedecin, "nom", true));
            this.cmbNomMedecin.FormattingEnabled = true;
            this.cmbNomMedecin.Location = new System.Drawing.Point(84, 48);
            this.cmbNomMedecin.Name = "cmbNomMedecin";
            this.cmbNomMedecin.Size = new System.Drawing.Size(121, 28);
            this.cmbNomMedecin.TabIndex = 0;
            this.cmbNomMedecin.SelectedIndexChanged += new System.EventHandler(this.cmbNomMedecin_SelectedIndexChanged);
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(217, 292);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(695, 26);
            this.txtMotif.TabIndex = 10;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(127, 426);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(785, 26);
            this.txtBilan.TabIndex = 11;
            // 
            // dateVisite
            // 
            this.dateVisite.Location = new System.Drawing.Point(217, 367);
            this.dateVisite.Name = "dateVisite";
            this.dateVisite.Size = new System.Drawing.Size(249, 26);
            this.dateVisite.TabIndex = 12;
            // 
            // lstMedicament
            // 
            this.lstMedicament.FormattingEnabled = true;
            this.lstMedicament.ItemHeight = 20;
            this.lstMedicament.Location = new System.Drawing.Point(681, 517);
            this.lstMedicament.Name = "lstMedicament";
            this.lstMedicament.Size = new System.Drawing.Size(231, 264);
            this.lstMedicament.TabIndex = 13;
            // 
            // lblMedicament
            // 
            this.lblMedicament.AutoSize = true;
            this.lblMedicament.Location = new System.Drawing.Point(21, 44);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(104, 20);
            this.lblMedicament.TabIndex = 14;
            this.lblMedicament.Text = "Medicament :";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(23, 139);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(82, 20);
            this.lblQuantite.TabIndex = 15;
            this.lblQuantite.Text = "Quantite : ";
            // 
            // cmbNomMedicament
            // 
            this.cmbNomMedicament.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceMedicament, "nomCommercial", true));
            this.cmbNomMedicament.FormattingEnabled = true;
            this.cmbNomMedicament.Location = new System.Drawing.Point(184, 44);
            this.cmbNomMedicament.Name = "cmbNomMedicament";
            this.cmbNomMedicament.Size = new System.Drawing.Size(121, 28);
            this.cmbNomMedicament.TabIndex = 16;
            // 
            // QuantiteMedicament
            // 
            this.QuantiteMedicament.Location = new System.Drawing.Point(184, 139);
            this.QuantiteMedicament.Name = "QuantiteMedicament";
            this.QuantiteMedicament.Size = new System.Drawing.Size(120, 26);
            this.QuantiteMedicament.TabIndex = 17;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(383, 83);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 42);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.Location = new System.Drawing.Point(58, 720);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(543, 61);
            this.btnValider.TabIndex = 19;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // grpDetailVisite
            // 
            this.grpDetailVisite.Controls.Add(this.btnAjouter);
            this.grpDetailVisite.Controls.Add(this.QuantiteMedicament);
            this.grpDetailVisite.Controls.Add(this.cmbNomMedicament);
            this.grpDetailVisite.Controls.Add(this.lblQuantite);
            this.grpDetailVisite.Controls.Add(this.lblMedicament);
            this.grpDetailVisite.Location = new System.Drawing.Point(58, 508);
            this.grpDetailVisite.Name = "grpDetailVisite";
            this.grpDetailVisite.Size = new System.Drawing.Size(603, 190);
            this.grpDetailVisite.TabIndex = 20;
            this.grpDetailVisite.TabStop = false;
            this.grpDetailVisite.Text = "Details";
            // 
            // lblMedicamentsOffert
            // 
            this.lblMedicamentsOffert.AutoSize = true;
            this.lblMedicamentsOffert.Location = new System.Drawing.Point(702, 481);
            this.lblMedicamentsOffert.Name = "lblMedicamentsOffert";
            this.lblMedicamentsOffert.Size = new System.Drawing.Size(162, 20);
            this.lblMedicamentsOffert.TabIndex = 21;
            this.lblMedicamentsOffert.Text = "Medicaments offerts :";
            // 
            // bdgSourceMedicament
            // 
            this.bdgSourceMedicament.DataSource = typeof(GsbRapports.medicament);
            // 
            // bdgSourceMedecin
            // 
            this.bdgSourceMedecin.DataSource = typeof(GsbRapports.medecin);
            // 
            // bdgSourceVisiteur
            // 
            this.bdgSourceVisiteur.DataSource = typeof(GsbRapports.visiteur);
            // 
            // frmAjoutRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 813);
            this.Controls.Add(this.lblMedicamentsOffert);
            this.Controls.Add(this.grpDetailVisite);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lstMedicament);
            this.Controls.Add(this.dateVisite);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.grpMedecin);
            this.Controls.Add(this.grpVisiteur);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMotif);
            this.Name = "frmAjoutRapports";
            this.Text = "Ajouter Rapport";
            this.Load += new System.EventHandler(this.frmAjoutRapports_Load);
            this.grpVisiteur.ResumeLayout(false);
            this.grpVisiteur.PerformLayout();
            this.grpMedecin.ResumeLayout(false);
            this.grpMedecin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteMedicament)).EndInit();
            this.grpDetailVisite.ResumeLayout(false);
            this.grpDetailVisite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbNomVisiteur;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.ComboBox cmbPrenomVisiteur;
        private System.Windows.Forms.GroupBox grpVisiteur;
        private System.Windows.Forms.GroupBox grpMedecin;
        private System.Windows.Forms.ComboBox cmbAdresseMedecin;
        private System.Windows.Forms.ComboBox cmbPrenomMedecin;
        private System.Windows.Forms.ComboBox cmbNomMedecin;
        private System.Windows.Forms.Label lblPrenomVisiteur;
        private System.Windows.Forms.Label lblNomVisiteur;
        private System.Windows.Forms.Label lblAdresseMedecin;
        private System.Windows.Forms.Label lblPrenomMedecin;
        private System.Windows.Forms.Label lblNomMedecin;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.DateTimePicker dateVisite;
        private System.Windows.Forms.ListBox lstMedicament;
        private System.Windows.Forms.Label lblMedicament;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.ComboBox cmbNomMedicament;
        private System.Windows.Forms.NumericUpDown QuantiteMedicament;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox grpDetailVisite;
        private System.Windows.Forms.Label lblMedicamentsOffert;
        private System.Windows.Forms.BindingSource bdgSourceVisiteur;
        private System.Windows.Forms.BindingSource bdgSourceMedecin;
        private System.Windows.Forms.BindingSource bdgSourceMedicament;
    }
}