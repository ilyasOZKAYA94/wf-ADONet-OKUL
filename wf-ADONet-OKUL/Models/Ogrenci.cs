using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_ADONET_OKUL.Models
{
    public class Ogrenci
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string TCKNo { get; set; }
        public byte TaksitSayisi { get; set; }
        public double TaksitTutari { get; set; }
        public int SinifId { get; set; }


    }
}
