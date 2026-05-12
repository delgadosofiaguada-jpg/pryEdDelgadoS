namespace pryEdDelgadoS
{
    partial class frmAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            this.lblTituloAlumnos = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.mtbCodigoAlumno = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloAlumnos
            // 
            this.lblTituloAlumnos.AutoSize = true;
            this.lblTituloAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlumnos.Location = new System.Drawing.Point(16, 25);
            this.lblTituloAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloAlumnos.Name = "lblTituloAlumnos";
            this.lblTituloAlumnos.Size = new System.Drawing.Size(158, 20);
            this.lblTituloAlumnos.TabIndex = 0;
            this.lblTituloAlumnos.Text = "Ingrese el alumno";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(20, 90);
            this.lblCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(60, 18);
            this.lblCodigoAlumno.TabIndex = 1;
            this.lblCodigoAlumno.Text = "Código:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(20, 206);
            this.lblCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(62, 18);
            this.lblCarrera.TabIndex = 2;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(20, 148);
            this.lblNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(66, 18);
            this.lblNombreAlumno.TabIndex = 3;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // mtbCodigoAlumno
            // 
            this.mtbCodigoAlumno.Location = new System.Drawing.Point(233, 86);
            this.mtbCodigoAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCodigoAlumno.Mask = "999999";
            this.mtbCodigoAlumno.Name = "mtbCodigoAlumno";
            this.mtbCodigoAlumno.Size = new System.Drawing.Size(277, 22);
            this.mtbCodigoAlumno.TabIndex = 4;
            this.mtbCodigoAlumno.ValidatingType = typeof(int);
            this.mtbCodigoAlumno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCodigoAlumno_MaskInputRejected);
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(233, 148);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(277, 22);
            this.txtNombreAlumno.TabIndex = 5;
            this.txtNombreAlumno.TextChanged += new System.EventHandler(this.txtNombreAlumno_TextChanged);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(233, 208);
            this.cmbCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(277, 24);
            this.cmbCarrera.TabIndex = 6;
            this.cmbCarrera.SelectedIndexChanged += new System.EventHandler(this.cmbCarrera_SelectedIndexChanged);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.White;
            this.cmdGrabar.Enabled = false;
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(375, 254);
            this.cmdGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(136, 28);
            this.cmdGrabar.TabIndex = 7;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigo,
            this.ClNombre,
            this.ClCarrera});
            this.dgvAlumnos.Location = new System.Drawing.Point(16, 300);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.Size = new System.Drawing.Size(494, 185);
            this.dgvAlumnos.TabIndex = 8;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.Color.White;
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(231, 254);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(136, 28);
            this.cmdLimpiar.TabIndex = 9;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // ClCodigo
            // 
            this.ClCodigo.HeaderText = "Código";
            this.ClCodigo.MinimumWidth = 6;
            this.ClCodigo.Name = "ClCodigo";
            this.ClCodigo.Width = 80;
            // 
            // ClNombre
            // 
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.MinimumWidth = 6;
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.Width = 110;
            // 
            // ClCarrera
            // 
            this.ClCarrera.HeaderText = "Carrera";
            this.ClCarrera.MinimumWidth = 6;
            this.ClCarrera.Name = "ClCarrera";
            this.ClCarrera.Width = 125;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(523, 500);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.mtbCodigoAlumno);
            this.Controls.Add(this.lblNombreAlumno);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblCodigoAlumno);
            this.Controls.Add(this.lblTituloAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Alumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAlumnos;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.MaskedTextBox mtbCodigoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCarrera;
    }
}