
namespace DövizKurları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldolaralıs = new System.Windows.Forms.Label();
            this.lbldolarsatıs = new System.Windows.Forms.Label();
            this.lbleuroalıs = new System.Windows.Forms.Label();
            this.lbleurosatıs = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtkur = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.txtkalan = new System.Windows.Forms.TextBox();
            this.btndolaral = new System.Windows.Forms.Button();
            this.btndolarsat = new System.Windows.Forms.Button();
            this.btneuroal = new System.Windows.Forms.Button();
            this.btneurosat = new System.Windows.Forms.Button();
            this.btnsatıs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar Satış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Euro Alış:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Euro Satış:";
            // 
            // lbldolaralıs
            // 
            this.lbldolaralıs.AutoSize = true;
            this.lbldolaralıs.BackColor = System.Drawing.Color.Transparent;
            this.lbldolaralıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldolaralıs.ForeColor = System.Drawing.Color.White;
            this.lbldolaralıs.Location = new System.Drawing.Point(119, 35);
            this.lbldolaralıs.Name = "lbldolaralıs";
            this.lbldolaralıs.Size = new System.Drawing.Size(34, 25);
            this.lbldolaralıs.TabIndex = 4;
            this.lbldolaralıs.Text = "00";
            // 
            // lbldolarsatıs
            // 
            this.lbldolarsatıs.AutoSize = true;
            this.lbldolarsatıs.BackColor = System.Drawing.Color.Transparent;
            this.lbldolarsatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldolarsatıs.ForeColor = System.Drawing.Color.White;
            this.lbldolarsatıs.Location = new System.Drawing.Point(119, 77);
            this.lbldolarsatıs.Name = "lbldolarsatıs";
            this.lbldolarsatıs.Size = new System.Drawing.Size(34, 25);
            this.lbldolarsatıs.TabIndex = 5;
            this.lbldolarsatıs.Text = "00";
            this.lbldolarsatıs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbleuroalıs
            // 
            this.lbleuroalıs.AutoSize = true;
            this.lbleuroalıs.BackColor = System.Drawing.Color.Transparent;
            this.lbleuroalıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleuroalıs.ForeColor = System.Drawing.Color.White;
            this.lbleuroalıs.Location = new System.Drawing.Point(119, 149);
            this.lbleuroalıs.Name = "lbleuroalıs";
            this.lbleuroalıs.Size = new System.Drawing.Size(34, 25);
            this.lbleuroalıs.TabIndex = 6;
            this.lbleuroalıs.Text = "00";
            // 
            // lbleurosatıs
            // 
            this.lbleurosatıs.AutoSize = true;
            this.lbleurosatıs.BackColor = System.Drawing.Color.Transparent;
            this.lbleurosatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleurosatıs.ForeColor = System.Drawing.Color.White;
            this.lbleurosatıs.Location = new System.Drawing.Point(119, 196);
            this.lbleurosatıs.Name = "lbleurosatıs";
            this.lbleurosatıs.Size = new System.Drawing.Size(34, 25);
            this.lbleurosatıs.TabIndex = 7;
            this.lbleurosatıs.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnsatıs);
            this.groupBox1.Controls.Add(this.txtkalan);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.txtmiktar);
            this.groupBox1.Controls.Add(this.txtkur);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(266, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tutar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(49, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kur:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(27, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Miktar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(29, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Kalan:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtkur
            // 
            this.txtkur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkur.Location = new System.Drawing.Point(104, 22);
            this.txtkur.Name = "txtkur";
            this.txtkur.Size = new System.Drawing.Size(183, 28);
            this.txtkur.TabIndex = 12;
            this.txtkur.TextChanged += new System.EventHandler(this.txtkur_TextChanged);
            // 
            // txtmiktar
            // 
            this.txtmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmiktar.Location = new System.Drawing.Point(104, 58);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(183, 28);
            this.txtmiktar.TabIndex = 13;
            // 
            // txttutar
            // 
            this.txttutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttutar.Location = new System.Drawing.Point(104, 97);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(183, 28);
            this.txttutar.TabIndex = 14;
            // 
            // txtkalan
            // 
            this.txtkalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkalan.Location = new System.Drawing.Point(104, 136);
            this.txtkalan.Name = "txtkalan";
            this.txtkalan.Size = new System.Drawing.Size(183, 28);
            this.txtkalan.TabIndex = 15;
            // 
            // btndolaral
            // 
            this.btndolaral.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndolaral.Location = new System.Drawing.Point(210, 37);
            this.btndolaral.Name = "btndolaral";
            this.btndolaral.Size = new System.Drawing.Size(37, 24);
            this.btndolaral.TabIndex = 9;
            this.btndolaral.Text = "...";
            this.btndolaral.UseVisualStyleBackColor = true;
            this.btndolaral.Click += new System.EventHandler(this.btndolaral_Click);
            // 
            // btndolarsat
            // 
            this.btndolarsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndolarsat.Location = new System.Drawing.Point(210, 78);
            this.btndolarsat.Name = "btndolarsat";
            this.btndolarsat.Size = new System.Drawing.Size(37, 24);
            this.btndolarsat.TabIndex = 10;
            this.btndolarsat.Text = "...";
            this.btndolarsat.UseVisualStyleBackColor = true;
            this.btndolarsat.Click += new System.EventHandler(this.btndolarsat_Click);
            // 
            // btneuroal
            // 
            this.btneuroal.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneuroal.Location = new System.Drawing.Point(210, 150);
            this.btneuroal.Name = "btneuroal";
            this.btneuroal.Size = new System.Drawing.Size(37, 24);
            this.btneuroal.TabIndex = 11;
            this.btneuroal.Text = "...";
            this.btneuroal.UseVisualStyleBackColor = true;
            this.btneuroal.Click += new System.EventHandler(this.btneuroal_Click);
            // 
            // btneurosat
            // 
            this.btneurosat.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneurosat.Location = new System.Drawing.Point(210, 197);
            this.btneurosat.Name = "btneurosat";
            this.btneurosat.Size = new System.Drawing.Size(37, 24);
            this.btneurosat.TabIndex = 12;
            this.btneurosat.Text = "...";
            this.btneurosat.UseVisualStyleBackColor = true;
            this.btneurosat.Click += new System.EventHandler(this.btneurosat_Click);
            // 
            // btnsatıs
            // 
            this.btnsatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsatıs.Location = new System.Drawing.Point(13, 170);
            this.btnsatıs.Name = "btnsatıs";
            this.btnsatıs.Size = new System.Drawing.Size(154, 44);
            this.btnsatıs.TabIndex = 16;
            this.btnsatıs.Text = "İşlem Yap";
            this.btnsatıs.UseVisualStyleBackColor = true;
            this.btnsatıs.Click += new System.EventHandler(this.btnsatıs_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(194, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "İşlem Yap 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tarih:";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.BackColor = System.Drawing.Color.Transparent;
            this.lbltarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltarih.ForeColor = System.Drawing.Color.White;
            this.lbltarih.Location = new System.Drawing.Point(81, 284);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(34, 25);
            this.lbltarih.TabIndex = 15;
            this.lbltarih.Text = "00";
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.BackColor = System.Drawing.Color.Transparent;
            this.lblsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsaat.ForeColor = System.Drawing.Color.White;
            this.lblsaat.Location = new System.Drawing.Point(81, 330);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(34, 25);
            this.lblsaat.TabIndex = 16;
            this.lblsaat.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(709, 442);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btneurosat);
            this.Controls.Add(this.btneuroal);
            this.Controls.Add(this.btndolarsat);
            this.Controls.Add(this.btndolaral);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbleurosatıs);
            this.Controls.Add(this.lbleuroalıs);
            this.Controls.Add(this.lbldolarsatıs);
            this.Controls.Add(this.lbldolaralıs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cihan Excange";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldolaralıs;
        private System.Windows.Forms.Label lbldolarsatıs;
        private System.Windows.Forms.Label lbleuroalıs;
        private System.Windows.Forms.Label lbleurosatıs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsatıs;
        private System.Windows.Forms.TextBox txtkalan;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.TextBox txtkur;
        private System.Windows.Forms.Button btndolaral;
        private System.Windows.Forms.Button btndolarsat;
        private System.Windows.Forms.Button btneuroal;
        private System.Windows.Forms.Button btneurosat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Timer timer1;
    }
}

