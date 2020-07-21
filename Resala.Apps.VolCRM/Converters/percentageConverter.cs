using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace Resala.Apps.VolCRM.Converters
{
    /// <summary>
    /// Scale the value with the percentage passed as argument
    /// </summary>
    public class PercentageConverter : MarkupExtension , IValueConverter
    {
        private PercentageConverter instance;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToDouble(value) * (System.Convert.ToDouble(parameter) / 100);   
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return instance ?? (instance = new PercentageConverter());
        }
    }
}
