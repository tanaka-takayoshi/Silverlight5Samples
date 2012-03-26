using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Markup;

namespace Silverlight5Samples.Samples
{
    public class TextToSolidColorConverter : IValueConverter
    {

        public object Convert(object value,
                            Type targetType,
                            object parameter,
                            CultureInfo culture)
        {
            var xaml = "<SolidColorBrush " +
                "xmlns='http://schemas.microsoft.com/client/2007' " +
                "Color=\"" + value.ToString() + "\"/>";
            return XamlReader.Load(xaml);
        }

        public object ConvertBack(object value,
                            Type targetType,
                            object parameter,
                            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
