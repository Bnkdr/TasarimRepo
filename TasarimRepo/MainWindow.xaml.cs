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
        protected int nobkey;
        static Random random = new Random();

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
            lalala.Visibility = Visibility.Hidden;
            lelele.Visibility = Visibility.Hidden;
            panel7but.Visibility = Visibility.Hidden;
            banabas7.Visibility = Visibility.Hidden;
            nobkey = 0;
            nobkey = random.Next(100000, 999999);
            
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
        public int get_nobkey ()
        {
            return nobkey;
        }

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
        

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                ggsınıftxt.Text = "9/A";
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                ggsınıftxt.Text = "9/B";
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                ggsınıftxt.Text = "9/C";
            }
            else if (this.comboBox1.SelectedIndex == 3)
            {
                ggsınıftxt.Text = "9/D";
            }
            else if (this.comboBox1.SelectedIndex == 4)
            {
                ggsınıftxt.Text = "10/A";
            }
            else if (this.comboBox1.SelectedIndex == 5)
            {
                ggsınıftxt.Text = "10/B";
            }
            else if (this.comboBox1.SelectedIndex == 6)
            {
                ggsınıftxt.Text = "10/C";
            }
            else if (this.comboBox1.SelectedIndex == 7)
            {
                ggsınıftxt.Text = "10/D";
            }
            else if (this.comboBox1.SelectedIndex == 8)
            {
                ggsınıftxt.Text = "11/A";
            }
            else if (this.comboBox1.SelectedIndex == 9)
            {
                ggsınıftxt.Text = "11/B";
            }
            else if (this.comboBox1.SelectedIndex == 10)
            {
                ggsınıftxt.Text = "11/C";
            }
            else if (this.comboBox1.SelectedIndex == 11)
            {
                ggsınıftxt.Text = "11/D";
            }
            else if (this.comboBox1.SelectedIndex == 12)
            {
                ggsınıftxt.Text = "12/A";
            }
            else if (this.comboBox1.SelectedIndex == 13)
            {
                ggsınıftxt.Text = "12/B";
            }
            else if (this.comboBox1.SelectedIndex == 14)
            {
                ggsınıftxt.Text = "12/C";
            }
            else if (this.comboBox1.SelectedIndex == 15)
            {
                ggsınıftxt.Text = "12/D";
            }
        }

       

        private void passwordbox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (passwordbox7.Text == key)
            {
                panel7but.Visibility = Visibility.Visible;
                banabas7.Visibility = Visibility.Visible;
            }
        }

        private void passwordCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            lalala.Visibility = Visibility.Visible;
            lelele.Visibility = Visibility.Visible;
            nobkeytxt.Text = (Convert.ToString(nobkey));
        }
    }
}