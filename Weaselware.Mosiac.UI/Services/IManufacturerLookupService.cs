using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Weaselware.Mosiac.Model;

namespace Weaselware.Mosiac.UI.Services
{ 
    public interface IManufacturerLookupService
    {
       Task<IEnumerable<LookupItem>> GetManufacturerLookupAsync();
    }
}