using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_232410101022_UTSPBO
{
    public class KelasTask
    {
        public string Judul { get; set; }
        public string Deskripsi { get; set; }
        public string Deadline { get; set; }

        public override string ToString()
        { return $"{Judul} - {Deadline.ToShortDateString()}"; }
    }
}
