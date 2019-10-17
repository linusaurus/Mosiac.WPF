using Database.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Prism.Events;
using Prism.Commands;
using System.Threading.Tasks;
using MosiacUI.Views.Services;
using MosiacUI.Services;
using MosiacUI.Events;

namespace MosiacUI.ViewModels
{
    public class PartFinderViewModel : ViewModelBase
    {
        
        private readonly IMessageDialogService _messageDialogService;
        private readonly IEventAggregator _eventAggregator;
        private readonly IPartDetailViewModel _partDetailViewModel;
        private Part _selectedPart;

        public IPartService _partService { get; }
        public ObservableCollection<Part> Parts { get; private set; }

        public PartFinderViewModel(IPartService partService,
             IEventAggregator eventAggregator, Func<IPartDetailViewModel> partDetailViewModel)
        {
            // _eventAggregator.GetEvent<AfterPartSavedEvent>().Subscribe(AfterPartSaved);
            // _eventAggregator.GetEvent<OpenPartDetailEvent>().Subscribe(OnOpenDetailPart);

            Parts = new ObservableCollection<Part>();

            _partService = partService;
            _partDetailViewModel = partDetailViewModel();

            _eventAggregator = eventAggregator;
            PartDetailModel = partDetailViewModel();

        }

        // Load the Datasource here
        public async Task LoadAsync()
        {
            var parts = await _partService.GetAllAsync();
            Parts.Clear();
            foreach (var part in parts)
            {
                Parts.Add(part);
            }
    

        }
        // Search Part by Description or PartID
        public async void Search(string term)
        {
            //TODO load partlineitem as viewModels
            var parts = await _partService.Search(term);
            Parts.Clear();
            foreach (var part in parts)
            {
                Parts.Add(part);
            }
        }

        public Part SelectedPart
        {
            get { return _selectedPart; }
            set {
                _selectedPart = value;
                OnPropertyChanged();
                if (_selectedPart != null)
                {
                    _eventAggregator.GetEvent<OpenPartDetailEvent>()
                        .Publish(_selectedPart.PartID);
                }
            }
        }

        private async void OnOpenDetailPart(int obj)
        {
            // PartDetailModel = _partDetailViewModel();
            // await PartDetailModel.LoadAsync(obj);
        }

        private void AfterPartSaved(AfterPartSavedEventArgs obj)
        {
            var lookupItem = Parts.Single(l => l.PartID == obj.Id);
            lookupItem.ItemDescription = obj.DisplayMember;
        }






        public IPartDetailViewModel PartDetailModel { get; set; }
    }
}
