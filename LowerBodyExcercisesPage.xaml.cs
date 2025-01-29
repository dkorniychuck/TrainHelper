using Kursach.Exercises.CardioExcercises;
using Kursach.Exercises.LowerBodyExcercises;
using Kursach.Exercises.UpperBodyExcercises;
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

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для LowerBodyExcercisesPage.xaml
    /// </summary>
    public partial class LowerBodyExcercisesPage : Page
    {
        public LowerBodyExcercisesPage()
        {
            InitializeComponent();
        }

        private void Button_JumpSquats_Click(object sender, RoutedEventArgs e)
        {
            JumpSquats jumpSquats = new JumpSquats();
            jumpSquats.ShowDialog();
        }

        private void Button_Lunge_Click(object sender, RoutedEventArgs e)
        {
            Lunge lunge = new Lunge();
            lunge.ShowDialog();
        }

        private void Button_MountainClimbers_Click(object sender, RoutedEventArgs e)
        {
            MountainClimbers mountainClimbers = new MountainClimbers();
            mountainClimbers.ShowDialog();
        }

        private void Button_Calves_Click(object sender, RoutedEventArgs e)
        {
            Calves calves = new Calves();
            calves.ShowDialog();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            PersonalAccount_Window personalAccount_Window = new PersonalAccount_Window();

            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                parentWindow.Close();

                personalAccount_Window.Show();
            }
        }

        private void Button_TrainBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainBackPage());
        }

        private void Button_CardioExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new JoggingPage());
        }

        private void Button_UpperBodyExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UpperBodyExcercisesPage());
        }

        private void Button_AbsExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AbsExcercisesPage());
        }
    }
}
