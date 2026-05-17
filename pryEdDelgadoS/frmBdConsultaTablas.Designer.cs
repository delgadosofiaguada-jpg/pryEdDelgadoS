namespace pryEdDelgadoS
{
    partial class frmBdConsultaTablas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBdConsultaTablas));
            this.dgvConsultaTabla = new System.Windows.Forms.DataGridView();
            this.lblTabla = new System.Windows.Forms.Label();
            this.cbTablas = new System.Windows.Forms.ComboBox();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaTabla
            // 
            this.dgvConsultaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaTabla.Location = new System.Drawing.Point(12, 37);
            this.dgvConsultaTabla.Name = "dgvConsultaTabla";
            this.dgvConsultaTabla.RowHeadersWidth = 51;
            this.dgvConsultaTabla.RowTemplate.Height = 24;
            this.dgvConsultaTabla.Size = new System.Drawing.Size(860, 394);
            this.dgvConsultaTabla.TabIndex = 0;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(12, 471);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(206, 18);
            this.lblTabla.TabIndex = 1;
            this.lblTabla.Text = "Tabla de la base de datos:";
            // 
            // cbTablas
            // 
            this.cbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTablas.FormattingEnabled = true;
            this.cbTablas.Location = new System.Drawing.Point(254, 463);
            this.cbTablas.Name = "cbTablas";
            this.cbTablas.Size = new System.Drawing.Size(204, 26);
            this.cbTablas.TabIndex = 2;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(486, 457);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(141, 39);
            this.cmdListar.TabIndex = 3;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmBdConsultaTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(885, 521);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cbTablas);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvConsultaTabla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBdConsultaTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de una Tabla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaTabla;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ComboBox cbTablas;
        private System.Windows.Forms.Button cmdListar;
    }
}