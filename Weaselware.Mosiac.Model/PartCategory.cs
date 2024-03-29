﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weaselware.Mosiac.Model
{
    public class PartCategory
    {
        [Key]
        public int PartCategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<PartTypes> PartTypes { get; set; } = new HashSet<PartTypes>();
    }
}
