﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Xml.Linq;


namespace TasarimRepo
{
   
    public partial class MainWindow : Window
    {
        string key = "3169";
        protected int nobkey;
        static Random random = new Random();
        string enteredtext = "0";




        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            panel1.Visibility    = Visibility.Visible;
            panel2.Visibility    = Visibility.Hidden;
            panel3.Visibility    = Visibility.Hidden;
            panel4.Visibility    = Visibility.Hidden;
            panel5.Visibility    = Visibility.Hidden;
            panel6.Visibility    = Visibility.Hidden;
            panel7.Visibility    = Visibility.Hidden;
            panel8.Visibility    = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility    = Visibility.Hidden;
            panel10.Visibility   = Visibility.Hidden;
            panel11.Visibility    = Visibility.Hidden;
            LabelĞ.Visibility    = Visibility.Hidden;
            tiktik.Visibility    = Visibility.Hidden;
            lalala.Visibility    = Visibility.Hidden;
            lelele.Visibility    = Visibility.Hidden;
            panel7but.Visibility = Visibility.Hidden;
            banabas7.Visibility  = Visibility.Hidden;
            panel7but2.Visibility = Visibility.Hidden;
            banabas72.Visibility = Visibility.Hidden;
            butos9.Visibility    = Visibility.Hidden;
            hüptür9.Visibility   = Visibility.Hidden;
            butoos10.Visibility = Visibility.Hidden;
            banabas10.Visibility = Visibility.Hidden;
            passwordRead.Visibility = Visibility.Hidden;
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
            panel4.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel2.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            panel7.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel2.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;  
            panel6.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            panel1.Visibility  = Visibility.Visible;
            panel2.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            panel2.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            panel3.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel2.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            panel5.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel2.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            panel2.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            panel6.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel2.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            LabelĞ.Visibility = Visibility.Visible;
            tiktik.Visibility = Visibility.Visible;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            panel4.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel2.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility  = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }
 
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            

        }
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            panel8.Visibility = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel2.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }
        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            panel8_1.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }


        private void nöbetcisoyadtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nöbetcisoyad = nöbetcisoyadtxt1.Text;
            ggsoyad1.Text = nöbetcisoyad;
            nöbsoyisim1.Text = nöbetcisoyad;
        }

        private void nöbetcinumaratxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nöbetcinumara = nöbetcinumaratxt1.Text;
            ggnumara1.Text = nöbetcinumara;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string nöbetciad = nöbetciadtxt1.Text;
            ggad1.Text = nöbetciad;
            nöbisim1.Text=nöbetciad;
        }
        


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                ggsınıftxt1.Text = "9/A";
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                ggsınıftxt1.Text = "9/B";
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                ggsınıftxt1.Text = "9/C";
            }
            else if (this.comboBox1.SelectedIndex == 3)
            {
                ggsınıftxt1.Text = "9/D";
            }
            else if (this.comboBox1.SelectedIndex == 4)
            {
                ggsınıftxt1.Text = "10/A";
            }
            else if (this.comboBox1.SelectedIndex == 5)
            {
                ggsınıftxt1.Text = "10/B";
            }
            else if (this.comboBox1.SelectedIndex == 6)
            {
                ggsınıftxt1.Text = "10/C";
            }
            else if (this.comboBox1.SelectedIndex == 7)
            {
                ggsınıftxt1.Text = "10/D";
            }
            else if (this.comboBox1.SelectedIndex == 8)
            {
                ggsınıftxt1.Text = "11/A";
            }
            else if (this.comboBox1.SelectedIndex == 9)
            {
                ggsınıftxt1.Text = "11/B";
            }
            else if (this.comboBox1.SelectedIndex == 10)
            {
                ggsınıftxt1.Text = "11/C";
            }
            else if (this.comboBox1.SelectedIndex == 11)
            {
                ggsınıftxt1.Text = "11/D";
            }
            else if (this.comboBox1.SelectedIndex == 12)
            {
                ggsınıftxt1.Text = "12/A";
            }
            else if (this.comboBox1.SelectedIndex == 13)
            {
                ggsınıftxt1.Text = "12/B";
            }
            else if (this.comboBox1.SelectedIndex == 14)
            {
                ggsınıftxt1.Text = "12/C";
            }
            else if (this.comboBox1.SelectedIndex == 15)
            {
                ggsınıftxt1.Text = "12/D";
            }
        }

       


        private void passwordCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            
            lalala.Visibility = Visibility.Visible;
            lelele.Visibility = Visibility.Visible;
            nobkeytxt1.Text = (Convert.ToString(nobkey));
            
        }

        

        private void keytext9_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ( keytext9.Text == Convert.ToString(nobkey))
            {
                butos9.Visibility  = Visibility.Visible;
                hüptür9.Visibility = Visibility.Visible;
            }
            
          
            
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            panel9.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel2.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel7.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            panel7.Visibility  = Visibility.Visible;
            panel1.Visibility  = Visibility.Hidden;
            panel2.Visibility  = Visibility.Hidden;
            panel3.Visibility  = Visibility.Hidden;
            panel4.Visibility  = Visibility.Hidden;
            panel5.Visibility  = Visibility.Hidden;
            panel6.Visibility  = Visibility.Hidden;
            panel8.Visibility  = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility  = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void butos9_Click(object sender, RoutedEventArgs e)
        {
            panel10.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            if (passwordRead.Visibility == Visibility.Hidden)
            {
                passwordRead.Visibility = Visibility.Visible;
                //a.FontFamily = "#password";
            }
            else
            {
                passwordRead.Visibility = Visibility.Hidden;
            }
 
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            enteredtext = a.Text;
            passwordRead.Text = enteredtext;
            

            if (a.Text == key)
            {
                panel7but.Visibility = Visibility.Visible;
                banabas7.Visibility = Visibility.Visible;
                panel7but2.Visibility = Visibility.Visible;
                banabas72.Visibility = Visibility.Visible;
            }
        }

        private void ZİYAadsoyad_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ziyaisim = ZİYAadsoyad.Text;
            ayizadsoyad.Text = ziyaisim;
        }

        private void MİNİKZİYAadsoyad_TextChanged(object sender, TextChangedEventArgs e)
        {
            string minikziyaisim = MİNİKZİYAadsoyad .Text;
            minikayizadsoyad.Text = minikziyaisim;
        }

        private void ZİYATÜR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(this.combobox2.SelectedIndex == 0) 
            {
                ayiztür.Text = "9/A";
            }
            else if (this.combobox2.SelectedIndex == 1)
            {
                ayiztür.Text = "9/B";
            }
            else if (this.combobox2.SelectedIndex == 2)
            {
                ayiztür.Text = "9/C";
            }
            else if (this.combobox2.SelectedIndex == 3)
            {
                ayiztür.Text = "9/D";
            }
            else if (this.combobox2.SelectedIndex == 4)
            {
                ayiztür.Text = "10/A";
            }
            else if (this.combobox2.SelectedIndex == 5)
            {
                ayiztür.Text = "10/B";
            }
            else if (this.combobox2.SelectedIndex == 6)
            {
                ayiztür.Text = "10/C";
            }
            else if (this.combobox2.SelectedIndex == 7)
            {
                ayiztür.Text = "10/D";
            }
            else if (this.combobox2.SelectedIndex == 8)
            {
                ayiztür.Text = "11/A";
            }
            else if (this.combobox2.SelectedIndex == 9)
            {
                ayiztür.Text = "11/B";
            }
            else if (this.combobox2.SelectedIndex == 10)
            {
                ayiztür.Text = "11/C";
            }
            else if (this.combobox2.SelectedIndex == 11)
            {
                ayiztür.Text = "11/D";
            }
            else if (this.combobox2.SelectedIndex == 12)
            {
                ayiztür.Text = "12/A";
            }
            else if (this.combobox2.SelectedIndex == 13)
            {
                ayiztür.Text = "12/B";
            }
            else if (this.combobox2.SelectedIndex == 14)
            {
                ayiztür.Text = "12/C";
            }
            else if (this.combobox2.SelectedIndex == 15)
            {
                ayiztür.Text = "9/B";
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            butoos10.Visibility = Visibility.Visible;
            banabas10.Visibility= Visibility.Visible;
        }

        private void panel11_Click(object sender, RoutedEventArgs e)
        {
            panel11.Visibility = Visibility.Visible;
            panel9.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
        }
    }
    }
