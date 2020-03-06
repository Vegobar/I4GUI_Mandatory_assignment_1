using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace GUI_Assignment_1
{
    public class Debitor : BindableBase 
    {
        public Debitor()
        {

        }

        public Debitor(string dName, string dSum)
        {
            _name = dName;
            _sum = dSum;
        }

         string _name;
         string _sum;

         public string Name
        {
            get{return _name;}
            set{SetProperty(ref _name,value);}
        }

        public string Sum
        {
            get{return _sum;}
            set{SetProperty(ref _sum, value);}
        }
    }
}
