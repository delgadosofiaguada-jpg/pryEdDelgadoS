namespace pryEdDelgadoS
{
    partial class frmDatosdelDesarrollador
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
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblTituloDatosP = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCarreraaa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(12, 86);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(164, 16);
            this.lblNombreApellido.TabIndex = 0;
            this.lblNombreApellido.Text = "Sofía Guadalupe Delgado";
            // 
            // lblTituloDatosP
            // 
            this.lblTituloDatosP.AutoSize = true;
            this.lblTituloDatosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDatosP.ForeColor = System.Drawing.Color.Brown;
            this.lblTituloDatosP.Location = new System.Drawing.Point(88, 30);
            this.lblTituloDatosP.Name = "lblTituloDatosP";
            this.lblTituloDatosP.Size = new System.Drawing.Size(172, 16);
            this.lblTituloDatosP.TabIndex = 3;
            this.lblTituloDatosP.Text = "Datos del desarrollador";
            this.lblTituloDatosP.Click += new System.EventHandler(this.lblTituloDatosP_Click);
            // 
            // txtMail
            // 
            this.txtMail.AutoSize = true;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(12, 238);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(186, 15);
            this.txtMail.TabIndex = 9;
            this.txtMail.Text = "delgado.sofiaguada@gmail.com";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 266);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(157, 15);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "GitHub: delgadosofiaguada";
            this.lblFechaNacimiento.Click += new System.EventHandler(this.lblFechaNacimiento_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.White;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.Brown;
            this.cmdSalir.Location = new System.Drawing.Point(301, 354);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 24);
            this.cmdSalir.TabIndex = 14;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEdDelgadoS.Properties.Resources.wii;
            this.pictureBox1.Location = new System.Drawing.Point(263, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCarreraaa
            // 
            this.lblCarreraaa.AutoSize = true;
            this.lblCarreraaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreraaa.Location = new System.Drawing.Point(12, 126);
            this.lblCarreraaa.Name = "lblCarreraaa";
            this.lblCarreraaa.Size = new System.Drawing.Size(196, 15);
            this.lblCarreraaa.TabIndex = 16;
            this.lblCarreraaa.Text = "Estudiante en análisis de sistemas";
            // 
            // frmDatosdelDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(407, 390);
            this.Controls.Add(this.lblCarreraaa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblTituloDatosP);
            this.Controls.Add(this.lblNombreApellido);
            this.Name = "frmDatosdelDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosdelDesarrollador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblTituloDatosP;
        private System.Windows.Forms.Label txtMail;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCarreraaa;
    }
}