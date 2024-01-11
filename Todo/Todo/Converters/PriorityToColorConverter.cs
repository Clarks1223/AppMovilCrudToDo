using System;
using Xamarin.Forms;

namespace Todo.Converters
{
    public class PriorityToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string priority = value as string;

            switch (priority)
            {
                case "Alta":
                    return Color.Red;
                case "Media":
                    return Color.Yellow;
                case "Baja":
                    return Color.Green;
                default:
                    return Color.Black; // Puedes cambiar esto a otro color por defecto si es necesario
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
