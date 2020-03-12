using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI_Assignment_1
{
    /// <summary>
    /// Interaction logic for Debt.xaml
    /// </summary>
    public partial class Debt : Window
    {
        public Debt()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {   

            var vm = DataContext as DebtViewModel;
            if (vm.IsValid)
            {
                DialogResult = true;
                btnOk.IsEnabled = true;
            }

            else
                MessageBox.Show("You need to enter values for name and debt value", "Missing data");
        }


    }
}
