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

namespace MfdMapper
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

        private void HideText()
        {
            t1.Visibility = Visibility.Hidden;
            t2.Visibility = Visibility.Hidden;
            t3.Visibility = Visibility.Hidden;
            t4.Visibility = Visibility.Hidden;
            t5.Visibility = Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HideText();
            t2.Visibility = Visibility.Visible;
            t4.Visibility = Visibility.Visible;
            TextAction.Text = "Выбрано меню 2";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HideText();
            t1.Visibility = Visibility.Visible;
            t3.Visibility = Visibility.Visible;
            t5.Visibility = Visibility.Visible;
            TextAction.Text = "Выбрано меню 3";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextAction.Text = "Действие 1 выполнено";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextAction.Text = "Действие 3 выполнено";

        }
    }
}
