using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Xml.Linq;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.ComponentModel.Design.Serialization;
using Newtonsoft.Json;
using DataControlApp;
using System.Collections.Generic;
using System.ComponentModel;

namespace TasarimRepo
{

    public partial class MainWindow : Window
    {
        string key = "3169";
        protected int nobkey1;
        protected int nobkey2;
        static Random random = new Random();
        string enteredtext = "0";
        string enteredtext2 = "0";
        public List<Ogrenci> öğrenciler_list;
        public List<Öğretmen> öğretmenler_list;
        public List<İdare> idare_list;

        public IFirebaseClient client;
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "qlDUgLSDUYM1OqcOnlecbAEDhbFWJI8MCMUtZpYU",
            BasePath = "https://kkfldatabase-default-rtdb.europe-west1.firebasedatabase.app"

        };

        
        public IFirebaseClient client2;
        IFirebaseConfig ifc2 = new FirebaseConfig()
        {
            AuthSecret = "qlDUgLSDUYM1OqcOnlecbAEDhbFWJI8MCMUtZpYU",
            BasePath = "https://kkfldatabase-default-rtdb.europe-west1.firebasedatabase.app"

        };

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
            a.Text = "";
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            LabelĞ.Visibility = Visibility.Hidden;
            tiktik.Visibility = Visibility.Hidden;
            lalala1.Visibility = Visibility.Hidden;
            lelele1.Visibility = Visibility.Hidden;
            lalala2.Visibility = Visibility.Hidden;
            lelele2.Visibility = Visibility.Hidden;
            panel7but.Visibility = Visibility.Hidden;
            banabas7.Visibility = Visibility.Hidden;
            panel7but2.Visibility = Visibility.Hidden;
            banabas72.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            hüptür9.Visibility = Visibility.Hidden;
            butoos10.Visibility = Visibility.Hidden;
            banabas10.Visibility = Visibility.Hidden;
            passwordRead.Visibility = Visibility.Hidden;
            passwordRead2.Visibility = Visibility.Hidden;
            panel7butyaz1.Visibility = Visibility.Hidden;
            panel7butyaz2.Visibility = Visibility.Hidden;
            iter431.Visibility = Visibility.Hidden;
            profil1.Visibility = Visibility.Hidden;
            profil2.Visibility = Visibility.Hidden;
            panel431but.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            banabas73.Visibility = Visibility.Hidden;
            veliogradsoyad.Visibility = Visibility.Hidden;
            MİNİKZİYAadsoyad.Visibility = Visibility.Hidden;
            veliogrsınıf.Visibility = Visibility.Hidden;
            combobox2.Visibility = Visibility.Hidden;
            nobkey1 = 0;
            nobkey1 = random.Next(100000, 999999);
            nobkey2 = 0;
            nobkey2 = random.Next(100000, 999999);
            try
            {
                client = new FirebaseClient(ifc);
                client2 = new FirebaseClient(ifc2);
                fetchDataOgretmen(client);
                fetchDataidare(client);
                fetchDataOgrenci(client);

            }
            catch
            {
                MessageBox.Show("there was a problem in your internet");
            }
        }



        public int get_nobkey1()
        {
            return nobkey1;
        }
        public int get_nobkey2()
        {
            return nobkey2;
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
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
            ComboBoxİdare.Items.Clear();
            foreach (var idare in idare_list)
            {

                String adısoaydı = Convert.ToString(idare.idareisim) + " " + Convert.ToString(idare.idaresoyisim);
                ComboBoxİdare.Items.Add(adısoaydı);

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            banabas73.Visibility = Visibility.Hidden;
            banabas72.Visibility = Visibility.Hidden;
            panel7butyaz2.Visibility = Visibility.Hidden;
            panel7butyaz1.Visibility = Visibility.Hidden;
            panel7but.Visibility = Visibility.Hidden;
            panel7but2.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
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
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            comboboxogr.Items.Clear();
            panel2.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
            comboboxogr.Items.Clear();
            foreach (var ogr in öğretmenler_list)
            {

                String adısoaydı = Convert.ToString(ogr.öğretmenisim) + " " + Convert.ToString(ogr.öğretmensoyisim);
                comboboxogr.Items.Add(adısoaydı);

            }

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
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
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
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            comboboxogr.Items.Clear();
            panel2.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
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
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
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
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            panel5.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";

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
            panel9.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
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
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
        }


        private void nöbetcisoyadtxt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nöbetci1soyad = nöbetcisoyadtxt1.Text;
            ggsoyad1.Text = nöbetci1soyad;
            nöbsoyisim1.Text = nöbetci1soyad;
        }

        private void nöbetcinumaratxt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nöbetci1numara = nöbetcinumaratxt1.Text;
            ggnumara1.Text = nöbetci1numara;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string nöbetci1ad = nöbetciadtxt1.Text;
            ggad1.Text = nöbetci1ad;
            nöbisim1.Text = nöbetci1ad;
        }
        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            string nöbetci2ad = nöbetciadtxt2.Text;
            ggad2.Text = nöbetci2ad;
            nöbisim2.Text = nöbetci2ad;
        }


        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
            lalala1.Visibility = Visibility.Visible;
            lelele1.Visibility = Visibility.Visible;
            nobkeytxt1.Text = (Convert.ToString(nobkey1));

            string selectedClass = comboBox1.SelectedItem.ToString();

            SentrySave(client, client2, "1", nobkey1, nöbetciadtxt1.Text, nöbetcisoyadtxt1.Text, nöbetcinumaratxt1.Text, selectedClass);
        }



        private void keytext9_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (keytext9.Text == Convert.ToString(nobkey1))
            {
                butos9.Visibility = Visibility.Visible;
                hüptür9.Visibility = Visibility.Visible;
                
            }
            if (keytext9.Text == Convert.ToString(nobkey2))
            {
                butos9.Visibility = Visibility.Visible;
                hüptür9.Visibility = Visibility.Visible;
            }


        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            panel9.Visibility = Visibility.Visible;
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
            panel11.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            panel7.Visibility = Visibility.Visible;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel10.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
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
            butos9.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
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
                banabas73.Visibility = Visibility.Visible;
                panel7butyaz1.Visibility = Visibility.Visible;
                panel7butyaz2.Visibility = Visibility.Visible;
            }
        }

        private void ZİYAadsoyad_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ziyaisim = ZİYAadsoyad.Text;
            ayizadsoyad.Text = ziyaisim;
        }

        private void MİNİKZİYAadsoyad_TextChanged(object sender, TextChangedEventArgs e)
        {
            string minikziyaisim = MİNİKZİYAadsoyad.Text;
            minikayizadsoyad.Text = minikziyaisim;
        }

        private void ZİYATÜR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.combobox2.SelectedIndex == 0)
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
                ayiztür.Text = "12/D";
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            butoos10.Visibility = Visibility.Visible;
            banabas10.Visibility = Visibility.Visible;



            /*ZİYAadsoyad
                SwitchBox
                MinikZiya
                Combobox2*/
        }

        private void panel11_Click(object sender, RoutedEventArgs e)
        {
            panel11.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
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
            butos9.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            if (this.comboBox2.SelectedIndex == 0)
            {
                ggsınıftxt2.Text = "9/A";
            }
            else if (this.comboBox2.SelectedIndex == 1)
            {
                ggsınıftxt2.Text = "9/B";
            }
            else if (this.comboBox2.SelectedIndex == 2)
            {
                ggsınıftxt2.Text = "9/C";
            }
            else if (this.comboBox2.SelectedIndex == 3)
            {
                ggsınıftxt2.Text = "9/D";
            }
            else if (this.comboBox2.SelectedIndex == 4)
            {
                ggsınıftxt2.Text = "10/A";
            }
            else if (this.comboBox2.SelectedIndex == 5)
            {
                ggsınıftxt2.Text = "10/B";
            }
            else if (this.comboBox2.SelectedIndex == 6)
            {
                ggsınıftxt2.Text = "10/C";
            }
            else if (this.comboBox2.SelectedIndex == 7)
            {
                ggsınıftxt2.Text = "10/D";
            }
            else if (this.comboBox2.SelectedIndex == 8)
            {
                ggsınıftxt2.Text = "11/A";
            }
            else if (this.comboBox2.SelectedIndex == 9)
            {
                ggsınıftxt2.Text = "11/B";
            }
            else if (this.comboBox2.SelectedIndex == 10)
            {
                ggsınıftxt2.Text = "11/C";
            }
            else if (this.comboBox2.SelectedIndex == 11)
            {
                ggsınıftxt2.Text = "11/D";
            }
            else if (this.comboBox2.SelectedIndex == 12)
            {
                ggsınıftxt2.Text = "12/A";
            }
            else if (this.comboBox2.SelectedIndex == 13)
            {
                ggsınıftxt2.Text = "12/B";
            }
            else if (this.comboBox2.SelectedIndex == 14)
            {
                ggsınıftxt2.Text = "12/C";
            }
            else if (this.comboBox2.SelectedIndex == 15)
            {
                ggsınıftxt2.Text = "12/D";
            }
        }

        private void nöbetcisoyadtxt2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nöbetci2soyad = nöbetcisoyadtxt2.Text;
            ggsoyad2.Text = nöbetci2soyad;
            nöbsoyisim2.Text = nöbetci2soyad;

        }

        private void nöbetcinumaratxt2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nöbetci2numara = nöbetcinumaratxt2.Text;
            ggnumara2.Text = nöbetci2numara;
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(combobox2.SelectedIndex == 0)
            {

            }
        }

        Nöbetçi nöbetçi;
        async void SentrySave(IFirebaseClient client, IFirebaseClient client2, string sirano,int nöbkey,string nöbetciadtxt,string nöbetcisoyadtxt, string nobetcinumaratxt,string nobetcisınıftxt)
        {
            DateTimeConverter dtc = new DateTimeConverter();

            nöbetçi = new Nöbetçi(nöbkey, nöbetciadtxt,nöbetcisoyadtxt, nobetcisınıftxt,nobetcinumaratxt, sirano);

            string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
            string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
            string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
            string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
            string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
            string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);

            await client.SetAsync($"SentryList/{(gün + " " + ay + " " + yıl)}/{sirano}", nöbetçi);
            await client2.SetAsync($"SentryList/{(gün + " " + ay + " " + yıl)}" + ("/" + saat + " " + dakika + " " + saniye)+sirano, nöbetçi);

        }

        private void Button_Click_panel8_1(object sender, RoutedEventArgs e)
        {
            lalala2.Visibility = Visibility.Visible;
            lelele2.Visibility = Visibility.Visible;
            nobkeytxt2.Text = Convert.ToString(nobkey2);

            string selectedClass = comboBox3.SelectedValue.ToString();

            SentrySave(client, client2,"2", nobkey2,nöbetciadtxt2.Text,nöbetcisoyadtxt2.Text,nöbetcinumaratxt2.Text,selectedClass);

        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            banabas73.Visibility = Visibility.Hidden;
            banabas72.Visibility = Visibility.Hidden;
            panel7butyaz2.Visibility = Visibility.Hidden;
            panel7butyaz1.Visibility = Visibility.Hidden;
            panel7but.Visibility = Visibility.Hidden;
            panel7but2.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";

        }
        
        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            panel7.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            banabas73.Visibility = Visibility.Hidden;
            banabas72.Visibility = Visibility.Hidden;
            panel7butyaz2.Visibility = Visibility.Hidden;
            panel7butyaz1.Visibility = Visibility.Hidden;
            panel7but.Visibility = Visibility.Hidden;
            panel7but2.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";

        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            panel12.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";

        }



        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            panel12numara.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";

        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            panel12isim.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";

        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            panel12.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
            panel12numaratxt.Text = "";
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            panel12.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
            panel12adtxt.Text = "";
            panel12soyadtxt.Text = "";

        }

        private void panel13txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (panel431txt.Text == key)
            {
                panel431but.Visibility = Visibility.Visible;
                iter431.Visibility = Visibility.Visible;
            }
        }



        private void panel13but_Click(object sender, RoutedEventArgs e)
        {
            panel13_1.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel13.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            panel13.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            panel13.Visibility = Visibility.Visible;
            panel10.Visibility = Visibility.Hidden;
            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
            panel3.Visibility = Visibility.Hidden;
            panel4.Visibility = Visibility.Hidden;
            panel5.Visibility = Visibility.Hidden;
            panel6.Visibility = Visibility.Hidden;
            panel7.Visibility = Visibility.Hidden;
            panel8_1.Visibility = Visibility.Hidden;
            panel8.Visibility = Visibility.Hidden;
            panel11.Visibility = Visibility.Hidden;
            panel12.Visibility = Visibility.Hidden;
            panel12isim.Visibility = Visibility.Hidden;
            panel12numara.Visibility = Visibility.Hidden;
            panel13_1.Visibility = Visibility.Hidden;
            panel9.Visibility = Visibility.Hidden;
            butos9.Visibility = Visibility.Hidden;
            keytext9.Text = "";
            a.Text = "";
        }
        private void fetchDataOgrenci(IFirebaseClient client)
        {
            FirebaseResponse res = client.Get(@"StudentList");
            Dictionary<string, Ogrenci> data = JsonConvert.DeserializeObject<Dictionary<string, Ogrenci>>(res.Body.ToString());
            öğrenciler_list = new List<Ogrenci>(data.Values);
        }
        private void fetchDataOgretmen(IFirebaseClient client)
        {
            FirebaseResponse res = client.Get(@"TeacherList");
            Dictionary<string, Öğretmen> data = JsonConvert.DeserializeObject<Dictionary<string, Öğretmen>>(res.Body.ToString());
            öğretmenler_list = new List<Öğretmen>(data.Values);
        }
        private void fetchDataidare(IFirebaseClient client)
        {
            FirebaseResponse res = client.Get(@"AdministrationList");
            Dictionary<string, İdare> data = JsonConvert.DeserializeObject<Dictionary<string, İdare>>(res.Body.ToString());
            idare_list = new List<İdare>(data.Values);
        }

        private void Button_Click_431(object sender, RoutedEventArgs e)
        {
            if (passwordRead2.Visibility == Visibility.Hidden)
            {
                passwordRead2.Visibility = Visibility.Visible;
                //a.FontFamily = "#password";
            }
            else
            {
                passwordRead2.Visibility = Visibility.Hidden;
            }

        }

        private void panel431txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (panel431txt.Text == key)
            {
                panel431but.Visibility = Visibility.Visible;
                iter431.Visibility = Visibility.Visible;
            }
            enteredtext2 = panel431txt.Text;
            passwordRead2.Text = enteredtext2;
        }

        private void SwitchBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SwitchBox_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void panel12adtxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void panel12soyadtxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void SearchOgrenciByNameAndSurname(String name, String surname)
        {
            foreach (Ogrenci o in öğrenciler_list)
            {
                if (name.ToLower().Equals(o.isim.ToLower()) && surname.ToLower().Equals(o.soyisim.ToLower()))
                {
                    string ismi = Convert.ToString(o.isim);
                    string soyismi = Convert.ToString(o.soyisim);
                    string numarasi = Convert.ToString(o.numara);
                    string sinifi = Convert.ToString(o.sınıf);
                    string şubesi = Convert.ToString(o.şube);
                    panel12adson.Text = ismi;
                    panel12soyadson.Text = soyismi;
                    panel12numson.Text = numarasi;
                    panel12sınıfson.Text = sinifi;
                    panel12subeson.Text = şubesi;
                }
            }

        }
        public void SearchOgrenciByNum(String numara)
        {
            foreach (Ogrenci o in öğrenciler_list)
            {
                if (numara.ToLower().Equals(Convert.ToString(o.numara).ToLower()))
                {
                    string ismi = Convert.ToString(o.isim);
                    string soyismi = Convert.ToString(o.soyisim);
                    string numarasi = Convert.ToString(o.numara);
                    string sinifi = Convert.ToString(o.sınıf);
                    string şubesi = Convert.ToString(o.şube);
                    panel12adson2.Text = ismi;
                    panel12soyadson2.Text = soyismi;
                    panel12numson2.Text = numarasi;
                    panel12sınıfson2.Text = sinifi;
                    panel12subeson2.Text = şubesi;
                }
            }

        }

        private void searchNameSurname_Click(object sender, RoutedEventArgs e)
        {
                SearchOgrenciByNameAndSurname(panel12adtxt.Text.ToLower(), panel12soyadtxt.Text.ToLower());
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            SearchOgrenciByNum(panel12numaratxt.Text.ToLower());
        }

        private void SwitchBox_Click_1(object sender, RoutedEventArgs e)
        {
            if (veliogradsoyad.Visibility == Visibility.Hidden)
            {
                veliogradsoyad.Visibility = Visibility.Visible;
                MİNİKZİYAadsoyad.Visibility = Visibility.Visible;
                veliogrsınıf.Visibility = Visibility.Visible;
                combobox2.Visibility = Visibility.Visible;
            }
            else
            {
                veliogradsoyad.Visibility = Visibility.Hidden;
                MİNİKZİYAadsoyad.Visibility = Visibility.Hidden;
                veliogrsınıf.Visibility = Visibility.Hidden;
                combobox2.Visibility = Visibility.Hidden;
            }   
        }

        private void ComboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (this.comboBox3.SelectedIndex == 0)
            {
                ggsınıftxt2.Text = "9/A";
            }
            else if (this.comboBox3.SelectedIndex == 1)
            {
                ggsınıftxt1.Text = "9/B";
            }
            else if (this.comboBox3.SelectedIndex == 2)
            {
                ggsınıftxt1.Text = "9/C";
            }
            else if (this.comboBox3.SelectedIndex == 3)
            {
                ggsınıftxt1.Text = "9/D";
            }
            else if (this.comboBox3.SelectedIndex == 4)
            {
                ggsınıftxt1.Text = "10/A";
            }
            else if (this.comboBox3.SelectedIndex == 5)
            {
                ggsınıftxt1.Text = "10/B";
            }
            else if (this.comboBox3.SelectedIndex == 6)
            {
                ggsınıftxt1.Text = "10/C";
            }
            else if (this.comboBox3.SelectedIndex == 7)
            {
                ggsınıftxt1.Text = "10/D";
            }
            else if (this.comboBox3.SelectedIndex == 8)
            {
                ggsınıftxt1.Text = "11/A";
            }
            else if (this.comboBox3.SelectedIndex == 9)
            {
                ggsınıftxt1.Text = "11/B";
            }
            else if (this.comboBox3.SelectedIndex == 10)
            {
                ggsınıftxt1.Text = "11/C";
            }
            else if (this.comboBox3.SelectedIndex == 11)
            {
                ggsınıftxt1.Text = "11/D";
            }
            else if (this.comboBox3.SelectedIndex == 12)
            {
                ggsınıftxt1.Text = "12/A";
            }
            else if (this.comboBox3.SelectedIndex == 13)
            {
                ggsınıftxt1.Text = "12/B";
            }
            else if (this.comboBox3.SelectedIndex == 14)
            {
                ggsınıftxt1.Text = "12/C";
            }
            else if (this.comboBox3.SelectedIndex == 15)
            {
                ggsınıftxt1.Text = "12/D";
            }
        }
    }
}

