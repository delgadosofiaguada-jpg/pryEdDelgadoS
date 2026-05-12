namespace pryEdDelgadoS
{
    partial class frmCarreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreras));
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblTituloCarrera = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.cmdGrabarCarrera = new System.Windows.Forms.Button();
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(23, 75);
            this.lblCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(62, 18);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Carrera;";
            // 
            // lblTituloCarrera
            // 
            this.lblTituloCarrera.AutoSize = true;
            this.lblTituloCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCarrera.Location = new System.Drawing.Point(16, 25);
            this.lblTituloCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCarrera.Name = "lblTituloCarrera";
            this.lblTituloCarrera.Size = new System.Drawing.Size(159, 20);
            this.lblTituloCarrera.TabIndex = 1;
            this.lblTituloCarrera.Text = "Ingrese la carrera";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(99, 74);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(217, 22);
            this.txtCarrera.TabIndex = 2;
            this.txtCarrera.TextChanged += new System.EventHandler(this.txtCarrera_TextChanged);
            // 
            // cmdGrabarCarrera
            // 
            this.cmdGrabarCarrera.Enabled = false;
            this.cmdGrabarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabarCarrera.Location = new System.Drawing.Point(192, 126);
            this.cmdGrabarCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGrabarCarrera.Name = "cmdGrabarCarrera";
            this.cmdGrabarCarrera.Size = new System.Drawing.Size(125, 28);
            this.cmdGrabarCarrera.TabIndex = 3;
            this.cmdGrabarCarrera.Text = "Grabar";
            this.cmdGrabarCarrera.UseVisualStyleBackColor = true;
            this.cmdGrabarCarrera.Click += new System.EventHandler(this.cmdGrabarCarrera_Click);
            // 
            // lstCarreras
            // 
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.ItemHeight = 16;
            this.lstCarreras.Location = new System.Drawing.Point(16, 198);
            this.lstCarreras.Margin = new System.Windows.Forms.Padding(4);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(300, 196);
            this.lstCarreras.TabIndex = 4;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(27, 126);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(117, 28);
            this.cmdLimpiar.TabIndex = 5;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(331, 405);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.cmdGrabarCarrera);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblTituloCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Carreras";
            this.Load += new System.EventHandler(this.frmCarreras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblTituloCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Button cmdGrabarCarrera;
        private System.Windows.Forms.ListBox lstCarreras;
        private System.Windows.Forms.Button cmdLimpiar;
    }
}