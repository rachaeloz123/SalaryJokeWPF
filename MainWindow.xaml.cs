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

namespace SalaryJokeWPF
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

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hey! You weren't supposed to click this !");
        }

        private void Button_Click(object sender, RoutedEventArgs e)   
        {
            MessageBox.Show("Great! Have a nice day!");
            Environment.Exit(0);
        }
        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            var pspst = new Random();
            AppWindow.Top = pspst.Next(750);
            AppWindow.Left = pspst.Next(750);
        }
    }
}
