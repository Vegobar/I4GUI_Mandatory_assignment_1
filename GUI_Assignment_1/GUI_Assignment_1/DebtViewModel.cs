using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Commands;
using System.Windows.Input;

namespace GUI_Assignment_1
{
     public class DebtViewModel : BindableBase
    {
        public DebtViewModel(string title, Debitor debt)
        {
            Title = title;
            currentDebt = debt;
            currentDebt.Date = DateTime.Now.ToShortDateString();

        }

        string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        Debitor currentDebt;

        public Debitor CurrentDebt
        {
            get { return currentDebt; }
            set { SetProperty(ref currentDebt, value); }
        }

        bool isValid;

        public bool IsValid
        {
            get {
                bool isValid = true;
                if (string.IsNullOrWhiteSpace(CurrentDebt.Name))
                    isValid = false;
                if (string.IsNullOrWhiteSpace(CurrentDebt.Sum))
                    isValid = false;
                return isValid;
                 }
            set
            {
                SetProperty(ref isValid, value);
            }
        }




    }
}
