using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppExample1.Classes;

namespace WpfAppExample1
{
    /// <summary>
    /// Interaction logic for ListWindow1.xaml
    /// </summary>
    public partial class ListWindow1 : Window
    {
        
        public ObservableCollection<TaskItem> TaskItemsList { get; set; }

        public ListWindow1()
        {
            InitializeComponent();

            var taskOperations = new Tasks();
            TaskItemsList = taskOperations.List();

            DataContext = this;
        }

        private void UpdateButtonClick(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedItems.Count != 1) return;

            var currentTask = TaskListBox.SelectedItems[0] as TaskItem;

            TaskItemsList.FirstOrDefault(
                ti => ti.TaskName == currentTask.TaskName).Description = "Changed";

        }
    }
}
