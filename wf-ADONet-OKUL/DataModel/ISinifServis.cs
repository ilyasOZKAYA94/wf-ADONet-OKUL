using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_ADONET_OKUL.Models;

namespace wf_ADONET_OKUL.DataModel
{
    public interface ISinifServis
    {
        bool SinifEkle(Sinif s);
        bool SinifGuncelle(Sinif s);

        bool SinifSil(int ID);

        bool SinifSil(Sinif s);

        Sinif SinifGetirById(int ID);

        List<Sinif> SinifListesi();

    }
}
