using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace Weaselware.Mosiac.Model
{
    public class ClaimDocument
    {
        public int ClaimDocumentID { get; set; }
        public string DocumentDesciption { get; set; }
        public string DocumentExtension { get; set; }
        public int? ClaimItemID { get; set; }

        public ClaimItem ClaimItem { get; set; }
    }
}
