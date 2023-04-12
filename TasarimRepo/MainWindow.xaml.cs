using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Linq;

namespace TasarimRepo
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }
        #region
        //private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (e.ChangedButton == MouseButton.Left)
        //    {
        //        this.DragMove();
        //    }
        //}
        //private bool IsMaximized = false;
        //private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (e.ClickCount == 2)
        //    {
        //        if (IsMaximized)
        //        {
        //            this.WindowState = WindowState.Normal;
        //            this.Width = 1080;
        //            this.Height = 720;
        //
        //            IsMaximized = false;
        //        }
        //        else
        //        {
        //            this.WindowState = WindowState.Maximized;
        //
        //
        //            IsMaximized = true;
        //        }
        //    }
        //}
        #endregion
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            panel2.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            panel1.Visibility = Visibility.Visible;
            panel2.Visibility = Visibility.Hidden;
        }
    }
}