using Kursach.Exercises.CardioExcercises;
using Kursach.Exercises.ChestExcercises;
using Kursach.Exercises.TricepsExcercises;
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
    /// Логика взаимодействия для TrainTricepsPage.xaml
    /// </summary>
    public partial class TrainTricepsPage : Page
    {
        public TrainTricepsPage()
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

        private void Button_TrainShoulders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainShouldersPage());
        }
        private void Button_TrainLegs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainLegsPage());
        }

        private void Button_TrainBiceps_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainBicepsPage());
        }

        private void Button_FrenchPress_Click(object sender, RoutedEventArgs e)
        {
            FrenchPress frenchPress = new FrenchPress();
            frenchPress.ShowDialog();
        }

        private void Button_BlockExtension_Click(object sender, RoutedEventArgs e)
        {
            BlockExtension blockExtension = new BlockExtension();
            blockExtension.ShowDialog();
        }

        private void Button_DumbbellLift_Click(object sender, RoutedEventArgs e)
        {
            DumbbellLift dumbbellLift = new DumbbellLift();
            dumbbellLift.ShowDialog(); 
        }

        private void Button_ReverseExtension_Click(object sender, RoutedEventArgs e)
        {
            ReverseExtension reverseExtension = new ReverseExtension();
            reverseExtension.ShowDialog();
        }

        private void Button_MediumGripBenchPress_Click(object sender, RoutedEventArgs e)
        {
            MediumGripBenchPress mediumGripBenchPress = new MediumGripBenchPress();
            mediumGripBenchPress.ShowDialog();
        }

        private void Button_Bars_Click(object sender, RoutedEventArgs e)
        {
            Bars bars = new Bars();
            bars.ShowDialog();
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
