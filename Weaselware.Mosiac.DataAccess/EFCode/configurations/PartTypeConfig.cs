using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Weaselware.Mosiac.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Weaselware.Mosiac.DataAccess
{
    public class PartTypeConfig : IEntityTypeConfiguration<PartTypes>
    {
        public void Configure(EntityTypeBuilder<PartTypes> entity)
        {
            entity.HasKey(p => p.PartTypeName);
        }
    }
}