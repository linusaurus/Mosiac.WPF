using System;
using System.Collections.Generic;
using System.Text;
using Weaselware.Mosiac.Model;
using System.Collections.ObjectModel;

namespace Weaselware.Mosiac.UI.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {

        }

        public ObservableCollection<Part> Parts { get; set; }


    }
}
