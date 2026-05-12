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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColores));
            this.lblNombreColor = new System.Windows.Forms.Label();
            this.txtNombreColor = new System.Windows.Forms.TextBox();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.lblTituloColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreColor
            // 
            this.lblNombreColor.AutoSize = true;
            this.lblNombreColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColor.Location = new System.Drawing.Point(19, 82);
            this.lblNombreColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreColor.Name = "lblNombreColor";
            this.lblNombreColor.Size = new System.Drawing.Size(66, 18);
            this.lblNombreColor.TabIndex = 0;
            this.lblNombreColor.Text = "Nombre:";
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.Location = new System.Drawing.Point(100, 82);
            this.txtNombreColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(237, 22);
            this.txtNombreColor.TabIndex = 1;
            this.txtNombreColor.TextChanged += new System.EventHandler(this.txtNombreColor_TextChanged);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.Color.White;
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(20, 134);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(124, 28);
            this.cmdLimpiar.TabIndex = 2;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.White;
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdGrabar.Location = new System.Drawing.Point(196, 134);
            this.cmdGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(143, 28);
            this.cmdGrabar.TabIndex = 3;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // lstColores
            // 
            this.lstColores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstColores.FormattingEnabled = true;
            this.lstColores.ItemHeight = 18;
            this.lstColores.Location = new System.Drawing.Point(20, 194);
            this.lstColores.Margin = new System.Windows.Forms.Padding(4);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(317, 148);
            this.lstColores.TabIndex = 5;
            this.lstColores.SelectedIndexChanged += new System.EventHandler(this.lstColores_SelectedIndexChanged);
            // 
            // lblTituloColor
            // 
            this.lblTituloColor.AutoSize = true;
            this.lblTituloColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloColor.Location = new System.Drawing.Point(16, 32);
            this.lblTituloColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloColor.Name = "lblTituloColor";
            this.lblTituloColor.Size = new System.Drawing.Size(140, 20);
            this.lblTituloColor.TabIndex = 6;
            this.lblTituloColor.Text = "Ingrese el color";
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(355, 356);
            this.Controls.Add(this.lblTituloColor);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.txtNombreColor);
            this.Controls.Add(this.lblNombreColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Colores";
            this.Load += new System.EventHandler(this.frmColores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreColor;
        private System.Windows.Forms.TextBox txtNombreColor;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.ListBox lstColores;
        private System.Windows.Forms.Label lblTituloColor;
    }
}