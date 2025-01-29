using Kursach.Exercises.CardioExcercises;
using Kursach.Exercises.ChestExcercises;
using Kursach.Exercises.ShouldersExercises;
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
    /// Логика взаимодействия для TrainShouldersPage.xaml
    /// </summary>
    public partial class TrainShouldersPage : Page
    {
        public TrainShouldersPage()
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

        private void Button_TrainLegs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainLegsPage());
        }

        private void Button_DumbbellPress_Click(object sender, RoutedEventArgs e)
        {
            ShouldersDumbbellPress dumbbellPress = new ShouldersDumbbellPress();
            dumbbellPress.ShowDialog();
        }

        private void Button_HorizontalDumbbellLift_Click(object sender, RoutedEventArgs e)
        {
            HorizontalDumbbellLift dumbbellLift = new HorizontalDumbbellLift();
            dumbbellLift.ShowDialog();
        }

        private void Button_RearDeltasReduction_Click(object sender, RoutedEventArgs e)
        {
            RearDeltasReduction rearDeltasReduction = new RearDeltasReduction();
            rearDeltasReduction.ShowDialog();
        }

        private void Button_SmithPress_Click(object sender, RoutedEventArgs e)
        {
            SmithPress smithPress = new SmithPress();
            smithPress.ShowDialog();
        }

        private void Button_BlockPullDown_Click(object sender, RoutedEventArgs e)
        {
            BlockPullDown blockPullDown = new BlockPullDown();
            blockPullDown.ShowDialog();
        }

        private void Button_ShoulderLiftІ_Click(object sender, RoutedEventArgs e)
        {
            ShoulderLift shoulderLift = new ShoulderLift(); 
            shoulderLift.ShowDialog();
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
