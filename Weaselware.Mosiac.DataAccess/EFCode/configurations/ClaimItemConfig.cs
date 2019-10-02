using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Weaselware.Mosiac.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Weaselware.Mosiac.DataAccess
{
    public class ClaimItemConfig : IEntityTypeConfiguration<ClaimItem>
    {
        public void Configure(EntityTypeBuilder<ClaimItem> entity)
        {
            entity.HasKey(p => p.ClaimItemID);
            entity.HasMany(r => r.ClaimDocuments)
                .WithOne().HasForeignKey(l => l.ClaimItemID)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
        }
    }
}