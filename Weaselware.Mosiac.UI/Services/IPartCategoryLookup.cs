using System.Collections.Generic;
using System.Threading.Tasks;
using Weaselware.Mosiac.Model;

namespace Weaselware.Mosiac.UI.Services
{
    public interface IPartCategoryLookup
    {
        Task<IEnumerable<PartCategory>> GetPartCategoryLookupAsync();
    }
}