using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Weaselware.Mosiac.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Weaselware.Mosiac.DataAccess
{
    public class PartClassConfig : IEntityTypeConfiguration<PartClass>
    {
        public void Configure(EntityTypeBuilder<PartClass> entity)
        {
            entity.HasKey(p => p.PartClassID);
        }
    }
}