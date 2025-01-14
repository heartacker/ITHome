﻿using ITHome.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ITHome.Converters
{
    public class NullToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            /*string defaultInvisibility = parameter as string;
            Visibility invisibility = (defaultInvisibility != null) ?
                (Visibility)Enum.Parse(typeof(Visibility), defaultInvisibility)
                : Visibility.Collapsed;
            return value == null? invisibility : Visibility.Visible;*/

            if(value is List<string> list)
            {
                if(list.Count == 0) return Visibility.Collapsed;
                else return Visibility.Visible;
            }
            if (value is int num)
            {
                if (num == 0) return Visibility.Collapsed;
                else return Visibility.Visible;
            }
            if (value == null || value.ToString() == "")
            {
                return Visibility.Collapsed;
            }
            else
                return Visibility.Visible;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
