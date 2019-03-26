namespace wf_ADONET_OKUL
{
    partial class frmAnasayfa
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
            this.mnuAnasayda = new System.Windows.Forms.MenuStrip();
            this.öğrenciİşleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branşlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgrenciKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOdemeIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgrenciSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSinifTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSinifSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgretmenTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgretmenSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmBransTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmBransSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgrenciBelgesi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSinifListesi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOdemeListesi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmOgretmenListesi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnasayda.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnasayda
            // 
            this.mnuAnasayda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşleriToolStripMenuItem,
            this.sınıflarToolStripMenuItem,
            this.öğretmenlerToolStripMenuItem,
            this.branşlarToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.mitmCikis});
            this.mnuAnasayda.Location = new System.Drawing.Point(0, 0);
            this.mnuAnasayda.Name = "mnuAnasayda";
            this.mnuAnasayda.Size = new System.Drawing.Size(800, 24);
            this.mnuAnasayda.TabIndex = 1;
            this.mnuAnasayda.Text = "menuStrip1";
            // 
            // öğrenciİşleriToolStripMenuItem
            // 
            this.öğrenciİşleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmOgrenciKayit,
            this.mitmOdemeIslemleri,
            this.mitmOgrenciSorgulama});
            this.öğrenciİşleriToolStripMenuItem.Name = "öğrenciİşleriToolStripMenuItem";
            this.öğrenciİşleriToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.öğrenciİşleriToolStripMenuItem.Text = "&Öğrenci İşleri";
            // 
            // sınıflarToolStripMenuItem
            // 
            this.sınıflarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmSinifTanimlama,
            this.mitmSinifSorgulama});
            this.sınıflarToolStripMenuItem.Name = "sınıflarToolStripMenuItem";
            this.sınıflarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sınıflarToolStripMenuItem.Text = "&Sınıflar";
            // 
            // öğretmenlerToolStripMenuItem
            // 
            this.öğretmenlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmOgretmenTanimlama,
            this.mitmOgretmenSorgulama});
            this.öğretmenlerToolStripMenuItem.Name = "öğretmenlerToolStripMenuItem";
            this.öğretmenlerToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.öğretmenlerToolStripMenuItem.Text = "Öğre&tmenler";
            // 
            // branşlarToolStripMenuItem
            // 
            this.branşlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmBransTanimlama,
            this.mitmBransSorgulama});
            this.branşlarToolStripMenuItem.Name = "branşlarToolStripMenuItem";
            this.branşlarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.branşlarToolStripMenuItem.Text = "&Branşlar";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmOgrenciBelgesi,
            this.mitmSinifListesi,
            this.mitmOdemeListesi,
            this.mitmOgretmenListesi});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "&Raporlar";
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(44, 20);
            this.mitmCikis.Text = "&Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // mitmOgrenciKayit
            // 
            this.mitmOgrenciKayit.Name = "mitmOgrenciKayit";
            this.mitmOgrenciKayit.Size = new System.Drawing.Size(180, 22);
            this.mitmOgrenciKayit.Text = "Öğrenci &Kayıt";
            this.mitmOgrenciKayit.Click += new System.EventHandler(this.mitmOgrenciKayit_Click);
            // 
            // mitmOdemeIslemleri
            // 
            this.mitmOdemeIslemleri.Name = "mitmOdemeIslemleri";
            this.mitmOdemeIslemleri.Size = new System.Drawing.Size(180, 22);
            this.mitmOdemeIslemleri.Text = "Ödeme &İşlemleri";
            // 
            // mitmOgrenciSorgulama
            // 
            this.mitmOgrenciSorgulama.Name = "mitmOgrenciSorgulama";
            this.mitmOgrenciSorgulama.Size = new System.Drawing.Size(180, 22);
            this.mitmOgrenciSorgulama.Text = "Öğrenci &Sorgulama";
            // 
            // mitmSinifTanimlama
            // 
            this.mitmSinifTanimlama.Name = "mitmSinifTanimlama";
            this.mitmSinifTanimlama.Size = new System.Drawing.Size(180, 22);
            this.mitmSinifTanimlama.Text = "Sınıf &Tanmlama";
            // 
            // mitmSinifSorgulama
            // 
            this.mitmSinifSorgulama.Name = "mitmSinifSorgulama";
            this.mitmSinifSorgulama.Size = new System.Drawing.Size(180, 22);
            this.mitmSinifSorgulama.Text = "Sınıf Sorgulama";
            // 
            // mitmOgretmenTanimlama
            // 
            this.mitmOgretmenTanimlama.Name = "mitmOgretmenTanimlama";
            this.mitmOgretmenTanimlama.Size = new System.Drawing.Size(190, 22);
            this.mitmOgretmenTanimlama.Text = "Öğretmen &Tanımlama";
            // 
            // mitmOgretmenSorgulama
            // 
            this.mitmOgretmenSorgulama.Name = "mitmOgretmenSorgulama";
            this.mitmOgretmenSorgulama.Size = new System.Drawing.Size(190, 22);
            this.mitmOgretmenSorgulama.Text = "Öğretmen &Sorgulama";
            // 
            // mitmBransTanimlama
            // 
            this.mitmBransTanimlama.Name = "mitmBransTanimlama";
            this.mitmBransTanimlama.Size = new System.Drawing.Size(180, 22);
            this.mitmBransTanimlama.Text = "Branş &Tanımlama";
            // 
            // mitmBransSorgulama
            // 
            this.mitmBransSorgulama.Name = "mitmBransSorgulama";
            this.mitmBransSorgulama.Size = new System.Drawing.Size(180, 22);
            this.mitmBransSorgulama.Text = "Branş &Sorgulama";
            // 
            // mitmOgrenciBelgesi
            // 
            this.mitmOgrenciBelgesi.Name = "mitmOgrenciBelgesi";
            this.mitmOgrenciBelgesi.Size = new System.Drawing.Size(180, 22);
            this.mitmOgrenciBelgesi.Text = "Öğrenci Belgesi";
            // 
            // mitmSinifListesi
            // 
            this.mitmSinifListesi.Name = "mitmSinifListesi";
            this.mitmSinifListesi.Size = new System.Drawing.Size(180, 22);
            this.mitmSinifListesi.Text = "Sınıf Listeleri";
            // 
            // mitmOdemeListesi
            // 
            this.mitmOdemeListesi.Name = "mitmOdemeListesi";
            this.mitmOdemeListesi.Size = new System.Drawing.Size(180, 22);
            this.mitmOdemeListesi.Text = "Ödeme Listesi";
            // 
            // mitmOgretmenListesi
            // 
            this.mitmOgretmenListesi.Name = "mitmOgretmenListesi";
            this.mitmOgretmenListesi.Size = new System.Drawing.Size(180, 22);
            this.mitmOgretmenListesi.Text = "Öğretmen Listesi";
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuAnasayda);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnasayda;
            this.Name = "frmAnasayfa";
            this.Text = "Öğrenci Takibi Anasayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.mnuAnasayda.ResumeLayout(false);
            this.mnuAnasayda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnasayda;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmOgrenciKayit;
        private System.Windows.Forms.ToolStripMenuItem mitmOdemeIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mitmOgrenciSorgulama;
        private System.Windows.Forms.ToolStripMenuItem sınıflarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmSinifTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmSinifSorgulama;
        private System.Windows.Forms.ToolStripMenuItem öğretmenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmOgretmenTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmOgretmenSorgulama;
        private System.Windows.Forms.ToolStripMenuItem branşlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmBransTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmBransSorgulama;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmOgrenciBelgesi;
        private System.Windows.Forms.ToolStripMenuItem mitmSinifListesi;
        private System.Windows.Forms.ToolStripMenuItem mitmOdemeListesi;
        private System.Windows.Forms.ToolStripMenuItem mitmOgretmenListesi;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
    }
}