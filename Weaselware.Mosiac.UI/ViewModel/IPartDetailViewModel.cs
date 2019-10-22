using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Weaselware.Mosiac.Model;
using Weaselware.Mosiac.DataAccess;
using Weaselware.Mosiac.UI.Services;
using Weaselware.Mosiac.UI.Wrappers;

namespace Weaselware.Mosiac.UI.ViewModel
{
    public interface IPartDetailViewModel
    {
        PartWrapper DetailPart { get; set; }
        ObservableCollection<Document> PartResources { get; set; }
        ObservableCollection<PurchaseOrderListDTO> PartOrders { get; set; }
        ObservableCollection<InventoryTransactionsDTO> PartTransactions { get; set; }
        Task LoadManusList();
        Task LoadSuppliersList();
        Task LoadAsync(int partID);
        Task LoadUnitsOfMeasureList();
        
        
    }
}