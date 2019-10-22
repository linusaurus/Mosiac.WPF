
using System;
using System.Windows;
using System.Windows.Controls;
using Weaselware.Mosiac.UI.Services;
using Weaselware.Mosiac.DataAccess;

namespace Weaselware.Mosiac.UI
{
    /// <summary>
    /// Interaction logic for PartManagerView.xaml
    /// </summary>
    public partial class PartManagerView : UserControl 
    {
        private readonly IPartService _partService;

        public PartManagerView(IPartService partSearvice)
        {
           // InitializeComponent();
            _partService = partSearvice;
        }

        
    }
}
