using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteWpfActivitat1.Entitats
{
    public class Responsable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public DateTime Birthday { get; set; }

    }
}
