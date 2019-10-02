using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace Weaselware.Mosiac.Model
{
    public class Category
    {
        public Category()
        {
            this.PartTypes = new HashSet<PartType>();
        }

        public int Categoryid { get; set; }
       // public string Category { get; set; }
        public int? PartClassID { get; set; }

        public PartClass PartClass { get; set; }
        public ICollection<PartType> PartTypes { get; set; }
    }
}
