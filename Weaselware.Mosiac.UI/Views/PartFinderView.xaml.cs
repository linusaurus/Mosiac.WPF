using FirstFloor.ModernUI.Windows;
using MosiacUI.Services;
using System;
using System.Windows.Controls;
using Database;

namespace MosiacUI.Views
{
    /// <summary>
    /// Interaction logic for PartManagerView.xaml
    /// </summary>
    public partial class PartManagerView : UserControl , IContent
    {
        private readonly IPartService _partService;

        public PartManagerView(IPartService partSearvice)
        {
            InitializeComponent();
            _partService = partSearvice;
        }

        public void OnFragmentNavigation(FirstFloor.ModernUI.Windows.Navigation.FragmentNavigationEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(FirstFloor.ModernUI.Windows.Navigation.NavigationEventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(FirstFloor.ModernUI.Windows.Navigation.NavigationEventArgs e)
        {
           //throw new NotImplementedException();
        }

        public void OnNavigatingFrom(FirstFloor.ModernUI.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            // ask user if navigating away is ok
            //if (ModernDialog.ShowMessage("Navigate away?", "navigate", MessageBoxButton.YesNo) == MessageBoxResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
