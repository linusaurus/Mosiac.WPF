using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Weaselware.Mosiac.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Weaselware.Mosiac.DataAccess
{
    public class DocumentPartConfig : IEntityTypeConfiguration<DocumentParts>
    {
        public  void  Configure( EntityTypeBuilder<DocumentParts> entity)
        {
            entity.HasKey(p => new { p.DocID, p.PartID });

            //---------------------------------------------
            // Relationships

           
        }
    }
}
