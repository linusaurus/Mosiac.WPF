using Weaselware.Mosiac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Weaselware.Mosiac.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Weaselware.Mosiac.UI.Services
{
    public class LookupDataService : IManufacturerLookupService, ISupplierLookupDataService, ILookupUnitsOfMeasure, IPartCategoryLookup, IPartTypeLookup
    {
        private Func<MosiacContext> _contextCreator;

        public LookupDataService(Func<MosiacContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

      

        public async Task<IEnumerable<LookupItem>> GetManufacturerLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return  await ctx.Manu.AsNoTracking()
                  .Select(f =>
                  new LookupItem
                  {
                      Id = f.ManuID,
                      DisplayMember = f.Manufacturer
                  })
                  .ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetSupplierLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Supplier.AsNoTracking()
                  .Select(f =>
                  new LookupItem
                  {
                      Id = f.SupplierID,
                      DisplayMember = f.SupplierName
                  })
                  .ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetUnitsOfMeasureLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.UnitOfMeasure.AsNoTracking()
                  .Select(f =>
                  new LookupItem
                  {
                      Id = f.UID,
                      DisplayMember = f.UOM
                  })
                  .ToListAsync();
            }
        }
        /// <summary>
        /// Fast Part GetAll No Tracking
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LookupItem>> GetPartLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Part.AsNoTracking()
                  .Select(f =>
                  new LookupItem
                  {
                      Id = f.PartID,
                      DisplayMember = f.ItemDescription
                  })
                  .ToListAsync();
            }
        }
        /// <summary>
        /// Fast part Search No Tracking
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LookupItem>> GetPartSearchLookupAsync(string term)
        {
            int id;
            if (int.TryParse(term, out id))
            {
                using (var ctx = _contextCreator())
                {
                    return await ctx.Part.AsNoTracking().Where(m => m.PartID == id)
                      .Select(f =>
                      new LookupItem
                      {
                          Id = f.PartID,
                          DisplayMember = f.ItemDescription
                      })
                      .ToListAsync();
                }
            }
            else
            { 
                    using (var ctx = _contextCreator())
                    {
                        return await ctx.Part.AsNoTracking().Where(m => m.ItemDescription.Contains(term))
                          .Select(f =>
                          new LookupItem
                          {
                              Id = f.PartID,
                              DisplayMember = f.ItemDescription
                          })
                          .ToListAsync();
                    }
            }
        }



        Task<IEnumerable<PartCategory>> IPartCategoryLookup.GetPartCategoryLookupAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LookupItem>> GetPartTypeLookupAsync(int partCategoryID)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.PartTypes.AsNoTracking()
                  .Select(f =>
                  new LookupItem
                  {
                      Id = f.PartTypeID,
                      DisplayMember = f.PartTypeName
                  })
                  .ToListAsync();
            }
        }
    }
}
