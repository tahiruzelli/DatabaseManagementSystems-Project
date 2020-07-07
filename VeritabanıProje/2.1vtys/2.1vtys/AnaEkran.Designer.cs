namespace _2._1vtys
{
    partial class AnaEkran
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblKrediYazi = new System.Windows.Forms.Label();
            this.DerleriEklebtn = new System.Windows.Forms.Button();
            this.dersler = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secilendersler = new System.Windows.Forms.ListBox();
            this.aktarbtn = new System.Windows.Forms.Button();
            this.onaybtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblToplamKredi = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOgrenciSayi = new System.Windows.Forms.Label();
            this.lblDanisman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci İsmi:";
            // 
            // lblKrediYazi
            // 
            this.lblKrediYazi.AutoSize = true;
            this.lblKrediYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKrediYazi.Location = new System.Drawing.Point(7, 272);
            this.lblKrediYazi.Name = "lblKrediYazi";
            this.lblKrediYazi.Size = new System.Drawing.Size(158, 25);
            this.lblKrediYazi.TabIndex = 1;
            this.lblKrediYazi.Text = "Kredi Hakkınız:";
            this.lblKrediYazi.Click += new System.EventHandler(this.label2_Click);
            // 
            // DerleriEklebtn
            // 
            this.DerleriEklebtn.Location = new System.Drawing.Point(305, 150);
            this.DerleriEklebtn.Name = "DerleriEklebtn";
            this.DerleriEklebtn.Size = new System.Drawing.Size(93, 23);
            this.DerleriEklebtn.TabIndex = 2;
            this.DerleriEklebtn.Text = "Derleri Ekle";
            this.DerleriEklebtn.UseVisualStyleBackColor = true;
            this.DerleriEklebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dersler
            // 
            this.dersler.FormattingEnabled = true;
            this.dersler.Location = new System.Drawing.Point(193, 50);
            this.dersler.Name = "dersler";
            this.dersler.Size = new System.Drawing.Size(321, 94);
            this.dersler.TabIndex = 3;
            this.dersler.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.dersler_ItemCheck);
            this.dersler.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(245, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ders İsmi-Ders Kredisi";
            // 
            // secilendersler
            // 
            this.secilendersler.FormattingEnabled = true;
            this.secilendersler.ItemHeight = 17;
            this.secilendersler.Location = new System.Drawing.Point(528, 50);
            this.secilendersler.Name = "secilendersler";
            this.secilendersler.Size = new System.Drawing.Size(320, 89);
            this.secilendersler.TabIndex = 6;
            // 
            // aktarbtn
            // 
            this.aktarbtn.Location = new System.Drawing.Point(305, 179);
            this.aktarbtn.Name = "aktarbtn";
            this.aktarbtn.Size = new System.Drawing.Size(93, 23);
            this.aktarbtn.TabIndex = 7;
            this.aktarbtn.Text = "Dersleri Seç";
            this.aktarbtn.UseVisualStyleBackColor = true;
            this.aktarbtn.Click += new System.EventHandler(this.aktarbtn_Click);
            // 
            // onaybtn
            // 
            this.onaybtn.Location = new System.Drawing.Point(642, 159);
            this.onaybtn.Name = "onaybtn";
            this.onaybtn.Size = new System.Drawing.Size(93, 23);
            this.onaybtn.TabIndex = 8;
            this.onaybtn.Text = "Onayla";
            this.onaybtn.UseVisualStyleBackColor = true;
            this.onaybtn.Click += new System.EventHandler(this.onaybtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(577, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ders İsmi-Ders Kredisi";
            // 
            // lblIsim
            // 
            this.lblIsim.Location = new System.Drawing.Point(16, 85);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(126, 26);
            this.lblIsim.TabIndex = 15;
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(19, 113);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(135, 31);
            this.lblNo.TabIndex = 17;
            // 
            // lblToplamKredi
            // 
            this.lblToplamKredi.AutoSize = true;
            this.lblToplamKredi.Location = new System.Drawing.Point(165, 280);
            this.lblToplamKredi.Name = "lblToplamKredi";
            this.lblToplamKredi.Size = new System.Drawing.Size(0, 17);
            this.lblToplamKredi.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Başarı Durumu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bölümdeki Öğrenci Sayısı :";
            // 
            // lblOgrenciSayi
            // 
            this.lblOgrenciSayi.AutoSize = true;
            this.lblOgrenciSayi.Location = new System.Drawing.Point(217, 236);
            this.lblOgrenciSayi.Name = "lblOgrenciSayi";
            this.lblOgrenciSayi.Size = new System.Drawing.Size(0, 17);
            this.lblOgrenciSayi.TabIndex = 23;
            // 
            // lblDanisman
            // 
            this.lblDanisman.Location = new System.Drawing.Point(9, 150);
            this.lblDanisman.Name = "lblDanisman";
            this.lblDanisman.Size = new System.Drawing.Size(135, 31);
            this.lblDanisman.TabIndex = 24;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 344);
            this.Controls.Add(this.lblDanisman);
            this.Controls.Add(this.lblOgrenciSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblToplamKredi);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.onaybtn);
            this.Controls.Add(this.aktarbtn);
            this.Controls.Add(this.secilendersler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dersler);
            this.Controls.Add(this.DerleriEklebtn);
            this.Controls.Add(this.lblKrediYazi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AnaEkran";
            this.Text = "Sakarya Üniversitesi Öğrenci Bilgi Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKrediYazi;
        private System.Windows.Forms.Button DerleriEklebtn;
        private System.Windows.Forms.CheckedListBox dersler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox secilendersler;
        private System.Windows.Forms.Button aktarbtn;
        private System.Windows.Forms.Button onaybtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblToplamKredi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOgrenciSayi;
        private System.Windows.Forms.Label lblDanisman;
    }
}