
namespace IngilizceOgrenmeUygulamasi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIngilizce = new System.Windows.Forms.TextBox();
            this.TxtTurkce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblKelime = new System.Windows.Forms.Label();
            this.LblCevap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(29, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe : ";
            // 
            // TxtIngilizce
            // 
            this.TxtIngilizce.Location = new System.Drawing.Point(167, 41);
            this.TxtIngilizce.Name = "TxtIngilizce";
            this.TxtIngilizce.Size = new System.Drawing.Size(259, 30);
            this.TxtIngilizce.TabIndex = 10;
            // 
            // TxtTurkce
            // 
            this.TxtTurkce.Location = new System.Drawing.Point(167, 143);
            this.TxtTurkce.Name = "TxtTurkce";
            this.TxtTurkce.Size = new System.Drawing.Size(259, 30);
            this.TxtTurkce.TabIndex = 1;
            this.TxtTurkce.TextChanged += new System.EventHandler(this.TxtTurkce_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre  : ";
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.BackColor = System.Drawing.Color.Transparent;
            this.LblSure.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSure.ForeColor = System.Drawing.Color.Black;
            this.LblSure.Location = new System.Drawing.Point(122, 234);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(184, 24);
            this.LblSure.TabIndex = 5;
            this.LblSure.Text = "1.5 dakikanız var";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bilinen Kelime Sayısı : ";
            // 
            // LblKelime
            // 
            this.LblKelime.AutoSize = true;
            this.LblKelime.BackColor = System.Drawing.Color.Transparent;
            this.LblKelime.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKelime.ForeColor = System.Drawing.Color.Black;
            this.LblKelime.Location = new System.Drawing.Point(297, 276);
            this.LblKelime.Name = "LblKelime";
            this.LblKelime.Size = new System.Drawing.Size(24, 24);
            this.LblKelime.TabIndex = 7;
            this.LblKelime.Text = "0";
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.BackColor = System.Drawing.Color.Transparent;
            this.LblCevap.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCevap.ForeColor = System.Drawing.Color.Black;
            this.LblCevap.Location = new System.Drawing.Point(250, 317);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(71, 24);
            this.LblCevap.TabIndex = 8;
            this.LblCevap.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Türkçe Karşılığı :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 454);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.LblKelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTurkce);
            this.Controls.Add(this.TxtIngilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIngilizce;
        private System.Windows.Forms.TextBox TxtTurkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblKelime;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

