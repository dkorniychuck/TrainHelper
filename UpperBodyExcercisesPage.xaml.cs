using Kursach.Exercises.CardioExcercises;
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
    /// Логика взаимодействия для UpperBodyExcercisesPage.xaml
    /// </summary>
    public partial class UpperBodyExcercisesPage : Page
    {
        public UpperBodyExcercisesPage()
        {
            InitializeComponent();
        }

        private void Button_LowerBodyExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LowerBodyExcercisesPage());
        }

        private void Button_AbsExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AbsExcercisesPage());
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

        private void Button_PushUps_Click(object sender, RoutedEventArgs e)
        {
            PushUps pushUps = new PushUps();
            pushUps.ShowDialog();   
        }

        private void Button_ChairDip_Click(object sender, RoutedEventArgs e)
        {
            ChairDip chairDip = new ChairDip();
            chairDip.ShowDialog();
        }

        private void Button_BackExcercise_Click(object sender, RoutedEventArgs e)
        {
            BackExcercise backExcercise = new BackExcercise();
            backExcercise.ShowDialog();
        }

        private void Button_Plank_Click(object sender, RoutedEventArgs e)
        {
            Plank plank = new Plank();
            plank.ShowDialog();
        }
    }
}
