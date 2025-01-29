using Kursach.Exercises.CardioExcercises;
using Kursach.Exercises.LegsExcercises;
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
    /// Логика взаимодействия для TrainLegsPage.xaml
    /// </summary>
    public partial class TrainLegsPage : Page
    {
        public TrainLegsPage()
        {
            InitializeComponent();
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
        private void Button_TrainChest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainChestPage());
        }
        private void Button_TrainBiceps_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainBicepsPage());
        }

        private void Button_TrainShoulders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainShouldersPage());
        }

        private void Button_LegPress_Click(object sender, RoutedEventArgs e)
        {
            LegPress legPress = new LegPress();
            legPress.ShowDialog();
        }

        private void Button_RomanianDeadlift_Click(object sender, RoutedEventArgs e)
        {
            RomanianDeadlift romanianDeadlift = new RomanianDeadlift();
            romanianDeadlift.ShowDialog();  
        }

        private void Button_Squats_Click(object sender, RoutedEventArgs e)
        {
            Squats squats = new Squats();
            squats.ShowDialog();
        }

        private void Button_Lunges_Click(object sender, RoutedEventArgs e)
        {
            Lunges lunges = new Lunges();
            lunges.ShowDialog();
        }

        private void Button_LegExtensions_Click(object sender, RoutedEventArgs e)
        {
            LegExtensions legExtensions = new LegExtensions();
            legExtensions.ShowDialog();
        }

        private void Button_LegCurls_Click(object sender, RoutedEventArgs e)
        {
            LegCurls legCurls = new LegCurls();
            legCurls.ShowDialog();
        }

        private void Button_HackSquats_Click(object sender, RoutedEventArgs e)
        {
            HackSquats hacks = new HackSquats();    
            hacks.ShowDialog();
        }

        private void Button_Calves_Click(object sender, RoutedEventArgs e)
        {
            Calves calves = new Calves();
            calves.ShowDialog();
        }

        private void Button_UpperBodyExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UpperBodyExcercisesPage());
        }

        private void Button_CardioExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new JoggingPage());
        }
    }
}
