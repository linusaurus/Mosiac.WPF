﻿using System;
using System.Collections.Generic;
using Weaselware.Mosiac.DataAccess;
using Weaselware.Mosiac.Model;

namespace Weaselware.Mosiac.DataAccess
{
    public class PurchaseOrderListDTO
    {
        public int PurchaseOrderID { get; set; }
        public String OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
        public string JobName { get; set; }
        public string Purchaser { get; set; }
        public string SupplierName { get; set; }
        public bool Received { get; set; }
 
    }
}
