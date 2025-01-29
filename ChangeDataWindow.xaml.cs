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
using System.Windows.Shapes;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для ChangeDataWindow.xaml
    /// </summary>
    public partial class ChangeDataWindow : Window
    {
        ApplicationContext db;
        public ChangeDataWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            User user = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                user = db.Users.Where(b => b.IsActive == "true").FirstOrDefault();
            }
            if (user != null)
            {
                UserLogin.Content = user.Login;
                UserWeight.Content = user.Weight + "кг";
                UserHeight.Content = user.Height + "см";
                UserAge.Content = user.Age + " років";
            }
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

        private void Button_Continue_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Age_TextBox.Text) || string.IsNullOrEmpty(Weight_TextBox.Text) || string.IsNullOrEmpty(Height_TextBox.Text))
            {
                MessageBox.Show("Заповніть усі поля");
            }
            else
            {
                int age = Convert.ToInt32(Age_TextBox.Text);
                int weight = Convert.ToInt32(Weight_TextBox.Text);
                int height = Convert.ToInt32(Height_TextBox.Text);
                double trainingsCount = 0;
                bool increase = Increase_Option_Button.IsChecked ?? false;
                bool save = Save_Option_Button.IsChecked ?? false;
                bool decrease = Decrease_Option_Button.IsChecked ?? false;
                ComboBoxItem selectedItem = (ComboBoxItem)CountOfTrainings.SelectedItem;
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
                                    User user = db.Users.FirstOrDefault(b => b.IsActive == "true");
                                    if (user != null)
                                    {
                                        user.age = age;
                                        user.weight = weight;
                                        user.height = height;
                                        user.trainingsCount = trainingsCount;
                                        user.goal = goal;
                                        CalculateKKal CalcUser = new CalculateKKal(user.gender, user.age, user.weight, user.height, user.trainingsCount, user.goal);
                                        double KKal = CalcUser.CaloriesCounter();
                                        user.KKal = KKal;
                                        db.SaveChanges();

                                        PersonalAccount_Window personalAccount_Window = new PersonalAccount_Window();
                                        personalAccount_Window.Show();
                                        this.Close();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            PersonalAccount_Window personalAccount_Window = new PersonalAccount_Window();
            personalAccount_Window.Show();
            this.Close();
        }
    }
}
