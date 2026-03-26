namespace pryEdDelgadoS
{
    partial class frmMeses
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
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblNombreMes = new System.Windows.Forms.Label();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.txtNombreMes = new System.Windows.Forms.TextBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(51, 75);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 0;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // lblNombreMes
            // 
            this.lblNombreMes.AutoSize = true;
            this.lblNombreMes.Location = new System.Drawing.Point(48, 37);
            this.lblNombreMes.Name = "lblNombreMes";
            this.lblNombreMes.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMes.TabIndex = 1;
            this.lblNombreMes.Text = "Nombre:";
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.Location = new System.Drawing.Point(51, 122);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(168, 95);
            this.lstMeses.TabIndex = 2;
            // 
            // txtNombreMes
            // 
            this.txtNombreMes.Location = new System.Drawing.Point(119, 30);
            this.txtNombreMes.Name = "txtNombreMes";
            this.txtNombreMes.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMes.TabIndex = 3;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(144, 75);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(75, 23);
            this.cmdGrabar.TabIndex = 4;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.txtNombreMes);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.lblNombreMes);
            this.Controls.Add(this.cmdListar);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMeses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lblNombreMes;
        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.TextBox txtNombreMes;
        private System.Windows.Forms.Button cmdGrabar;
    }
}