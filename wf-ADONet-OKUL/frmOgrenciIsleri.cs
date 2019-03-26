using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf_ADONET_OKUL.DataModel;
using wf_ADONET_OKUL.Models;

namespace wf_ADONET_OKUL
{
    public partial class frmOgrenciIsleri : Form
    {
        public frmOgrenciIsleri()
        {
            InitializeComponent();
        }
        int SecilenOgrenciId;
        int sinifid;

        OgrenciServis os = new OgrenciServis();
        SinifServis ss = new SinifServis();
        private void tsYeni_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;

            Genel.Temizle(tpOgrenciKayit);
        }

        private void frmOgrenciIsleri_Load(object sender, EventArgs e)
        {
            Listele(os.OgrenciListesi(),dgvOgrenciler);
            cbSiniflar.DataSource = ss.SinifModelListesi();
            SinifModel sm = new SinifModel();
            sm.Id = 0;
            sm.SinifAdi = "Tüm Sınıflar";
            List<SinifModel> liste = ss.SinifModelListesi();
            liste.Insert(0,sm);
            cbSinifaGore.DataSource = liste;
            Listele(os.OgrenciListesi(), dgvOgrenciListe2);

        }
        private void Listele(List<Ogrenci> liste, DataGridView dgv)
        {
            dgv.DataSource = liste;
            dgv.Columns[0].Visible = false;
            dgv.Columns[8].Visible = false;
        }

