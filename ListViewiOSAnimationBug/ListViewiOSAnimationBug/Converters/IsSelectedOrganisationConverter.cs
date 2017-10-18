namespace ListViewiOSAnimationBug.Converters
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;

    public class IsSelectedOrganisationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? "OrganisationsTickIcon" : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
