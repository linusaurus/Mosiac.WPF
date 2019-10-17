using System.Threading.Tasks;
using MosiacUI.Wrappers;

namespace Weaselware.Mosiac.UI
{
    public interface IPartDetailViewModel
    {
        PartWrapper DetailPart { get; set; }
        Task LoadAsync(int partID);
    }
}