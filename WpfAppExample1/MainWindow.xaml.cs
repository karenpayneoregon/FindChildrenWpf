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
using WpfAppExample1.Classes;
using WpfAppExample1.Extensions;
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

            var modView = new MainViewModel()
            {
                Quarter = new Quarter()
                {
                    Month01 = 1, Month02 = 2, Month03 = 3, Month04 = 4, Month05 =5, Month06 = 6,
                    Month07 = 7, Month08 = 8, Month09 = 9, Month10 = 10, Month11 = 0, Month12 = 33, HeaderInfo = new HeaderInfo() { TaxRatesField = 3}
                }
            };
            DataContext = modView;


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
            GridStackPanel.EnableCheckBoxes();
        }

        private void EnableCheckBoxButton_Click(object sender, RoutedEventArgs e)
        {
            GridStackPanel.EnableCheckBoxes(true);
        }
    }
}
