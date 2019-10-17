using System;
using System.Collections.Generic;
using System.Text;
using Weaselware.Mosiac.Model;
using Weaselware.Mosiac.DataAccess;
using System.Collections.ObjectModel;

namespace Weaselware.Mosiac.UI.ViewModel
{
    public class MainViewModel
    {
        private MosiacContext _ctx;
        public MainViewModel()
        {
            _ctx  = new MosiacContext();
        }

        public ObservableCollection<Part> Parts { get; set; }

        

    }
}
