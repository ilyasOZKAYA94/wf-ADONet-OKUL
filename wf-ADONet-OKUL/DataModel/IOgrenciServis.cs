using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_ADONET_OKUL.Models;

namespace wf_ADONET_OKUL.DataModel
{
    public interface IOgrenciServis
    {
        bool OgrenciEkle(Ogrenci o);
        bool OgrenciGuncelle(Ogrenci o);

        bool OgrenciSil(int ID);

        bool OgrenciSil(Ogrenci o);

        Ogrenci OgrenciGetirById(int ID);

        List<Ogrenci> OgrenciListesi();
    }
}
