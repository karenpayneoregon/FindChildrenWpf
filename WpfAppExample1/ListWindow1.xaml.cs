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
using WpfAppExample1.Classes;

namespace WpfAppExample1
{
    /// <summary>
    /// Interaction logic for ListWindow1.xaml
    /// </summary>
    public partial class ListWindow1 : Window
    {
        public List<TaskItem> TaskItemsList;
        public ListWindow1()
        {
            InitializeComponent();
            TaskItemsList = new List<TaskItem>();

            DataContext = TaskItemsList;
        }
    }
}
