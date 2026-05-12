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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.lblDeudaCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.mtbCodigoCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.cmdGrabarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cmdLimpiar = new System.Windows.Forms.Button();
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
            this.lblTituloClientes.Location = new System.Drawing.Point(16, 30);
            this.lblTituloClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(154, 20);
            this.lblTituloClientes.TabIndex = 0;
            this.lblTituloClientes.Text = "Ingrese el cliente";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(20, 100);
            this.lblCodigoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(60, 18);
            this.lblCodigoCliente.TabIndex = 1;
            this.lblCodigoCliente.Text = "Código:";
            // 
            // lblDeudaCliente
            // 
            this.lblDeudaCliente.AutoSize = true;
            this.lblDeudaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeudaCliente.Location = new System.Drawing.Point(20, 222);
            this.lblDeudaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeudaCliente.Name = "lblDeudaCliente";
            this.lblDeudaCliente.Size = new System.Drawing.Size(55, 18);
            this.lblDeudaCliente.TabIndex = 2;
            this.lblDeudaCliente.Text = "Deuda:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 159);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(66, 18);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // mtbCodigoCliente
            // 
            this.mtbCodigoCliente.Location = new System.Drawing.Point(229, 96);
            this.mtbCodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCodigoCliente.Mask = "999999";
            this.mtbCodigoCliente.Name = "mtbCodigoCliente";
            this.mtbCodigoCliente.Size = new System.Drawing.Size(281, 22);
            this.mtbCodigoCliente.TabIndex = 4;
            this.mtbCodigoCliente.ValidatingType = typeof(int);
            this.mtbCodigoCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCodigoCliente_MaskInputRejected);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(229, 160);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(281, 22);
            this.txtNombreCliente.TabIndex = 5;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(229, 217);
            this.txtDeuda.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(281, 22);
            this.txtDeuda.TabIndex = 6;
            this.txtDeuda.TextChanged += new System.EventHandler(this.txtDeuda_TextChanged);
            // 
            // cmdGrabarCliente
            // 
            this.cmdGrabarCliente.BackColor = System.Drawing.Color.White;
            this.cmdGrabarCliente.Enabled = false;
            this.cmdGrabarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabarCliente.Location = new System.Drawing.Point(386, 269);
            this.cmdGrabarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGrabarCliente.Name = "cmdGrabarCliente";
            this.cmdGrabarCliente.Size = new System.Drawing.Size(125, 28);
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
            this.dgvClientes.Location = new System.Drawing.Point(16, 320);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(504, 185);
            this.dgvClientes.TabIndex = 8;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.Color.White;
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(229, 269);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(125, 28);
            this.cmdLimpiar.TabIndex = 9;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // clCódigo
            // 
            this.clCódigo.HeaderText = "Código";
            this.clCódigo.MinimumWidth = 6;
            this.clCódigo.Name = "clCódigo";
            this.clCódigo.Width = 90;
            // 
            // ClNombre
            // 
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.MinimumWidth = 6;
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.Width = 130;
            // 
            // ClDeuda
            // 
            this.ClDeuda.HeaderText = "Deuda";
            this.ClDeuda.MinimumWidth = 6;
            this.ClDeuda.Name = "ClDeuda";
            this.ClDeuda.Width = 110;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(529, 519);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.cmdGrabarCliente);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.mtbCodigoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblDeudaCliente);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.lblTituloClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Clientes";
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
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDeuda;
    }
}