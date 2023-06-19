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

namespace RussianCosmetic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string expectedUsername = "admin";
        private string expectedPassword = "admin";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void VhodBtn_Click(object sender, RoutedEventArgs e)
        {
            string enteredUsername = LoginBox.Text;
            string enteredPassword = PassBox.Password;
            var stWin = new StandartWindow();

            if (enteredUsername == expectedUsername && enteredPassword == expectedPassword)
            {
                MessageBox.Show("Авторизация прошла успешно!");
                Close();
                stWin.Show();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль. Попробуйте ещё раз.");
            }

        }
    }
}
