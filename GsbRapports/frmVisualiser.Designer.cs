namespace GsbRapports
{
    partial class frmVisualiser
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
            this.cmbNom = new System.Windows.Forms.ComboBox();
            this.bdgSourceVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPrenom = new System.Windows.Forms.ComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdgSourceRapport = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNom
            // 
            this.cmbNom.FormattingEnabled = true;
            this.cmbNom.Location = new System.Drawing.Point(116, 201);
            this.cmbNom.Name = "cmbNom";
            this.cmbNom.Size = new System.Drawing.Size(121, 28);
            this.cmbNom.TabIndex = 0;
            // 
            // bdgSourceVisiteur
            // 
            this.bdgSourceVisiteur.DataSource = typeof(GsbRapports.visiteur);
            // 
            // cmbPrenom
            // 
            this.cmbPrenom.DataSource = this.bdgSourceVisiteur;
            this.cmbPrenom.FormattingEnabled = true;
            this.cmbPrenom.Location = new System.Drawing.Point(116, 289);
            this.cmbPrenom.Name = "cmbPrenom";
            this.cmbPrenom.Size = new System.Drawing.Size(121, 28);
            this.cmbPrenom.TabIndex = 1;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(116, 104);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(247, 26);
            this.dtDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 104);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 204);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 20);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 301);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(72, 20);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom :";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.Location = new System.Drawing.Point(16, 371);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(274, 77);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Lime;
            this.btnEnregistrer.Location = new System.Drawing.Point(456, 371);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(962, 77);
            this.btnEnregistrer.TabIndex = 7;
            this.btnEnregistrer.Text = "Telecharger XML";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.bilanDataGridViewTextBoxColumn,
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idMedecinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdgSourceRapport;
            this.dataGridView1.Location = new System.Drawing.Point(456, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(962, 305);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bdgSourceRapport
            // 
            this.bdgSourceRapport.DataSource = typeof(GsbRapports.rapport);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "motif";
            this.motifDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            this.motifDataGridViewTextBoxColumn.ReadOnly = true;
            this.motifDataGridViewTextBoxColumn.Width = 150;
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            this.bilanDataGridViewTextBoxColumn.ReadOnly = true;
            this.bilanDataGridViewTextBoxColumn.Width = 150;
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            this.idVisiteurDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVisiteurDataGridViewTextBoxColumn.Width = 150;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            this.idMedecinDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMedecinDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmVisualiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cmbPrenom);
            this.Controls.Add(this.cmbNom);
            this.Name = "frmVisualiser";
            this.Text = "frmVisualiser";
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNom;
        private System.Windows.Forms.ComboBox cmbPrenom;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bdgSourceVisiteur;
        private System.Windows.Forms.BindingSource bdgSourceRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
    }
}