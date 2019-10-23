using System;
using System.Collections.Generic;
using System.Text;
using Prism.Events;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Weaselware.Mosiac.UI.ViewModel;

namespace Weaselware.Mosiac.UI
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        private readonly MainViewModel _vm;
        private readonly IPartDetailViewModel _partModel;

        public Main(MainViewModel vm, IPartDetailViewModel partModel)
        {
            InitializeComponent();
            _vm = vm;
            _partModel = partModel;
            DataContext = _vm;
            Loaded += Main_Loaded;
        }

        private async void Main_Loaded(object sender, RoutedEventArgs e)
        {
            await _vm.LoadAsync();
            await _partModel.LoadManusList();

        }

        public IPartDetailViewModel PartDetailViewModel { get; }

       
    }
}
