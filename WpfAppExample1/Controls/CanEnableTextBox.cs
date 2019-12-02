using System.Windows;
using System.Windows.Controls;

namespace WpfAppExample1.Controls
{
    public class CanEnableTextBox : TextBox
    {

        static CanEnableTextBox()
        {
            IsEnabledProperty.OverrideMetadata(typeof(CanEnableTextBox),
                new UIPropertyMetadata(true,
                    IsEnabledPropertyChanged,
                    CoerceIsEnabled));

        }

        private static void IsEnabledPropertyChanged(DependencyObject source, DependencyPropertyChangedEventArgs args)
        {
            // Overriding PropertyChanged results in merged metadata, which is what we want--
            // the PropertyChanged logic in UIElement.IsEnabled will still get invoked.
        }

        private static object CoerceIsEnabled(DependencyObject source, object value)
        {
            return value;
        }
    }
}
