﻿using System.Globalization;

namespace Maui06MVVM.Converters
{
    internal class ColorToHexString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var typeCode = Type.GetTypeCode(targetType);
            if (value is Color && typeCode == TypeCode.String)
            {
                return (value as Color).ToArgbHex();
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
