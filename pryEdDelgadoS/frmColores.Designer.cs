namespace pryEdDelgadoS
{
    partial class frmColores
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
            this.lblNombreColor = new System.Windows.Forms.Label();
            this.txtNombreColor = new System.Windows.Forms.TextBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombreColor
            // 
            this.lblNombreColor.AutoSize = true;
            this.lblNombreColor.Location = new System.Drawing.Point(52, 31);
            this.lblNombreColor.Name = "lblNombreColor";
            this.lblNombreColor.Size = new System.Drawing.Size(47, 13);
            this.lblNombreColor.TabIndex = 0;
            this.lblNombreColor.Text = "Nombre:";
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.Location = new System.Drawing.Point(114, 24);
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(128, 20);
            this.txtNombreColor.TabIndex = 1;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(55, 83);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(167, 83);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(75, 23);
            this.cmdGrabar.TabIndex = 3;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.Location = new System.Drawing.Point(55, 147);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(187, 95);
            this.lstColores.TabIndex = 5;
            this.lstColores.SelectedIndexChanged += new System.EventHandler(this.lstColores_SelectedIndexChanged);
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.txtNombreColor);
            this.Controls.Add(this.lblNombreColor);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreColor;
        private System.Windows.Forms.TextBox txtNombreColor;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.ListBox lstColores;
    }
}