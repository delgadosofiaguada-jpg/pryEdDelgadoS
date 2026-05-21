namespace pryEdDelgadoS
{
    partial class frmArbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbol));
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdEquilibrar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbInOrden = new System.Windows.Forms.RadioButton();
            this.gbNuevoElemento.SuspendLayout();
            this.gbEliminar.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(9, 10);
            this.trvArbol.Margin = new System.Windows.Forms.Padding(2);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(199, 192);
            this.trvArbol.TabIndex = 0;
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.cmdAgregar);
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.lblTramite);
            this.gbNuevoElemento.Controls.Add(this.lblNombre);
            this.gbNuevoElemento.Controls.Add(this.lblCod);
            this.gbNuevoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuevoElemento.Location = new System.Drawing.Point(260, 10);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(2);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(2);
            this.gbNuevoElemento.Size = new System.Drawing.Size(178, 191);
            this.gbNuevoElemento.TabIndex = 1;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(16, 145);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(158, 32);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(74, 102);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(2);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(101, 21);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(101, 21);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(74, 31);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(101, 21);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(14, 107);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(52, 15);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 71);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(14, 35);
            this.lblCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(49, 15);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.cbCodigo);
            this.gbEliminar.Controls.Add(this.cmdEliminar);
            this.gbEliminar.Controls.Add(this.label3);
            this.gbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminar.Location = new System.Drawing.Point(471, 11);
            this.gbEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Padding = new System.Windows.Forms.Padding(2);
            this.gbEliminar.Size = new System.Drawing.Size(178, 123);
            this.gbEliminar.TabIndex = 7;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Elemento a Eliminar";
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(63, 32);
            this.cbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(111, 23);
            this.cbCodigo.TabIndex = 7;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(16, 72);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(158, 32);
            this.cmdEliminar.TabIndex = 6;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // cmdEquilibrar
            // 
            this.cmdEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEquilibrar.Location = new System.Drawing.Point(479, 155);
            this.cmdEquilibrar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEquilibrar.Name = "cmdEquilibrar";
            this.cmdEquilibrar.Size = new System.Drawing.Size(158, 32);
            this.cmdEquilibrar.TabIndex = 8;
            this.cmdEquilibrar.Text = "Equilibrar";
            this.cmdEquilibrar.UseVisualStyleBackColor = true;
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.rbPostOrden);
            this.gbListado.Controls.Add(this.rbPreOrden);
            this.gbListado.Controls.Add(this.rbInOrden);
            this.gbListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListado.Location = new System.Drawing.Point(9, 230);
            this.gbListado.Margin = new System.Windows.Forms.Padding(2);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(2);
            this.gbListado.Size = new System.Drawing.Size(644, 179);
            this.gbListado.TabIndex = 7;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado del Árbol";
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clNombre,
            this.clTramite});
            this.dgvListado.Location = new System.Drawing.Point(212, 19);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.Size = new System.Drawing.Size(428, 139);
            this.dgvListado.TabIndex = 3;
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.MinimumWidth = 6;
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.Width = 125;
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.MinimumWidth = 6;
            this.clNombre.Name = "clNombre";
            this.clNombre.Width = 150;
            // 
            // clTramite
            // 
            this.clTramite.HeaderText = "Trámite";
            this.clTramite.MinimumWidth = 6;
            this.clTramite.Name = "clTramite";
            this.clTramite.Width = 120;
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(26, 120);
            this.rbPostOrden.Margin = new System.Windows.Forms.Padding(2);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(87, 19);
            this.rbPostOrden.TabIndex = 2;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "Post-Orden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            this.rbPostOrden.CheckedChanged += new System.EventHandler(this.rbPostOrden_CheckedChanged);
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(26, 84);
            this.rbPreOrden.Margin = new System.Windows.Forms.Padding(2);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(82, 19);
            this.rbPreOrden.TabIndex = 1;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "Pre-Orden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            this.rbPreOrden.CheckedChanged += new System.EventHandler(this.rbPreOrden_CheckedChanged);
            // 
            // rbInOrden
            // 
            this.rbInOrden.AutoSize = true;
            this.rbInOrden.Location = new System.Drawing.Point(26, 45);
            this.rbInOrden.Margin = new System.Windows.Forms.Padding(2);
            this.rbInOrden.Name = "rbInOrden";
            this.rbInOrden.Size = new System.Drawing.Size(73, 19);
            this.rbInOrden.TabIndex = 0;
            this.rbInOrden.TabStop = true;
            this.rbInOrden.Text = "In-Orden";
            this.rbInOrden.UseVisualStyleBackColor = true;
            this.rbInOrden.CheckedChanged += new System.EventHandler(this.rbInOrden_CheckedChanged);
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(662, 420);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.cmdEquilibrar);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Controls.Add(this.trvArbol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbol_Load);
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvArbol;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Button cmdEquilibrar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.RadioButton rbInOrden;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTramite;
    }
}