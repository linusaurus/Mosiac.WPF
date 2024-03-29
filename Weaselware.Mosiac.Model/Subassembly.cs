using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Weaselware.Mosiac.Model { 

public class SubAssembly
{
    public int? SubAssemblyID { get; set; }
    public int? ProductID { get; set; }
    public string SubAssemblyName { get; set; }
    public string MakeFile { get; set; }
    public int? UnitID { get; set; }
    public decimal? W { get; set; }
    public decimal? H { get; set; }
    public decimal? D { get; set; }
    public int? CPD_id { get; set; }

    public Product Product { get; set; }
}

}
