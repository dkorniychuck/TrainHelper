using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
using System.Windows.Shapes;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        ApplicationContext db;
        public LogInWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_RegWindow_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }

        private void TextBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Authorization();
            }
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            Authorization();
        }

        private void Authorization()
        {
            string login = TextBoxLogin.Text.Trim().ToLower();
            User user = db.Users.FirstOrDefault(b => b.Login == login);
            if (user != null)
            {
                user.isActive = "true";
                db.SaveChanges();
                PersonalAccount_Window personalAccount_Window = new PersonalAccount_Window();
                personalAccount_Window.Show();
                this.Close();
            }
            else
            {
                TextBoxLogin.ToolTip = "Введіть коректний логін";
                TextBoxLogin.BorderBrush = Brushes.DarkRed;
            }
        }
    }
}
