using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using WpfAppExample1.Classes;

namespace WpfAppExample1
{

    public partial class SelectiveReadOnlyWindow : Window
    {
        private readonly MockedData _mockedData = new MockedData();

        public SelectiveReadOnlyWindow()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            var verifyTextBox = this.EnableFirst<TextBox>();
            if (verifyTextBox !=null)
            {
                FocusManager.SetFocusedElement(this, verifyTextBox);
            }
        }

        private void InviteCodeButton_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox) sender).Text)) return;

            var person = _mockedData.FindPerson(Convert.ToInt32(((TextBox) sender).Text));

            /*
             * -1 means the person was not located
             */
            if (person.Id > -1)
            {
                // Enabling group enables child controls
                GroupGrid.IsEnabled = true;

                // This will automatically select the first control in the tab order
                MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));

                FirstNameTextBox.Text = person.FirstName;
                LastNameTextBox.Text = person.LastName;

                FirstNameTextBox.Select(person.FirstName.Length, 0);
            }
            else
            {
                GroupGrid.IsEnabled = false;
            }
        }
        /// <summary>
        /// This is were the verification process would be completed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitted");
        }
    }
}
