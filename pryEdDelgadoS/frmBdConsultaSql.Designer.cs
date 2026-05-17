namespace pryEdDelgadoS
{
    partial class frmBdConsultaSql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBdConsultaSql));
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvConsultaSQL = new System.Windows.Forms.DataGridView();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(17, 36);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(776, 165);
            this.txtConsulta.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(158, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Consulta en SQL:";
            // 
            // dgvConsultaSQL
            // 
            this.dgvConsultaSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaSQL.Location = new System.Drawing.Point(17, 266);
            this.dgvConsultaSQL.Name = "dgvConsultaSQL";
            this.dgvConsultaSQL.RowHeadersWidth = 51;
            this.dgvConsultaSQL.RowTemplate.Height = 24;
            this.dgvConsultaSQL.Size = new System.Drawing.Size(771, 252);
            this.dgvConsultaSQL.TabIndex = 2;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(670, 217);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(123, 31);
            this.cmdListar.TabIndex = 3;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // frmBdConsultaSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(816, 543);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.dgvConsultaSQL);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBdConsultaSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas en la Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvConsultaSQL;
        private System.Windows.Forms.Button cmdListar;
    }
}