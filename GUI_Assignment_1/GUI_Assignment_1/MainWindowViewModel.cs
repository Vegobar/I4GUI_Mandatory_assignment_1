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
        private string filename = "";

        public MainWindowViewModel()
        {
            debitors = new ObservableCollection<Debitor>
            {
                new Debitor("Lena","2000","06/03-2020"),
                new Debitor("Mikkel","-5000","15/10-2018")
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

        ICommand _NewFileCommand;
        public ICommand NewFileCommand
        {
            get { return _NewFileCommand ?? (_NewFileCommand = new DelegateCommand(NewFileCommand_Execute)); }
        }

        private void NewFileCommand_Execute()
        {
            MessageBoxResult res = MessageBox.Show("Any unsaved data will be lost. Are you sure you want to initiate a new file?", "Warning",
               MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if(res == MessageBoxResult.Yes)
            {
                Debitors.Clear();
                filename = "";
            }
        }

        ICommand _OpenFileCommand;
        public ICommand OpenFileCommand
        {
            get { return _OpenFileCommand ?? (_OpenFileCommand = new DelegateCommand<string>(OpenFileCommand_Execute)); }
        }

        private void OpenFileCommand_Execute(string argFilename)
        {
            if (argFilename == "")
            {
                MessageBox.Show("You must enter a file name in the File Name textbox!", "Unable to save file",
            MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            else
            {
                filename = argFilename;
                var tempDebitors = new ObservableCollection<Debitor>();

                //Create an instance of the Xmlserializer class and specify the type of object to deserialize
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Debitor>));
                try
                {
                    TextReader reader = new StreamReader(filename);
                    //Deserialize all the debitors
                    tempDebitors = (ObservableCollection<Debitor>)serializer.Deserialize(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to open file", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                Debitors = tempDebitors;

            }
        }

            ICommand _SaveAsCommand;
            public ICommand SaveAsCommand
            {
                get { return _SaveAsCommand ?? (_SaveAsCommand = new DelegateCommand<string>(SaveAsCommand_Execute)); }
            }

        private void SaveAsCommand_Execute(string argFilename)
        {
            if(argFilename=="")
            {
                MessageBox.Show("You must enter a file name in the File Name textbox!", "Unable to save file",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            else
            {
                filename = argFilename;
                SaveFileCommand_Execute();
            }
        }

        ICommand _SaveCommand;

        public ICommand SaveCommand
        {
            get
            {
                return _SaveCommand ?? (_SaveCommand = new DelegateCommand(SaveFileCommand_Execute, SaveFileCommand_CanExecute)
                    .ObservesProperty(() => Debitors.Count));
            }
        }

        private void SaveFileCommand_Execute()
        {
            //Create an instance of the XmlSerializer class and specify the type of object to serialize
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Debitor>));
            TextWriter writer = new StreamWriter(filename);

            //Serialize all the agents
            serializer.Serialize(writer, Debitors);
            writer.Close();
        }

        private bool SaveFileCommand_CanExecute()
        {
            return (filename != "") && (Debitors.Count > 0);
        }


        ICommand _closeAppCommand;
        public ICommand CloseAppCommand
        {
            get
            {
                return _closeAppCommand ?? (_closeAppCommand = new DelegateCommand(() =>
                {
                    App.Current.MainWindow.Close();
                })); 
            }
        }

        }
    }
