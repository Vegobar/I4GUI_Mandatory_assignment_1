using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using System.Xml.Serialization;

namespace GUI_Assignment_1
{
    public class MainWindowViewModel : BindableBase
    {


        ICommand _addnewCommand;

        public ICommand AddNewDebtCommand
        {
            get
            {
                return _addnewCommand ?? (_addnewCommand = new DelegateCommand(() =>
                 {
                     var dlg = new Debt();
                     if(dlg.ShowDialog()==true)
                     {

                     }
                   

                 }));
            }
        }
    }
}
