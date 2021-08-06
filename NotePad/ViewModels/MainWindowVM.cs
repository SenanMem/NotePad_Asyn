using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotePad.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowVM:BaseVM
    {
        public BaseVM CurrentVM{ get; set; }
        private MenuVM _menuVM{ get; set; }
        public MainWindowVM()
        {
            _menuVM = new MenuVM();
            CurrentVM = _menuVM;
        }
    }
}
