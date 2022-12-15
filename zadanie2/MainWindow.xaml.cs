using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace zadanie2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = txt1.Text;
            string password = txt2.Text;
            string[] lines = File.ReadAllLines(@"C:\Users\tupae\OneDrive\Рабочий стол\ооп\zadanie2\txt.txt");
            for (int i = 0; i < lines.Length; i++)
            { 
                string[] logincheck = lines[i].Split(':');
                if (logincheck[0] == login)
                {
                    MessageBox.Show("Такой логин есть");
                    return;
                }
            }
            var regex2 = new Regex(@"([a-zA-Z])");
            var regex1 = new Regex(@"([0,1,2,3,4,5,6,7,8,9])");
            var regex3 = new Regex(@"([!,@,#,$,%,^,&,*,?,_,~])");
            if (password.Length >= 8 && regex1.IsMatch(password) && regex2.IsMatch(password) && regex3.IsMatch(password))
                MessageBox.Show("Ты зарегестрирован!");
            
            else
            {
                MessageBox.Show("Пароль не безопасен");
                return;
            }
            StreamWriter sw = new StreamWriter(@"C:\\Users\\tupae\\OneDrive\\Рабочий стол\\ооп\\zadanie2\\txt.txt", true);
            sw.WriteLine(login + ":" + password);
            sw.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string login = txt1.Text;
            string password = txt2.Text;
            string[] lines = File.ReadAllLines(@"C:\Users\tupae\OneDrive\Рабочий стол\ооп\zadanie2\txt.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] logincheck = lines[i].Split(':');
                if (logincheck[0] == login && logincheck[1] ==  password)
                {
                    MessageBox.Show("Ты зашел!");
                    return;
                }
            }
            MessageBox.Show("Не верный логин или пароль!");
        }
    }
}