        #region TabControl1
        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdi.Text) && !string.IsNullOrEmpty(txtSoyadi.Text) && !string.IsNullOrEmpty(txtTaksitTutari.Text))
            {
                
                if (os.OgrenciKontrolByTCKNo(txtTCKNo.Text))
                {
                    MessageBox.Show("Bu tcye ait öğrenci var");
                    txtTCKNo.Focus();
                }
                else
                {
                    Ogrenci o = new Ogrenci();
                    o.TCKNo = txtTCKNo.Text;
                    o.Adi = txtAdi.Text;
                    o.Soyadi = txtSoyadi.Text;
                    o.SinifId = sinifid;
                    o.Telefon = txtTelefon.Text;
                    o.Adres = txtAdres.Text;
                    o.TaksitSayisi = Convert.ToByte(txtTaksitSayisi.Text);
                    o.TaksitTutari = Convert.ToDouble(txtTaksitTutari.Text);

                    if (os.OgrenciEkle(o))
                    {
                        Listele(os.OgrenciListesi(),dgvOgrenciler);
                        MessageBox.Show("Ogrenci başarıyla eklendi");
                        Genel.Temizle(tpOgrenciKayit);
                        tsKaydet.Enabled = false;
                    }
                }
                tsKaydet.Enabled = false;

            }
            else
            {
                MessageBox.Show("Eksik bilgi girişi.", "Dikkat eksik bilgi!!");
            }

            txtAdi.Focus();
        }
        private void dgvOgrenciler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tsKaydet.Enabled = false;
            tsDegistir.Enabled = true;
            tsSil.Enabled = true;
            SecilenOgrenciId = Convert.ToInt32(dgvOgrenciler.CurrentRow.Cells[0].Value.ToString());
            txtAdi.Text = dgvOgrenciler.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dgvOgrenciler.CurrentRow.Cells[2].Value.ToString();
            //SinifModel sm = new SinifModel();
            //sm.Id= Convert.ToInt32(dgvOgrenciler.CurrentRow.Cells[8]);
            foreach (SinifModel item in cbSiniflar.Items)
            {
                if (item.Id == Convert.ToInt32(dgvOgrenciler.CurrentRow.Cells[8].Value.ToString()))
                    cbSiniflar.SelectedItem = item;

            }

            txtTelefon.Text = dgvOgrenciler.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dgvOgrenciler.CurrentRow.Cells[4].Value.ToString();
            txtTCKNo.Text = dgvOgrenciler.CurrentRow.Cells[5].Value.ToString();
            txtTaksitSayisi.Text = dgvOgrenciler.CurrentRow.Cells[6].Value.ToString();
            txtTaksitTutari.Text = dgvOgrenciler.CurrentRow.Cells[7].Value.ToString();
        }
        private void tsDegistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdi.Text))
            {
                Ogrenci o = new Ogrenci();
                o.ID = SecilenOgrenciId;
                o.Adi = txtAdi.Text;
                o.Soyadi = txtSoyadi.Text;
                o.SinifId = sinifid;

                o.Telefon = txtTelefon.Text;
                o.Adres = txtAdres.Text;
                o.TCKNo = txtTCKNo.Text;
                o.TaksitSayisi = Convert.ToByte(txtTaksitSayisi.Text);
                o.TaksitTutari = Convert.ToDouble(txtTaksitTutari.Text);
                if (os.OgrenciGuncelle(o))
                {
                    Listele(os.OgrenciListesi(),dgvOgrenciler);
                    MessageBox.Show("Ogrenci başarıyla güncellendi");
                }

            }
            else
            {
                MessageBox.Show("Kategori ismi giriniz.", "Dikkat eksik bilgi!!");
            }

            txtAdi.Focus();
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istiyor musunuz?", "Veriler silinecek.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (os.OgrenciSil(SecilenOgrenciId))
                {
                    MessageBox.Show("Ogrenci başarıyla silindi.");
                    Listele(os.OgrenciListesi(),dgvOgrenciler);
                }
            }
        }
        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            Listele(os.Sorgulama(txtAdaGore.Text, txtSoyada.Text),dgvOgrenciler);
        }

        private void txtSoyada_TextChanged(object sender, EventArgs e)
        {
            Listele(os.Sorgulama(txtAdaGore.Text, txtSoyada.Text),dgvOgrenciler);

        }

        #endregion

        private void cbSinifaGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            SinifModel sm = (SinifModel)cbSinifaGore.SelectedItem;
            sinifid = sm.Id;
            Listele(os.OgrenciListesiGetirBySorgulama(sinifid, txtOgrenciAd2.Text, txtOgrenciSoyad2.Text, txtOgrenciTelefon2.Text, txtOgrenciAdres2.Text),dgvOgrenciListe2);
        }

        private void txtOgrenciAd2_TextChanged(object sender, EventArgs e)
        {
            Listele(os.OgrenciListesiGetirBySorgulama(sinifid, txtOgrenciAd2.Text, txtOgrenciSoyad2.Text, txtOgrenciTelefon2.Text, txtOgrenciAdres2.Text), dgvOgrenciListe2);
        }

        private void txtOgrenciSoyad2_TextChanged(object sender, EventArgs e)
        {
            Listele(os.OgrenciListesiGetirBySorgulama(sinifid, txtOgrenciAd2.Text, txtOgrenciSoyad2.Text, txtOgrenciTelefon2.Text, txtOgrenciAdres2.Text), dgvOgrenciListe2);
        }

        private void txtOgrenciTelefon2_TextChanged(object sender, EventArgs e)
        {
            Listele(os.OgrenciListesiGetirBySorgulama(sinifid, txtOgrenciAd2.Text, txtOgrenciSoyad2.Text, txtOgrenciTelefon2.Text, txtOgrenciAdres2.Text), dgvOgrenciListe2);
        }

        private void txtOgrenciAdres2_TextChanged(object sender, EventArgs e)
        {
            Listele(os.OgrenciListesiGetirBySorgulama(sinifid, txtOgrenciAd2.Text, txtOgrenciSoyad2.Text, txtOgrenciTelefon2.Text, txtOgrenciAdres2.Text), dgvOgrenciListe2);
        }

        private void cbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SinifModel sm = (SinifModel)cbSiniflar.SelectedItem;
            sinifid = sm.Id;
        }
    }
}
