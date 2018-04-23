using System;
using System.Windows.Data;
using System.Globalization;
using DevExpress.Xpf.Core;
using System.Windows;

namespace How_to_Customize_Drop_Marker {
    public class InternalMarkerVisibilityConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if ((DropPosition)value == DropPosition.Inside)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }

    public class ExternalMarkerVisibilityConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if ((DropPosition)value == DropPosition.Before || (DropPosition)value == DropPosition.After)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }

    public class VerticalAlignmentConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if ((DropPosition)value == DropPosition.Before)
                return VerticalAlignment.Top;
            else
                return VerticalAlignment.Bottom;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
