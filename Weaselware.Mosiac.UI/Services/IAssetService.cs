using System.Collections.ObjectModel;
using Weaselware.Mosiac.Model;

namespace Weaselware.Mosiac.UI.Services
{
    public interface IAssetService
    {
        Asset Find(int assetID);
        ObservableCollection<Asset> GetAll();
        void Save(Asset asset);
    }
}