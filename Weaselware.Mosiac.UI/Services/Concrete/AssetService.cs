using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weaselware.Mosiac.DataAccess;
using Weaselware.Mosiac.Model;

namespace Weaselware.Mosiac.UI.Services
{
    public class AssetService : IAssetService
    {
        public AssetService()
        {
            using (MosiacContext dbContext = new MosiacContext())
            {
                
            }
        }

        public ObservableCollection<Asset> GetAll()
        {
            return null;
        }

        public Asset Find(int assetID)
        {
            return new Asset();
        }

        public void Save(Asset asset)
        {

        }


    }
}
