using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Weaselware.Mosiac.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Weaselware.Mosiac.DataAccess
{
    public class JobConfig : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> entity)
        {
            entity.HasKey(p => p.job_id);
        }
    }
}
