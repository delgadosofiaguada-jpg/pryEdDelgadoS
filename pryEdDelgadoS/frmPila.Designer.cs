namespace pryEdDelgadoS
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.pbPila = new System.Windows.Forms.PictureBox();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbEliminado = new System.Windows.Forms.GroupBox();
            this.lblTram = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPila)).BeginInit();
            this.gbNuevoElemento.SuspendLayout();
            this.gbEliminado.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPila
            // 
            this.pbPila.Image = global::pryEdDelgadoS.Properties.Resources.pilaaaaaaaaa;
            this.pbPila.Location = new System.Drawing.Point(28, 27);
            this.pbPila.Margin = new System.Windows.Forms.Padding(4);
            this.pbPila.Name = "pbPila";
            this.pbPila.Size = new System.Drawing.Size(248, 220);
            this.pbPila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPila.TabIndex = 0;
            this.pbPila.TabStop = false;
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.cmdAgregar);
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.lblTramite);
            this.gbNuevoElemento.Controls.Add(this.lblNombre);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbNuevoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuevoElemento.Location = new System.Drawing.Point(336, 27);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(4);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(4);
            this.gbNuevoElemento.Size = new System.Drawing.Size(273, 242);
            this.gbNuevoElemento.TabIndex = 1;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            this.gbNuevoElemento.Enter += new System.EventHandler(this.gbNuevoElemento_Enter);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Enabled = false;
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(159, 202);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(100, 33);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(101, 139);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(156, 24);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 24);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(101, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(156, 24);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(21, 148);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(62, 18);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 96);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 43);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // gbEliminado
            // 
            this.gbEliminado.Controls.Add(this.lblTram);
            this.gbEliminado.Controls.Add(this.lblNom);
            this.gbEliminado.Controls.Add(this.lblCod);
            this.gbEliminado.Controls.Add(this.cmdEliminar);
            this.gbEliminado.Controls.Add(this.lblTramite2);
            this.gbEliminado.Controls.Add(this.lblNombre2);
            this.gbEliminado.Controls.Add(this.lblCodigo2);
            this.gbEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminado.Location = new System.Drawing.Point(691, 27);
            this.gbEliminado.Margin = new System.Windows.Forms.Padding(4);
            this.gbEliminado.Name = "gbEliminado";
            this.gbEliminado.Padding = new System.Windows.Forms.Padding(4);
            this.gbEliminado.Size = new System.Drawing.Size(267, 242);
            this.gbEliminado.TabIndex = 8;
            this.gbEliminado.TabStop = false;
            this.gbEliminado.Text = " Elemento eliminado";
            // 
            // lblTram
            // 
            this.lblTram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTram.Location = new System.Drawing.Point(99, 144);
            this.lblTram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTram.Name = "lblTram";
            this.lblTram.Size = new System.Drawing.Size(153, 30);
            this.lblTram.TabIndex = 9;
            this.lblTram.Text = "                               ";
            this.lblTram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNom.Location = new System.Drawing.Point(99, 96);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(153, 30);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "                               ";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCod.Location = new System.Drawing.Point(99, 49);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(153, 30);
            this.lblCod.TabIndex = 7;
            this.lblCod.Text = "                               ";
            this.lblCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(136, 202);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(116, 33);
            this.cmdEliminar.TabIndex = 6;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(8, 153);
            this.lblTramite2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(62, 18);
            this.lblTramite2.TabIndex = 2;
            this.lblTramite2.Text = "Trámite:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(8, 102);
            this.lblNombre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(66, 18);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(8, 58);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(60, 18);
            this.lblCodigo2.TabIndex = 0;
            this.lblCodigo2.Text = "Código:";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lstPila);
            this.gbListado.Controls.Add(this.dgvGrilla);
            this.gbListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListado.Location = new System.Drawing.Point(28, 277);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(4);
            this.gbListado.Size = new System.Drawing.Size(930, 309);
            this.gbListado.TabIndex = 9;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 18;
            this.lstPila.Location = new System.Drawing.Point(8, 38);
            this.lstPila.Margin = new System.Windows.Forms.Padding(4);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(279, 256);
            this.lstPila.TabIndex = 2;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clNombre,
            this.clTramite});
            this.dgvGrilla.Location = new System.Drawing.Point(343, 38);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(572, 256);
            this.dgvGrilla.TabIndex = 1;
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.MinimumWidth = 6;
            this.clCodigo.Name = "clCodigo";
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.MinimumWidth = 6;
            this.clNombre.Name = "clNombre";
            this.clNombre.Width = 160;
            // 
            // clTramite
            // 
            this.clTramite.HeaderText = "Trámite";
            this.clTramite.MinimumWidth = 6;
            this.clTramite.Name = "clTramite";
            this.clTramite.Width = 110;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(971, 599);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEliminado);
            this.Controls.Add(this.gbNuevoElemento);
            this.Controls.Add(this.pbPila);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPila)).EndInit();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbEliminado.ResumeLayout(false);
            this.gbEliminado.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPila;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.GroupBox gbEliminado;
        private System.Windows.Forms.Label lblTram;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTramite;
    }
}