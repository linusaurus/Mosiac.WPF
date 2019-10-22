using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Weaselware.Mosiac.Model
{
    public class Manu
    {
        public int ManuID { get; set; }
        public string Manufacturer { get; set; }
        public string Phone { get; set; }
        public string WebAddress { get; set; }
        public int? ManuCategoryID { get; set; }
        public ICollection<Part> Parts { get; set; } = new HashSet<Part>();  
    }
}
