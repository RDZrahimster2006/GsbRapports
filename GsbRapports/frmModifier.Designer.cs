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
            this.cmbNom = new System.Windows.Forms.ComboBox();
            this.vldValider = new System.Windows.Forms.Button();
            this.bdgSourceModifier = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceModifier)).BeginInit();
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
            this.cmbPrenom.FormattingEnabled = true;
            this.cmbPrenom.Location = new System.Drawing.Point(219, 215);
            this.cmbPrenom.Name = "cmbPrenom";
            this.cmbPrenom.Size = new System.Drawing.Size(121, 28);
            this.cmbPrenom.TabIndex = 6;
            // 
            // cmbNom
            // 
            this.cmbNom.FormattingEnabled = true;
            this.cmbNom.Location = new System.Drawing.Point(219, 134);
            this.cmbNom.Name = "cmbNom";
            this.cmbNom.Size = new System.Drawing.Size(121, 28);
            this.cmbNom.TabIndex = 7;
            // 
            // vldValider
            // 
            this.vldValider.BackColor = System.Drawing.Color.Lime;
            this.vldValider.Location = new System.Drawing.Point(24, 346);
            this.vldValider.Name = "vldValider";
            this.vldValider.Size = new System.Drawing.Size(764, 81);
            this.vldValider.TabIndex = 8;
            this.vldValider.Text = "Valider";
            this.vldValider.UseVisualStyleBackColor = false;
            // 
            // bdgSourceModifier
            // 
            this.bdgSourceModifier.DataSource = typeof(GsbRapports.visiteur);
            // 
            // frmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vldValider);
            this.Controls.Add(this.cmbNom);
            this.Controls.Add(this.cmbPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lbldate);
            this.Name = "frmModifier";
            this.Text = "frmModifier";
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceModifier)).EndInit();
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
    }
}