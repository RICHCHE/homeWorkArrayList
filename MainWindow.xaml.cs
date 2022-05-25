using System;
using System.Collections;
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

namespace homeworkarraylist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList List;
        string allList = "";
        public MainWindow()
        {
            InitializeComponent();
            List = new ArrayList();
        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            List.Add(TxtBox_List.Text);
        }

        private void Show_button_Click(object sender, RoutedEventArgs e)
        {
            foreach (string All_List in List)
            {
                MessageBox.Show(All_List);
            }
        }

        private void Remove_button_Click(object sender, RoutedEventArgs e)
        {
            List.Remove(TxtBox_List.Text);
        }
    }
}
