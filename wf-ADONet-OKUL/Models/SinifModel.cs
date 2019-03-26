using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_ADONET_OKUL.Models
{
    public class SinifModel
    {
        public int Id { get; set; }
        public string SinifAdi { get; set; }

        public override string ToString()
        {
            return SinifAdi;
        }
    }
}
