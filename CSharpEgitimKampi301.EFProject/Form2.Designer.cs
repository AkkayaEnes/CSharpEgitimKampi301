namespace CSharpEgitimKampi301.EFProject
{
    partial class Form2
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDayNight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nuCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbGuide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGuncelle.Location = new System.Drawing.Point(77, 345);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(181, 38);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Yellow;
            this.btnSil.Location = new System.Drawing.Point(77, 301);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(181, 38);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Yellow;
            this.btnEkle.Location = new System.Drawing.Point(77, 257);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(181, 38);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(94, 67);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(164, 20);
            this.txtCountry.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ülke";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(94, 41);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(164, 20);
            this.txtCity.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şehir:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1023, 415);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Yellow;
            this.btnListele.Location = new System.Drawing.Point(77, 213);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(181, 38);
            this.btnListele.TabIndex = 13;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(94, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 20);
            this.txtId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lokasyon Id:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(94, 119);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 20);
            this.txtPrice.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Rehber:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kapasite:";
            // 
            // txtDayNight
            // 
            this.txtDayNight.Location = new System.Drawing.Point(94, 173);
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(164, 20);
            this.txtDayNight.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Gün Gece";
            // 
            // nuCapacity
            // 
            this.nuCapacity.Location = new System.Drawing.Point(94, 93);
            this.nuCapacity.Name = "nuCapacity";
            this.nuCapacity.Size = new System.Drawing.Size(164, 20);
            this.nuCapacity.TabIndex = 30;
            // 
            // cmbGuide
            // 
            this.cmbGuide.FormattingEnabled = true;
            this.cmbGuide.Location = new System.Drawing.Point(94, 146);
            this.cmbGuide.Name = "cmbGuide";
            this.cmbGuide.Size = new System.Drawing.Size(164, 21);
            this.cmbGuide.TabIndex = 31;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 439);
            this.Controls.Add(this.cmbGuide);
            this.Controls.Add(this.nuCapacity);
            this.Controls.Add(this.txtDayNight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDayNight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuCapacity;
        private System.Windows.Forms.ComboBox cmbGuide;
    }
}