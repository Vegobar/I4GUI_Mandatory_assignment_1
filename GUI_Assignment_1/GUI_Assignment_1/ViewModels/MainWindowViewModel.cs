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
        private ObservableCollection<Debitor> debitors;

        public MainWindowViewModel()
        {
            debitors = new ObservableCollection<Debitor>
            {
                new Debitor("Lena","2000"),
                new Debitor("Mikkel","-5000")
            };
        }


        public ObservableCollection<Debitor> Debitors
        {
            get { return debitors; }
            set { SetProperty(ref debitors, value); }
        }

        Debitor _currentDebitor = null;

        public Debitor CurrentDebitor
        {
            get { return _currentDebitor; }
            set
            {
                SetProperty(ref _currentDebitor, value);
            }
        }

        int currentIndex = 1;

        public int CurrentIndex
        {
            get { return currentIndex; }
            set { SetProperty(ref currentIndex, value); }

        }


        ICommand _addnewCommand;

        public ICommand AddNewDebtCommand
        {
            get
            {
                return _addnewCommand ?? (_addnewCommand = new DelegateCommand(() =>
                 {
                     var newDebitor = new Debitor();
                     var vmD = new DebtViewModel("Adding new debt", newDebitor);
                     var dlg = new Debt();
                     dlg.DataContext =vmD;
                     if(dlg.ShowDialog()==true)
                     {
                         Debitors.Add(newDebitor);
                         CurrentDebitor = newDebitor;
                         CurrentIndex = 0;
                     }
                   

                 }));
            }
        }
    }
}
