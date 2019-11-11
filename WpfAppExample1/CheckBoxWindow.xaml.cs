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
using ExtensionMethods;

namespace WpfAppExample1
{
    public partial class CheckBoxWindow : Window
    {
        public CheckBoxWindow()
        {
            InitializeComponent();
        }

        private void GetCheckedButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxGrid.CheckListAnyChecked())
            {
                var result = string.Join("\n",CheckBoxGrid.CheckBoxListChecked().Select(cb => cb.Content.ToString()).ToArray());
                MessageBox.Show($"Selected languages\n{result}");

            }
        }
    }
}
