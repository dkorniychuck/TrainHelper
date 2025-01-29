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
    /// Логика взаимодействия для PersonalAccount_Window.xaml
    /// </summary>
    public partial class PersonalAccount_Window : Window
    {
        ApplicationContext db;
        public PersonalAccount_Window()
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
                UserLogin.Content = user.Login.ToUpper();
                UserWeight.Content = user.Weight + "кг";
                UserHeight.Content = user.Height + "см";
                UserAge.Content = user.Age + " років";
                UserKKal.Content = user.KKal.ToString().Substring(0, 4) + "ккал";
            }
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            User user = db.Users.FirstOrDefault(b => b.IsActive == "true");
            if (user != null)
            {
                UserLogin.Content = "";
                UserWeight.Content = "";
                UserHeight.Content = "";
                UserAge.Content = "";
                UserKKal.Content = "";
                user.isActive = "false";
                db.SaveChanges();
            }
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.Show();
            this.Close();
        }

        private void Button_TrainsExample_Click(object sender, RoutedEventArgs e)
        {
            ExampleExercisesWindow exampleExercisesWindow = new ExampleExercisesWindow();
            exampleExercisesWindow.Show();
            this.Close();
        }

        private void Button_ChangeData_Click(object sender, RoutedEventArgs e)
        {
            ChangeDataWindow changeDataWindow = new ChangeDataWindow();
            changeDataWindow.Show();
            this.Close();
        }

        private void Button_MealPlan_Click(object sender, RoutedEventArgs e)
        {
            MealPlanWindow mealPlanWindow = new MealPlanWindow();
            mealPlanWindow.Show();
            this.Close();
        }
    }
}
