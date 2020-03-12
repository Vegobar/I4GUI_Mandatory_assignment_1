using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Diagnostics;
using GUI_Assignment_1;

namespace GUI_Assignment_1
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.Assert(targetType == typeof(Brush));
            string money = value as string;
            decimal moneyy=decimal.Parse(money);

            if (moneyy <= 0)
                money = "neg";
           

            return (money == "neg" ? System.Windows.Media.Brushes.PaleVioletRed : System.Windows.Media.Brushes.LightGreen);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
