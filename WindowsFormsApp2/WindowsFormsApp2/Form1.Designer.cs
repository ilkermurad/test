namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kelimegir = new System.Windows.Forms.TextBox();
            this.listcalısbutton = new System.Windows.Forms.Button();
            this.Aciklama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kelimegir
            // 
            this.kelimegir.Location = new System.Drawing.Point(32, 28);
            this.kelimegir.Name = "kelimegir";
            this.kelimegir.Size = new System.Drawing.Size(267, 22);
            this.kelimegir.TabIndex = 0;
            // 
            // listcalısbutton
            // 
            this.listcalısbutton.Location = new System.Drawing.Point(32, 82);
            this.listcalısbutton.Name = "listcalısbutton";
            this.listcalısbutton.Size = new System.Drawing.Size(75, 23);
            this.listcalısbutton.TabIndex = 1;
            this.listcalısbutton.Text = "button1";
            this.listcalısbutton.UseVisualStyleBackColor = true;
            this.listcalısbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(32, 168);
            this.Aciklama.Multiline = true;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Size = new System.Drawing.Size(267, 233);
            this.Aciklama.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.listcalısbutton);
            this.Controls.Add(this.kelimegir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kelimegir;
        private System.Windows.Forms.Button listcalısbutton;
        public System.Windows.Forms.TextBox Aciklama;
    }
}

