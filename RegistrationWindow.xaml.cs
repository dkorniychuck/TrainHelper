using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>

    public partial class RegistrationWindow : Window
    {
        ApplicationContext db;
        public RegistrationWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }
        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!Char.IsDigit(c))
                {
                    e.Handled = true; 
                    return;
                }
            }
        }
        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.ToLower().Trim();
            char[] specialCharacters = { '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~' };
            bool containsSpecialCharacter = login.Any(c => specialCharacters.Contains(c));
            User userlogin = db.Users.FirstOrDefault(b => b.Login == login);
            
            if (userlogin != null)
            {
                TextBoxLogin.ToolTip = "Такий логін вже існує, введіть інший або перейіть на сторінку \"Вхід\"";
                TextBoxLogin.BorderBrush = Brushes.DarkRed;
            }
            else
            {
                if (login.Length > 20)
                {
                    TextBoxLogin.ToolTip = "Поле Login має містити менше 20 символів";
                    TextBoxLogin.BorderBrush = Brushes.DarkRed;
                }
                else if (containsSpecialCharacter)
                {
                    TextBoxLogin.ToolTip = "Поле Login не може містити спец символів";
                    TextBoxLogin.BorderBrush = Brushes.DarkRed;
                }
                else if (login.Length < 5)
                {
                    TextBoxLogin.ToolTip = "Поле Login має містити більше 5 символів";
                    TextBoxLogin.BorderBrush = Brushes.DarkRed;
                }
                else if (Char.IsDigit(login[0]))
                {
                    TextBoxLogin.ToolTip = "Поле Login має починатися з букви";
                    TextBoxLogin.BorderBrush = Brushes.DarkRed;
                }
                else if (IsExists(login) == true)
                {
                    TextBoxLogin.ToolTip = "Такий Login вже існує";
                    TextBoxLogin.BorderBrush = Brushes.DarkRed;
                }
                else
                {
                    TextBoxLogin.ToolTip = string.Empty;
                    TextBoxLogin.BorderBrush = Brushes.Transparent;
                    if (string.IsNullOrEmpty(Age_TextBox.Text) || string.IsNullOrEmpty(Weight_TextBox.Text) || string.IsNullOrEmpty(Height_TextBox.Text))
                    {
                        MessageBox.Show("Заповніть усі поля");
                    }
                    else
                    {
                        bool man = Men_Option_Button.IsChecked ?? false;
                        bool woman = Woman_Option_Button.IsChecked ?? false;
                        int age = Convert.ToInt32(Age_TextBox.Text);
                        int weight = Convert.ToInt32(Weight_TextBox.Text);
                        int height = Convert.ToInt32(Height_TextBox.Text);
                        double trainingsCount = 0;
                        bool increase = Increase_Option_Button.IsChecked ?? false;
                        bool save = Save_Option_Button.IsChecked ?? false;
                        bool decrease = Decrease_Option_Button.IsChecked ?? false;
                        ComboBoxItem selectedItem = (ComboBoxItem)CountOfTrainings.SelectedItem;
                        if (man == false && woman == false)
                        {
                            MessageBox.Show("Вкажіть вашу стать");
                        }
                        else
                        {
                            if (age < 18 || age > 99)
                            {
                                Age_TextBox.ToolTip = "Вкажіть коректний вік";
                                Age_TextBox.BorderBrush = Brushes.DarkRed;

                            }
                            else
                            {
                                Age_TextBox.BorderBrush = Brushes.Transparent;
                                if (weight > 200 || weight < 35)
                                {
                                    Weight_TextBox.ToolTip = "Вкажіть коректну вагу";
                                    Weight_TextBox.BorderBrush = Brushes.DarkRed;
                                }
                                else
                                {
                                    Weight_TextBox.BorderBrush = Brushes.Transparent;
                                    if (height > 210 || height < 150)
                                    {
                                        Height_TextBox.ToolTip = "Вкажіть коректний зріст";
                                        Height_TextBox.BorderBrush = Brushes.DarkRed;
                                    }
                                    else
                                    {
                                        Height_TextBox.BorderBrush = Brushes.Transparent;
                                        if (selectedItem == null)
                                        {
                                            MessageBox.Show("Вкажіть вашу кількість навантажень на тиждень");
                                        }
                                        else
                                        {
                                            if (increase == false && save == false && decrease == false)
                                            {
                                                MessageBox.Show("Вкажіть вашу ціль");
                                            }
                                            else
                                            {
                                                string selectedText = selectedItem.Content.ToString();
                                                switch (selectedText[0])
                                                {
                                                    case 'В':
                                                        {
                                                            trainingsCount = 1.2;
                                                            break;
                                                        }
                                                    case '1':
                                                        {
                                                            trainingsCount = 1.38;
                                                            break;
                                                        }
                                                    case '3':
                                                        {
                                                            trainingsCount = 1.55;
                                                            break;
                                                        }
                                                    case '6':
                                                        {
                                                            trainingsCount = 1.73;
                                                            break;
                                                        }
                                                    case '8':
                                                        {
                                                            trainingsCount = 1.9;
                                                            break;
                                                        }
                                                }
                                                string gender = "";
                                                switch (man)
                                                {
                                                    case true:
                                                        {
                                                            gender = "Man";
                                                            break;
                                                        }
                                                }
                                                switch (woman)
                                                {
                                                    case true:
                                                        {
                                                            gender = "Woman";
                                                            break;
                                                        }
                                                }
                                                string goal = "";
                                                switch (increase)
                                                {
                                                    case true:
                                                        {
                                                            goal = "Increase";
                                                            break;
                                                        }
                                                }
                                                switch (save)
                                                {
                                                    case true:
                                                        {
                                                            goal = "Save";
                                                            break;
                                                        }
                                                }
                                                switch (decrease)
                                                {
                                                    case true:
                                                        {
                                                            goal = "Decrease";
                                                            break;
                                                        }
                                                }
                                                CalculateKKal CalcUser = new CalculateKKal(gender, age, weight, height, trainingsCount, goal); // передача даних у клас
                                                double KKal = CalcUser.CaloriesCounter(); // вирахування калорій

                                                string isActive = "true"; // позначення аккаунту як активного

                                                User user = new User(login, gender, isActive, goal, age, weight, height, trainingsCount, KKal); // створення нового користувача
                                                db.Users.Add(user); // додавання користувача у базу даних
                                                db.SaveChanges(); // збереження змін
                                                PersonalAccount_Window personalAccount_Window = new PersonalAccount_Window(); // перехід у вікно персонального аккаунту
                                                personalAccount_Window.Show(); 
                                                this.Close(); // закриття вікна реєстрації
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Button_LogInWindow_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.Show();
            this.Close();
        }
        public bool IsExists(string login)
        {
            List<User> users = db.Users.ToList();
            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
