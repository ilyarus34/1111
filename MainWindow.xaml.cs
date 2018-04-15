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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        Stack<byte[]> save = new Stack<byte[]>();
        byte[] str = new byte[3];
        public bool Check = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           


        }


        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {
           
           string g;
            if (Check == true)
            {
                
                
                Class1.Random1(str,Check);
                text1.Text = str[0].ToString();
                text2.Text = str[1].ToString();
                text3.Text = str[2].ToString();
                save.Push(str);

            }
            if (Check== false)
            {
                
                string[] line1 = new string[3];
                int i = 0;
                while(i<line1.Length)
                {
                byte[] msg1 = new byte[3];
                
                Class1.Random1(msg1, Check);
                g = Convert.ToChar(msg1[2]).ToString();

                line1[i]= Convert.ToChar(msg1[0]).ToString() + Convert.ToChar(msg1[1]).ToString() + Convert.ToChar(msg1[2]).ToString();
                i++;
                }
                text1.Text = line1[0];
                text2.Text = line1[1];
                text3.Text = line1[2];
             

            }



        }
        private void IntButton_Click(object sender, RoutedEventArgs e)
        {
           Check = true;
            if (Check == true)
            {
                IntButton.Background = new SolidColorBrush(Colors.Blue);
                StringButton.Background = new SolidColorBrush(Colors.Gray);
            }
        }

        private void StringButton_Click(object sender, RoutedEventArgs e)
        {
            Check = false;
            if (Check == false)
            {


                IntButton.Background = new SolidColorBrush(Colors.LightGray);
                StringButton.Background = new SolidColorBrush(Colors.Blue);
            }

        }

        private void RandomButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (save.Count > 0)
            {
                byte[] b = new byte[3];
                b = save.Pop();
                text1.Text = b[0].ToString();
                text2.Text = b[1].ToString();
                text3.Text = b[2].ToString();
            }
           
        }
    }
}
