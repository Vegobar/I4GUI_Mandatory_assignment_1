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
    /// Interaction logic for TotalDebtView.xaml
    /// </summary>
    public partial class TotalDebtView : Window
    {
        public TotalDebtView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as TotalDebtViewModel;
            DialogResult = true;
        }
    }
}