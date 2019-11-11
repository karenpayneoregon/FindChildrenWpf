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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExtensionMethods;
using WpfAppExample1.Classes;
//using WpfAppExample1.Extensions;
using WpfAppExample1.Model;


namespace WpfAppExample1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            WindowStyle = WindowStyle.ToolWindow;

        }

        private bool _shown;

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);

            if (_shown)
            {
                return;
            }

            _shown = true;

            GridStackPanel.SetTextBoxUniversalWidth<StackPanel>();

        }
        private void DisableTextBoxesButton_Click(object sender, RoutedEventArgs e)
        {
            GridStackPanel.EnableTextBoxes<StackPanel>(true);
        }

        private void EnableTextBoxesButton_Click(object sender, RoutedEventArgs e)
        {
            GridStackPanel.EnableTextBoxes<StackPanel>(false);
        }

        private void DisableCheckBoxButton_Click(object sender, RoutedEventArgs e)
        {
            GridStackPanel.EnableCheckBoxesSpecial(false, "ToggleCheckBox");
        }

        private void EnableCheckBoxButton_Click(object sender, RoutedEventArgs e)
        {
            GridStackPanel.EnableCheckBoxes(true);
        }

        private void ToggleCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            GridStackPanel.EnableCheckBoxesSpecial(true, "ToggleCheckBox");
        }

        private void ToggleCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            GridStackPanel.EnableCheckBoxesSpecial(false, "ToggleCheckBox");
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
