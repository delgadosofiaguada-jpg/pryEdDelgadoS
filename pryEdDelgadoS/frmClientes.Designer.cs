namespace pryEdDelgadoS
{
    partial class frmClientes
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
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.lblDeudaCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.mtbCodigoCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.cmdGrabarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.Location = new System.Drawing.Point(12, 24);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(126, 16);
            this.lblTituloClientes.TabIndex = 0;
            this.lblTituloClientes.Text = "Ingrese el cliente";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(15, 81);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(49, 15);
            this.lblCodigoCliente.TabIndex = 1;
            this.lblCodigoCliente.Text = "Código:";
            // 
            // lblDeudaCliente
            // 
            this.lblDeudaCliente.AutoSize = true;
            this.lblDeudaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeudaCliente.Location = new System.Drawing.Point(15, 180);
            this.lblDeudaCliente.Name = "lblDeudaCliente";
            this.lblDeudaCliente.Size = new System.Drawing.Size(47, 15);
            this.lblDeudaCliente.TabIndex = 2;
            this.lblDeudaCliente.Text = "Deuda:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(15, 129);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(55, 15);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // mtbCodigoCliente
            // 
            this.mtbCodigoCliente.Location = new System.Drawing.Point(141, 76);
            this.mtbCodigoCliente.Mask = "999999";
            this.mtbCodigoCliente.Name = "mtbCodigoCliente";
            this.mtbCodigoCliente.Size = new System.Drawing.Size(212, 20);
            this.mtbCodigoCliente.TabIndex = 4;
            this.mtbCodigoCliente.ValidatingType = typeof(int);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(141, 128);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(212, 20);
            this.txtNombreCliente.TabIndex = 5;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(141, 175);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(212, 20);
            this.txtDeuda.TabIndex = 6;
            // 
            // cmdGrabarCliente
            // 
            this.cmdGrabarCliente.BackColor = System.Drawing.Color.White;
            this.cmdGrabarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabarCliente.Location = new System.Drawing.Point(259, 217);
            this.cmdGrabarCliente.Name = "cmdGrabarCliente";
            this.cmdGrabarCliente.Size = new System.Drawing.Size(94, 23);
            this.cmdGrabarCliente.TabIndex = 7;
            this.cmdGrabarCliente.Text = "Grabar";
            this.cmdGrabarCliente.UseVisualStyleBackColor = false;
            this.cmdGrabarCliente.Click += new System.EventHandler(this.cmdGrabarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCódigo,
            this.ClNombre,
            this.ClDeuda});
            this.dgvClientes.Location = new System.Drawing.Point(12, 260);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(341, 150);
            this.dgvClientes.TabIndex = 8;
            // 
            // clCódigo
            // 
            this.clCódigo.HeaderText = "Código";
            this.clCódigo.Name = "clCódigo";
            // 
            // ClNombre
            // 
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.Name = "ClNombre";
            // 
            // ClDeuda
            // 
            this.ClDeuda.HeaderText = "Deuda";
            this.ClDeuda.Name = "ClDeuda";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(365, 422);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.cmdGrabarCliente);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.mtbCodigoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblDeudaCliente);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.lblTituloClientes);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Label lblDeudaCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.MaskedTextBox mtbCodigoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Button cmdGrabarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDeuda;
    }
}