using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_ADONET_OKUL.Models
{
    public class Sinif
    {
        public int Id { get; set; }
        public string SinifAdi { get; set; }
        public DateTime AcilisTarihi { get; set; }
        public DateTime KapanisTarihi { get; set; }
        public int OgretmenId { get; set; }
        public string Aciklama { get; set; }
    }
}
