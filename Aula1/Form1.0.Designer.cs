namespace Aula1
{
    partial class frmOla
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOla
            // 
            this.btnOla.Location = new System.Drawing.Point(270, 137);
            this.btnOla.Name = "btnOla";
            this.btnOla.Size = new System.Drawing.Size(142, 25);
            this.btnOla.TabIndex = 0;
            this.btnOla.Text = "Olá ";
            this.btnOla.UseVisualStyleBackColor = true;
            this.btnOla.Click += new System.EventHandler(this.btnOla_Click);
            // 
            // frmOla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 248);
            this.Controls.Add(this.btnOla);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "frmOla";
            this.Text = "Formulário Ola ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOla;
    }
}

