
namespace DenemeGit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_1 = new System.Windows.Forms.TextBox();
            this.tbx_2 = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Not";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Not";
            // 
            // tbx_1
            // 
            this.tbx_1.Location = new System.Drawing.Point(293, 68);
            this.tbx_1.Name = "tbx_1";
            this.tbx_1.Size = new System.Drawing.Size(100, 26);
            this.tbx_1.TabIndex = 2;
            // 
            // tbx_2
            // 
            this.tbx_2.Location = new System.Drawing.Point(293, 118);
            this.tbx_2.Name = "tbx_2";
            this.tbx_2.Size = new System.Drawing.Size(100, 26);
            this.tbx_2.TabIndex = 3;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(293, 184);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(100, 33);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.tbx_2);
            this.Controls.Add(this.tbx_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_1;
        private System.Windows.Forms.TextBox tbx_2;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label3;
    }
}

