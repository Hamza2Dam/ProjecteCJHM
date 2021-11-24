using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteExampleV2.Entity
{
    public class Tasca
    {
        public int Codi { get; set; }
        public string Nom { get; set; }
        public string Descripcio { get; set; }
        public string Responsable { get; set; }
        public string Colors { get; set; }
        public DateTime Data_Inici { get; set; }
        public DateTime Data_Final { get; set; }


    }
}
