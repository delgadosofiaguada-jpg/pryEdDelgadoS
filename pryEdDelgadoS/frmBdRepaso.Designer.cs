namespace pryEdDelgadoS
{
    partial class frmBdRepaso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBdRepaso));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbEleccion = new System.Windows.Forms.ComboBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Operación a realizar en la base de datos:";
            // 
            // cbEleccion
            // 
            this.cbEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEleccion.FormattingEnabled = true;
            this.cbEleccion.Location = new System.Drawing.Point(322, 16);
            this.cbEleccion.Name = "cbEleccion";
            this.cbEleccion.Size = new System.Drawing.Size(337, 26);
            this.cbEleccion.TabIndex = 1;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(687, 14);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(121, 28);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(15, 92);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.RowHeadersWidth = 51;
            this.dgvListar.RowTemplate.Height = 24;
            this.dgvListar.Size = new System.Drawing.Size(793, 390);
            this.dgvListar.TabIndex = 3;
            // 
            // frmBdRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cbEleccion);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBdRepaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbEleccion;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView dgvListar;
    }
}