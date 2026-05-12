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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeses));
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.lblNombreMes = new System.Windows.Forms.Label();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.txtNombreMes = new System.Windows.Forms.TextBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.Color.White;
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(20, 119);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(125, 28);
            this.cmdLimpiar.TabIndex = 0;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // lblNombreMes
            // 
            this.lblNombreMes.AutoSize = true;
            this.lblNombreMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMes.Location = new System.Drawing.Point(16, 73);
            this.lblNombreMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMes.Name = "lblNombreMes";
            this.lblNombreMes.Size = new System.Drawing.Size(66, 18);
            this.lblNombreMes.TabIndex = 1;
            this.lblNombreMes.Text = "Nombre:";
            // 
            // lstMeses
            // 
            this.lstMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 18;
            this.lstMeses.Location = new System.Drawing.Point(20, 177);
            this.lstMeses.Margin = new System.Windows.Forms.Padding(4);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(301, 130);
            this.lstMeses.TabIndex = 2;
            // 
            // txtNombreMes
            // 
            this.txtNombreMes.Location = new System.Drawing.Point(87, 69);
            this.txtNombreMes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMes.Name = "txtNombreMes";
            this.txtNombreMes.Size = new System.Drawing.Size(235, 22);
            this.txtNombreMes.TabIndex = 3;
            this.txtNombreMes.TextChanged += new System.EventHandler(this.txtNombreMes_TextChanged);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.White;
            this.cmdGrabar.Enabled = false;
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(184, 119);
            this.cmdGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(139, 28);
            this.cmdGrabar.TabIndex = 4;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el mes";
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(339, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.txtNombreMes);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.lblNombreMes);
            this.Controls.Add(this.cmdLimpiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Meses";
            this.Load += new System.EventHandler(this.frmMeses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Label lblNombreMes;
        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.TextBox txtNombreMes;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Label label1;
    }
}