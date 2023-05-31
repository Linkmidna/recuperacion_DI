using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UT5E04
{
    internal class AsisteConverter : IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case true: return "Asistido";
                case false: return "No asistido";
            }
            return "No asistido";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                switch (value)
                {
                    case "Asistido": return true;
                    case "No asistido": return false;
                }
            }
            return false;
        }
    }
}
