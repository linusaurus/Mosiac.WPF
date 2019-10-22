using System.Collections.Generic;
using System.Threading.Tasks;
using Weaselware.Mosiac.Model;

namespace Weaselware.Mosiac.UI.Services
{
    public interface IPartTypeLookup
    {
        Task<IEnumerable<LookupItem>> GetPartTypeLookupAsync(int partCategoryID);
    }
}