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

namespace Databinding_WPF_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<ToDo> myTodoList = new List<ToDo>();
            myTodoList.Add(new ToDo("09-08-2020",  "wash the dishes", "Mircea:"));
            cmbToDo.ItemsSource = myTodoList;

            myTodoList.Add(new ToDo("09-09-2022", "walk the dog", "Andreea"));

        }
    }
}
