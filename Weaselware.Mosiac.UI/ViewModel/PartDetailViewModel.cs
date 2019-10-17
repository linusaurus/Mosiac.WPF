using Weaselware.Mosiac.UI.Events;
using Weaselware.Mosiac.UI.Services;
using MosiacUI.Wrappers;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weaselware.Mosiac.UI.ViewModels
{
    public class PartDetailViewModel : ViewModelBase, IPartDetailViewModel
    {
        private readonly IPartService _partService;
        private readonly IEventAggregator _eventAggregator;
       

        public PartDetailViewModel(IPartService partService,
            IEventAggregator eventAggregator)
        {
            ///TODO  replace with single repository
            ///

            _partService = partService;
            
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenPartDetailEvent>().Subscribe(OnOpenPartDetailView);

        }


        private bool OnSaveCanExecute()
        { return true; }

      
        private async void OnOpenPartDetailView(int partID)
        {
            await LoadAsync(partID);
        }

        public async Task LoadAsync(int partID)
        {

        }

 
        private PartWrapper part;

        public PartWrapper DetailPart
        {
            get { return part; }
            set {
                part = value;
                OnPropertyChanged();
            }
        }


    }
}
