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
    public partial class RadioButtonWindow : Window
    {
        public RadioButtonWindow()
        {
            InitializeComponent();
        }

        private void GetCheckedRadioButtons_Click(object sender, RoutedEventArgs e)
        {
            var frmAllGroupsResults = Stacker1.RadioListAreChecked();

            if (frmAllGroupsResults.Any())
            {
                var stringBuilder = new StringBuilder();
                foreach (var rb in frmAllGroupsResults)
                {
                    stringBuilder.AppendLine(rb.Content.ToString());
                }

                MessageBox.Show(stringBuilder.ToString());
            }
            else
            {
                MessageBox.Show("None selected");
            }
        }
        /// <summary>
        /// Get selected RadioButton in a specific group
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetCheckedRadioButtonsByGroupName_Click(object sender, RoutedEventArgs e)
        {
            var selectedOperatingSystem = Stacker1
                .SelectedRadioButtonInGroup("OperatingSystemGroup");

            MessageBox.Show($"Operating system is {selectedOperatingSystem.Content}");
        }
    }
}
