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
            this.tvArbol = new System.Windows.Forms.TreeView();
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
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(12, 12);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(264, 236);
            this.tvArbol.TabIndex = 0;
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(346, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(237, 235);
            this.gbNuevoElemento.TabIndex = 1;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(21, 178);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(210, 40);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(98, 126);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(133, 24);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 24);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(98, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(133, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(18, 132);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(62, 18);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(18, 43);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(60, 18);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.cbCodigo);
            this.gbEliminar.Controls.Add(this.cmdEliminar);
            this.gbEliminar.Controls.Add(this.label3);
            this.gbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminar.Location = new System.Drawing.Point(628, 13);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(237, 151);
            this.gbEliminar.TabIndex = 7;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Elemento a Eliminar";
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(84, 39);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(147, 26);
            this.cbCodigo.TabIndex = 7;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(21, 88);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(210, 40);
            this.cmdEliminar.TabIndex = 6;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // cmdEquilibrar
            // 
            this.cmdEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEquilibrar.Location = new System.Drawing.Point(639, 191);
            this.cmdEquilibrar.Name = "cmdEquilibrar";
            this.cmdEquilibrar.Size = new System.Drawing.Size(210, 40);
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
            this.gbListado.Location = new System.Drawing.Point(12, 283);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(859, 220);
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
            this.dgvListado.Location = new System.Drawing.Point(283, 23);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.Size = new System.Drawing.Size(570, 171);
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
            this.rbPostOrden.Location = new System.Drawing.Point(35, 148);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(106, 22);
            this.rbPostOrden.TabIndex = 2;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "Post-Orden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(35, 103);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(98, 22);
            this.rbPreOrden.TabIndex = 1;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "Pre-Orden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            // 
            // rbInOrden
            // 
            this.rbInOrden.AutoSize = true;
            this.rbInOrden.Location = new System.Drawing.Point(35, 55);
            this.rbInOrden.Name = "rbInOrden";
            this.rbInOrden.Size = new System.Drawing.Size(86, 22);
            this.rbInOrden.TabIndex = 0;
            this.rbInOrden.TabStop = true;
            this.rbInOrden.Text = "In-Orden";
            this.rbInOrden.UseVisualStyleBackColor = true;
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(883, 517);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.cmdEquilibrar);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Controls.Add(this.tvArbol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private System.Windows.Forms.TreeView tvArbol;
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