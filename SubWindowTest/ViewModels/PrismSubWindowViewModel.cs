using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SubWindowTest.ViewModels
{
    public class PrismSubWindowViewModel : BindableBase
    {
        private string _title = "Sub Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public PrismSubWindowViewModel()
        {

        }
    }
}
