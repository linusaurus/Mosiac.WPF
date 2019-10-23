using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weaselware.Mosiac.DataAccess;
using Weaselware.Mosiac.Model;
using Microsoft.EntityFrameworkCore;



namespace Weaselware.Mosiac.UI.Services
{
    public class PartService : IPartService
    {
        private Func<MosiacContext> _contextCreator;

        public PartService(Func<MosiacContext> contextCreator)
        {
            _contextCreator  = contextCreator;
        }

        //inserts record in the DB via DAL
        public void Add(Part part)
        {
            
            using(var ctx = _contextCreator())
            {
                Part newPart = new Part()
                {
                    ItemDescription = part.ItemDescription,
                    PartNum = part.PartNum,
                    SKU = part.SKU,
                    MarkUp = part.MarkUp.GetValueOrDefault(),
                    ManuID = part.ManuID.GetValueOrDefault(),
                    ParentID = part.ParentID.GetValueOrDefault(),
                    AddedBy = "rich",
                    DateAdded = DateTime.Today,
                    ItemName = part.ItemName,
                    Cost = part.Cost,
                    ManuPartNum = part.ManuPartNum,
                    CARBlevel = part.CARBlevel,
                    CARBtrack = part.CARBtrack,
                    UID = part.UID
                };
                ctx.SaveChanges();
            }
            
        }


        public async Task<List<Document>> GetPartResources(int partID)
        {
            using(var ctx = _contextCreator())
            {
                return await ctx.Document.AsNoTracking().Where(p => p.PartID == partID).ToListAsync();
            }
           

        }
        public void AddPartResources(Document doc)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Document.Add(doc);
                ctx.SaveChanges();
            } 
       


        }

        public async Task<IList<Part>> Search(string term)
        {
           using(var ctx = _contextCreator())
            {

                    if (int.TryParse(term, out int result))
                    {
                        return await ctx.Part.AsNoTracking().Where(d => d.PartID == result).ToListAsync();
                    }
                    else
                    {
                        return await ctx.Part.AsNoTracking().Where(d => d.ItemDescription.Contains(term)).ToListAsync();
                    }
            }
        }

        public async Task<IList<Part>> GetAllAsync()
        {
            using(var ctx = _contextCreator())
            {
                return await ctx.Part.AsNoTracking().ToListAsync();
            }
            
        }

        public async Task<Part> GetPart(int partID)
        {
            using(var ctx = _contextCreator())
            {
                return await ctx.Part.FindAsync(partID);
            }
           
        }

        public void Update(Part part)
        {
            using(var ctx = _contextCreator())
            {
                ctx.SaveChanges();
            }
           
        }

        public void Delete(int partID)
        {
            // deletes record from the DB
        }

        public void Update(PartDetailDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Part part)
        {
            using(var ctx = _contextCreator())
            {
                ctx.Part.Add(part);
                ctx.Entry(part).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }
 

        }

        public async Task<List<InventoryTransactionsDTO>> GetPartTransactionAsync(int partID)
        {
            using (var ctx = _contextCreator())
            {

         
            try
            {
                return await ctx.Inventory.AsNoTracking().Where(p => p.PartID == partID)
               .Select(d => new InventoryTransactionsDTO
               {
                   DateStamp = d.DateStamp.GetValueOrDefault(),
                   Description = d.Description,
                   LineID = d.LineID.GetValueOrDefault(),
                   PartID = d.PartID.GetValueOrDefault(),
                   JobName = ctx.Job.Where(j => j.job_id == d.JobID.GetValueOrDefault()).Select(s => s.jobname).First(),
                   Location = d.Location,
                   OrderReceiptID = d.OrderReceiptID.GetValueOrDefault(),
                   Qnty = d.Qnty.GetValueOrDefault(),
                   StockTransactionID = d.StockTransactionID,
                   TransActionType = "1",
                   UnitOfMeasure = ctx.UnitOfMeasure.Where(u => u.UID == d.UnitOfMeasure.GetValueOrDefault()).Select(p => p.UOM).First()

               }).ToListAsync();

            }
            catch (Exception)
            {

                return null;
            }

            }


        }

        public async Task<List<PurchaseOrderListDTO>> GetPartOrders(int partID)
        {
            
            using(var ctx = _contextCreator())
            {

           
            
            try
            {
              return await ctx.PurchaseLineItem.Include(f => f.PurchaseOrder).AsNoTracking().Where(p => p.PartID == partID)
              .Select(d => new PurchaseOrderListDTO
              {
                  PurchaseOrderID = d.PurchaseOrderID,
                  JobName = ctx.Job.Where(j => j.job_id == d.JobID.Value).First().jobname,
                  OrderDate = d.PurchaseOrder.OrderDate.ToShortDateString(),
                  OrderTotal = d.PurchaseOrder.OrderTotal.GetValueOrDefault(),
                  Purchaser = d.PurchaseOrder.Employee.lastname,
                  SupplierName = d.PurchaseOrder.Supplier.SupplierName,
                  Received = d.Recieved.GetValueOrDefault()

              }).OrderByDescending(j => j.PurchaseOrderID).ToListAsync();
                }
                catch (Exception)
                {

                    return null;
                }
            
            }

        }
    }
}
