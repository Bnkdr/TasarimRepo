using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Linq;


namespace TasarimRepo
{
   
    public partial class MainWindow : Window
    {
        string key = "3169";
        

        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            panel1.Visibility = Visibility.Visible;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            LabelĞ.Visibility = Visibility.Hidden;
            tiktik.Visibility = Visibility.Hidden;
            panel7but.Visibility = Visibility.Hidden;
            banabas7.Visibility = Visibility.Hidden;
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
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            panel4.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility= Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            panel7.Visibility   = Visibility.Visible;
            panel1.Visibility   = Visibility.Hidden;
            panel2.Visibility   = Visibility.Hidden;
            panel3.Visibility   = Visibility.Hidden;
            panel4.Visibility   = Visibility.Hidden;
            panel5.Visibility   = Visibility.Hidden;  
            panel6.Visibility    = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            panel1.Visibility = Visibility.Visible;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            panel2.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            panel3.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            panel5.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility= Visibility.Hidden;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            panel2.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            panel6.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            LabelĞ.Visibility = Visibility.Visible;
            tiktik.Visibility = Visibility.Visible;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            panel4.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            

        }
        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ( passwordBox7.Text == key)
            {
                panel7but.Visibility = Visibility.Visible;
                banabas7.Visibility = Visibility.Visible;
            }
        }

        

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            panel8.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        private void nöbetcisoyadtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nöbetcisoyad = nöbetcisoyadtxt.Text;
            ggsoyad.Text = nöbetcisoyad;
        }

        private void nöbetcinumaratxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nöbetcinumara = nöbetcinumaratxt.Text;
            ggnumara.Text = nöbetcinumara;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string nöbetciad = nöbetciadtxt.Text;
            ggad.Text = nöbetciad;

        }
    }
}