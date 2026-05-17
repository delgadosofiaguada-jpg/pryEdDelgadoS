namespace pryEdDelgadoS
{
    partial class frmBdOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBdOperaciones));
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.gbProyeccion = new System.Windows.Forms.GroupBox();
            this.cmdProySimple = new System.Windows.Forms.Button();
            this.cmdProyMulti = new System.Windows.Forms.Button();
            this.cmdJuntar = new System.Windows.Forms.Button();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.cmdSelecConv = new System.Windows.Forms.Button();
            this.cmdSelecMulti = new System.Windows.Forms.Button();
            this.cmdSelecSimple = new System.Windows.Forms.Button();
            this.gbAlgebraicas = new System.Windows.Forms.GroupBox();
            this.cmdDiferencia = new System.Windows.Forms.Button();
            this.cmdInterseccion = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.gbProyeccion.SuspendLayout();
            this.gbSeleccion.SuspendLayout();
            this.gbAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.RowHeadersWidth = 51;
            this.dgvBaseDatos.RowTemplate.Height = 24;
            this.dgvBaseDatos.Size = new System.Drawing.Size(956, 334);
            this.dgvBaseDatos.TabIndex = 0;
            // 
            // gbProyeccion
            // 
            this.gbProyeccion.Controls.Add(this.cmdJuntar);
            this.gbProyeccion.Controls.Add(this.cmdProyMulti);
            this.gbProyeccion.Controls.Add(this.cmdProySimple);
            this.gbProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProyeccion.Location = new System.Drawing.Point(12, 367);
            this.gbProyeccion.Name = "gbProyeccion";
            this.gbProyeccion.Size = new System.Drawing.Size(313, 169);
            this.gbProyeccion.TabIndex = 1;
            this.gbProyeccion.TabStop = false;
            this.gbProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // cmdProySimple
            // 
            this.cmdProySimple.Location = new System.Drawing.Point(15, 40);
            this.cmdProySimple.Name = "cmdProySimple";
            this.cmdProySimple.Size = new System.Drawing.Size(250, 28);
            this.cmdProySimple.TabIndex = 0;
            this.cmdProySimple.Text = "Proyección simple";
            this.cmdProySimple.UseVisualStyleBackColor = true;
            // 
            // cmdProyMulti
            // 
            this.cmdProyMulti.Location = new System.Drawing.Point(15, 85);
            this.cmdProyMulti.Name = "cmdProyMulti";
            this.cmdProyMulti.Size = new System.Drawing.Size(250, 28);
            this.cmdProyMulti.TabIndex = 1;
            this.cmdProyMulti.Text = "Proyección multiatributo";
            this.cmdProyMulti.UseVisualStyleBackColor = true;
            // 
            // cmdJuntar
            // 
            this.cmdJuntar.Location = new System.Drawing.Point(15, 135);
            this.cmdJuntar.Name = "cmdJuntar";
            this.cmdJuntar.Size = new System.Drawing.Size(250, 28);
            this.cmdJuntar.TabIndex = 2;
            this.cmdJuntar.Text = "Juntar";
            this.cmdJuntar.UseVisualStyleBackColor = true;
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.cmdSelecConv);
            this.gbSeleccion.Controls.Add(this.cmdSelecMulti);
            this.gbSeleccion.Controls.Add(this.cmdSelecSimple);
            this.gbSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccion.Location = new System.Drawing.Point(354, 367);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Size = new System.Drawing.Size(303, 169);
            this.gbSeleccion.TabIndex = 3;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // cmdSelecConv
            // 
            this.cmdSelecConv.Location = new System.Drawing.Point(15, 135);
            this.cmdSelecConv.Name = "cmdSelecConv";
            this.cmdSelecConv.Size = new System.Drawing.Size(250, 28);
            this.cmdSelecConv.TabIndex = 2;
            this.cmdSelecConv.Text = "Selección por convolución";
            this.cmdSelecConv.UseVisualStyleBackColor = true;
            // 
            // cmdSelecMulti
            // 
            this.cmdSelecMulti.Location = new System.Drawing.Point(15, 85);
            this.cmdSelecMulti.Name = "cmdSelecMulti";
            this.cmdSelecMulti.Size = new System.Drawing.Size(250, 28);
            this.cmdSelecMulti.TabIndex = 1;
            this.cmdSelecMulti.Text = "Selección multiatributo";
            this.cmdSelecMulti.UseVisualStyleBackColor = true;
            // 
            // cmdSelecSimple
            // 
            this.cmdSelecSimple.Location = new System.Drawing.Point(15, 40);
            this.cmdSelecSimple.Name = "cmdSelecSimple";
            this.cmdSelecSimple.Size = new System.Drawing.Size(250, 28);
            this.cmdSelecSimple.TabIndex = 0;
            this.cmdSelecSimple.Text = "Selección simple";
            this.cmdSelecSimple.UseVisualStyleBackColor = true;
            // 
            // gbAlgebraicas
            // 
            this.gbAlgebraicas.Controls.Add(this.cmdDiferencia);
            this.gbAlgebraicas.Controls.Add(this.cmdInterseccion);
            this.gbAlgebraicas.Controls.Add(this.cmdUnion);
            this.gbAlgebraicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlgebraicas.Location = new System.Drawing.Point(684, 367);
            this.gbAlgebraicas.Name = "gbAlgebraicas";
            this.gbAlgebraicas.Size = new System.Drawing.Size(284, 169);
            this.gbAlgebraicas.TabIndex = 4;
            this.gbAlgebraicas.TabStop = false;
            this.gbAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // cmdDiferencia
            // 
            this.cmdDiferencia.Location = new System.Drawing.Point(15, 135);
            this.cmdDiferencia.Name = "cmdDiferencia";
            this.cmdDiferencia.Size = new System.Drawing.Size(250, 28);
            this.cmdDiferencia.TabIndex = 2;
            this.cmdDiferencia.Text = "Diferencia";
            this.cmdDiferencia.UseVisualStyleBackColor = true;
            // 
            // cmdInterseccion
            // 
            this.cmdInterseccion.Location = new System.Drawing.Point(15, 85);
            this.cmdInterseccion.Name = "cmdInterseccion";
            this.cmdInterseccion.Size = new System.Drawing.Size(250, 28);
            this.cmdInterseccion.TabIndex = 1;
            this.cmdInterseccion.Text = "Intersección";
            this.cmdInterseccion.UseVisualStyleBackColor = true;
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(15, 40);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(250, 28);
            this.cmdUnion.TabIndex = 0;
            this.cmdUnion.Text = "Unión";
            this.cmdUnion.UseVisualStyleBackColor = true;
            // 
            // frmBdOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(980, 548);
            this.Controls.Add(this.gbAlgebraicas);
            this.Controls.Add(this.gbSeleccion);
            this.Controls.Add(this.gbProyeccion);
            this.Controls.Add(this.dgvBaseDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBdOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.gbProyeccion.ResumeLayout(false);
            this.gbSeleccion.ResumeLayout(false);
            this.gbAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.GroupBox gbProyeccion;
        private System.Windows.Forms.Button cmdJuntar;
        private System.Windows.Forms.Button cmdProyMulti;
        private System.Windows.Forms.Button cmdProySimple;
        private System.Windows.Forms.GroupBox gbSeleccion;
        private System.Windows.Forms.Button cmdSelecConv;
        private System.Windows.Forms.Button cmdSelecMulti;
        private System.Windows.Forms.Button cmdSelecSimple;
        private System.Windows.Forms.GroupBox gbAlgebraicas;
        private System.Windows.Forms.Button cmdDiferencia;
        private System.Windows.Forms.Button cmdInterseccion;
        private System.Windows.Forms.Button cmdUnion;
    }
}