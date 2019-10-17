using System;
using System.Collections.Generic;
using System.Text;
using Weaselware.Mosiac.Model;
using System.ComponentModel;

namespace Weaselware.Mosiac.DataAccess
{
    public class AddProductionGroupDto 
    {
       
        [ReadOnly(true)]
        public int JobID { get; set; }

        [ReadOnly(true)]
        public string JobName { get; set; }

        public string JobDescription { get; set; }

        //public ICollection<ProductionGroup> ProductionGroups { get; set; }

    }
}
