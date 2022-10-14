
namespace Proyecto
{
    partial class FormularioFamilia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFamilia = new System.Windows.Forms.DataGridView();
            this.btbCompletar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFamilia
            // 
            this.dgvFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilia.Location = new System.Drawing.Point(23, 65);
            this.dgvFamilia.Name = "dgvFamilia";
            this.dgvFamilia.Size = new System.Drawing.Size(584, 251);
            this.dgvFamilia.TabIndex = 0;
            // 
            // btbCompletar
            // 
            this.btbCompletar.Location = new System.Drawing.Point(653, 358);
            this.btbCompletar.Name = "btbCompletar";
            this.btbCompletar.Size = new System.Drawing.Size(75, 23);
            this.btbCompletar.TabIndex = 1;
            this.btbCompletar.Text = "Completar";
            this.btbCompletar.UseVisualStyleBackColor = true;
            this.btbCompletar.Click += new System.EventHandler(this.btbCompletar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(653, 83);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // FormularioFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btbCompletar);
            this.Controls.Add(this.dgvFamilia);
            this.Name = "FormularioFamilia";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFamilia;
        private System.Windows.Forms.Button btbCompletar;
        private System.Windows.Forms.Button btnAgregar;
    }
}

