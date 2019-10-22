using System.Collections.Generic;
using System.Threading.Tasks;
using Weaselware.Mosiac.Model;

namespace Weaselware.Mosiac.UI
{
    public interface IPartRepository
    {

        Task<Part> GetByIdAsync(int partID);
        bool HasChanges();
        Task SaveAsync();
        
    }
}