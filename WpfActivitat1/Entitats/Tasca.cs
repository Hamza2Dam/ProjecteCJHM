using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfActivitat1.Entitats
{
    class Tasca
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Descripcio { get; set; }
        public string responsable { get; set; }
        public enum Colors{ red , yellow, green }
        public DateTime data_final { get; set; }
        public DateTime data_inici { get; set; }


    }
}
