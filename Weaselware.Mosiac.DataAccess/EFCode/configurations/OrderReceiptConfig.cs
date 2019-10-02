using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Weaselware.Mosiac.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Weaselware.Mosiac.DataAccess
{
    public class OrderReceiptConfig : IEntityTypeConfiguration<OrderReciept>
    {
        public void Configure(EntityTypeBuilder<OrderReciept> entity)
        {
            entity.HasKey(p => p.OrderReceiptID);
        }
    }
}
