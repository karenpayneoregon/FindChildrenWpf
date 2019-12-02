using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppExample1
{
    /// <summary>
    /// Interaction logic for SelectiveReadOnlyWindow.xaml
    /// </summary>
    public partial class SelectiveReadOnlyWindow : Window
    {
        public SelectiveReadOnlyWindow()
        {
            InitializeComponent();
        }

        private void InviteCodeButton_TextChanged(object sender, TextChangedEventArgs e)
        {
            var userText = ((TextBox) sender).Text;
            if (int.TryParse(userText, out var code))
            {
                if (code == 123)
                {
                    GroupGrid.IsEnabled = true;
                    //CodeImage.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
