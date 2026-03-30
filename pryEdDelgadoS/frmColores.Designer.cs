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
            this.lblTituloColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreColor
            // 
            this.lblNombreColor.AutoSize = true;
            this.lblNombreColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColor.Location = new System.Drawing.Point(14, 67);
            this.lblNombreColor.Name = "lblNombreColor";
            this.lblNombreColor.Size = new System.Drawing.Size(55, 15);
            this.lblNombreColor.TabIndex = 0;
            this.lblNombreColor.Text = "Nombre:";
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.Location = new System.Drawing.Point(75, 67);
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(179, 20);
            this.txtNombreColor.TabIndex = 1;
            this.txtNombreColor.TextChanged += new System.EventHandler(this.txtNombreColor_TextChanged);
            // 
            // cmdListar
            // 
            this.cmdListar.BackColor = System.Drawing.Color.White;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(15, 109);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(93, 23);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = false;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.White;
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdGrabar.Location = new System.Drawing.Point(147, 109);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(107, 23);
            this.cmdGrabar.TabIndex = 3;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // lstColores
            // 
            this.lstColores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstColores.FormattingEnabled = true;
            this.lstColores.ItemHeight = 15;
            this.lstColores.Location = new System.Drawing.Point(15, 158);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(239, 124);
            this.lstColores.TabIndex = 5;
            this.lstColores.SelectedIndexChanged += new System.EventHandler(this.lstColores_SelectedIndexChanged);
            // 
            // lblTituloColor
            // 
            this.lblTituloColor.AutoSize = true;
            this.lblTituloColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloColor.Location = new System.Drawing.Point(12, 26);
            this.lblTituloColor.Name = "lblTituloColor";
            this.lblTituloColor.Size = new System.Drawing.Size(115, 16);
            this.lblTituloColor.TabIndex = 6;
            this.lblTituloColor.Text = "Ingrese el color";
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(266, 289);
            this.Controls.Add(this.lblTituloColor);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.txtNombreColor);
            this.Controls.Add(this.lblNombreColor);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColores";
            this.Load += new System.EventHandler(this.frmColores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreColor;
        private System.Windows.Forms.TextBox txtNombreColor;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.ListBox lstColores;
        private System.Windows.Forms.Label lblTituloColor;
    }
}