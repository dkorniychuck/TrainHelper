using Kursach.Exercises.AbsExcercises;
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
    /// Логика взаимодействия для AbsExcercisesPage.xaml
    /// </summary>
    public partial class AbsExcercisesPage : Page
    {
        public AbsExcercisesPage()
        {
            InitializeComponent();
        }

        private void Button_LegsTucking_Click(object sender, RoutedEventArgs e)
        {
            LegsTucking legsTucking = new LegsTucking();
            legsTucking.ShowDialog();
        }

        private void Button_Twisting_Click(object sender, RoutedEventArgs e)
        {
            Twisting twisting = new Twisting();
            twisting.ShowDialog();
        }

        private void Button_LateralCrunches_Click(object sender, RoutedEventArgs e)
        {
            LateralCrunches lateralCrunches = new LateralCrunches();
            lateralCrunches.ShowDialog();
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

        private void Button_LowerBodyExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LowerBodyExcercisesPage());
        }

        private void Button_LegLift_Click(object sender, RoutedEventArgs e)
        {
            LegLift legLift = new LegLift();
            legLift.ShowDialog();
        }
    }
}
