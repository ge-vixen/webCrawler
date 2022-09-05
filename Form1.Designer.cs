namespace WebCrawlerDesktop
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
            this.labelNomeText = new System.Windows.Forms.Label();
            this.labelIdText = new System.Windows.Forms.Label();
            this.labelPrecoText = new System.Windows.Forms.Label();
            this.labelSaldoText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeText
            // 
            this.labelNomeText.AutoSize = true;
            this.labelNomeText.Location = new System.Drawing.Point(72, 19);
            this.labelNomeText.Name = "labelNomeText";
            this.labelNomeText.Size = new System.Drawing.Size(78, 13);
            this.labelNomeText.TabIndex = 4;
            this.labelNomeText.Text = "labelNomeText";
            // 
            // labelIdText
            // 
            this.labelIdText.AutoSize = true;
            this.labelIdText.Location = new System.Drawing.Point(72, 43);
            this.labelIdText.Name = "labelIdText";
            this.labelIdText.Size = new System.Drawing.Size(59, 13);
            this.labelIdText.TabIndex = 5;
            this.labelIdText.Text = "labelIdText";
            // 
            // labelPrecoText
            // 
            this.labelPrecoText.AutoSize = true;
            this.labelPrecoText.Location = new System.Drawing.Point(72, 66);
            this.labelPrecoText.Name = "labelPrecoText";
            this.labelPrecoText.Size = new System.Drawing.Size(78, 13);
            this.labelPrecoText.TabIndex = 6;
            this.labelPrecoText.Text = "labelPrecoText";
            // 
            // labelSaldoText
            // 
            this.labelSaldoText.AutoSize = true;
            this.labelSaldoText.Location = new System.Drawing.Point(72, 89);
            this.labelSaldoText.Name = "labelSaldoText";
            this.labelSaldoText.Size = new System.Drawing.Size(77, 13);
            this.labelSaldoText.TabIndex = 7;
            this.labelSaldoText.Text = "labelSaldoText";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 231);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSaldoText);
            this.Controls.Add(this.labelPrecoText);
            this.Controls.Add(this.labelIdText);
            this.Controls.Add(this.labelNomeText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNomeText;
        private System.Windows.Forms.Label labelIdText;
        private System.Windows.Forms.Label labelPrecoText;
        private System.Windows.Forms.Label labelSaldoText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

