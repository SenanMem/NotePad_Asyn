using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace NotePad.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MenuVM:BaseVM
    {
        public RelayCommand Ctrl_Z;


        public MenuVM()
        {
            Ctrl_Z = new RelayCommand(Ctrl_Z_Mehtod);
        }
        public void Ctrl_Z_Mehtod()
        {

        }
    }
}
