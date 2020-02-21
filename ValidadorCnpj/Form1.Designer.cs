namespace ValidadorCnpj
{
    partial class Form1
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
            this.mtbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnValidaCnpj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbCnpj
            // 
            this.mtbCnpj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mtbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCnpj.Location = new System.Drawing.Point(108, 80);
            this.mtbCnpj.Mask = "00.000.000/0000-00";
            this.mtbCnpj.Name = "mtbCnpj";
            this.mtbCnpj.Size = new System.Drawing.Size(170, 29);
            this.mtbCnpj.TabIndex = 0;
            // 
            // btnValidaCnpj
            // 
            this.btnValidaCnpj.BackColor = System.Drawing.Color.OrangeRed;
            this.btnValidaCnpj.Location = new System.Drawing.Point(108, 141);
            this.btnValidaCnpj.Name = "btnValidaCnpj";
            this.btnValidaCnpj.Size = new System.Drawing.Size(170, 29);
            this.btnValidaCnpj.TabIndex = 1;
            this.btnValidaCnpj.Text = "VALIDAR";
            this.btnValidaCnpj.UseVisualStyleBackColor = false;
            this.btnValidaCnpj.Click += new System.EventHandler(this.btnValidaCnpj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 265);
            this.Controls.Add(this.btnValidaCnpj);
            this.Controls.Add(this.mtbCnpj);
            this.Name = "Form1";
            this.Text = "CNPJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCnpj;
        private System.Windows.Forms.Button btnValidaCnpj;
    }
}

