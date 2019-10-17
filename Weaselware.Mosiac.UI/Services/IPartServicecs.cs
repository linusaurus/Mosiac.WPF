using Weaselware.Mosiac.Model;
using Weaselware.Mosiac.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weaselware.Mosiac.UI.Services
{
    public interface IPartService
    {
        void Add(Part obj);
        void Delete(int partID);
        void AddPartResources(Document doc);
        Task<IList<Part>> GetAllAsync();
        Task<Part> GetPart(int partID);
        Task<IList<Part>> Search(string term);
        Task Save(Part part);
        Task<List<Document>> GetPartResources(int partID);
        Task<List<PurchaseOrderListDTO>> GetPartOrders(int partID);
        Task<List<InventoryTransactionsDTO>> GetPartTransactionAsync(int partID);
    }
}
