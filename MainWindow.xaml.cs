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

namespace ITAcadem.CSCourse.Lab1.ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = textin.Text;
            str = str.Replace(",", " y:");
            str = "x:" + str;
            textout.Text = str;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {            
            string line;
            while ((line = Console.ReadLine()) != null)
            {                
                line = line.Replace(",", " y:");
                line = "x:" + line + "\n";
                textout.Text += line;
            }
        }
    }
}
