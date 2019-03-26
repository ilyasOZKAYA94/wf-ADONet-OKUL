using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ADONET_OKUL.Models
{
    public class Genel
    {
        

        public static string conStr = "Data Source=WISSEN\\MSSQL2017;Initial Catalog=OKUL;uid=sa;pwd=12345";

        public static void Temizle(TabPage tp)
        {

            foreach (Control item in tp.Controls)
            {
                if(item is TextBox)
                item.Text = string.Empty;
            }


        }

    }
}
