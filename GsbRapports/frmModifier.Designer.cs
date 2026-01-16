namespace GsbRapports
{
    partial class frmModifier
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
            this.lbldate = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.cmbPrenom = new System.Windows.Forms.ComboBox();
            this.bdgSourceModifier = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNom = new System.Windows.Forms.ComboBox();
            this.vldValider = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgSourceGrid = new System.Windows.Forms.BindingSource(this.components);
            this.btnRapports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(102, 59);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(52, 20);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Date :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(102, 137);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(219, 59);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(262, 26);
            this.dtDate.TabIndex = 2;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(102, 218);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(72, 20);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom :";
            // 
            // cmbPrenom
            // 
            this.cmbPrenom.DataSource = this.bdgSourceModifier;
            this.cmbPrenom.FormattingEnabled = true;
            this.cmbPrenom.Location = new System.Drawing.Point(219, 215);
            this.cmbPrenom.Name = "cmbPrenom";
            this.cmbPrenom.Size = new System.Drawing.Size(121, 28);
            this.cmbPrenom.TabIndex = 6;
            // 
            // bdgSourceModifier
            // 
            this.bdgSourceModifier.DataSource = typeof(GsbRapports.visiteur);
            // 
            // cmbNom
            // 
            this.cmbNom.FormattingEnabled = true;
            this.cmbNom.Location = new System.Drawing.Point(219, 134);
            this.cmbNom.Name = "cmbNom";
            this.cmbNom.Size = new System.Drawing.Size(121, 28);
            this.cmbNom.TabIndex = 7;
            this.cmbNom.SelectedIndexChanged += new System.EventHandler(this.cmbNom_SelectedIndexChanged);
            // 
            // vldValider
            // 
            this.vldValider.BackColor = System.Drawing.Color.Lime;
            this.vldValider.Location = new System.Drawing.Point(68, 305);
            this.vldValider.Name = "vldValider";
            this.vldValider.Size = new System.Drawing.Size(413, 81);
            this.vldValider.TabIndex = 8;
            this.vldValider.Text = "Valider";
            this.vldValider.UseVisualStyleBackColor = false;
            this.vldValider.Click += new System.EventHandler(this.vldValider_Click);
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
            this.dataGridView1.DataSource = this.bdgSourceGrid;
            this.dataGridView1.Location = new System.Drawing.Point(560, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(962, 239);
            this.dataGridView1.TabIndex = 9;
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
            this.motifDataGridViewTextBoxColumn.Width = 150;
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
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
            // bdgSourceGrid
            // 
            this.bdgSourceGrid.DataSource = typeof(GsbRapports.rapport);
            // 
            // btnRapports
            // 
            this.btnRapports.BackColor = System.Drawing.Color.Lime;
            this.btnRapports.Location = new System.Drawing.Point(560, 307);
            this.btnRapports.Name = "btnRapports";
            this.btnRapports.Size = new System.Drawing.Size(962, 79);
            this.btnRapports.TabIndex = 10;
            this.btnRapports.Text = "Valider Selection";
            this.btnRapports.UseVisualStyleBackColor = false;
            this.btnRapports.Click += new System.EventHandler(this.btnRapports_Click);
            // 
            // frmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 556);
            this.Controls.Add(this.btnRapports);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vldValider);
            this.Controls.Add(this.cmbNom);
            this.Controls.Add(this.cmbPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lbldate);
            this.Name = "frmModifier";
            this.Text = "frmModifier";
            this.Load += new System.EventHandler(this.frmModifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.ComboBox cmbPrenom;
        private System.Windows.Forms.ComboBox cmbNom;
        private System.Windows.Forms.Button vldValider;
        private System.Windows.Forms.BindingSource bdgSourceModifier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bdgSourceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRapports;
    }
}