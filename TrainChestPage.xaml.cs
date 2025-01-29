using Kursach.Exercises.CardioExcercises;
using Kursach.Exercises.ChestExcercises;
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
    /// Логика взаимодействия для TrainChestPage.xaml
    /// </summary>
    public partial class TrainChestPage : Page
    {
        public TrainChestPage()
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
        private void Button_TrainBiceps_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainBicepsPage());
        }

        private void Button_TrainShoulders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainShouldersPage());
        }

        private void Button_TrainLegs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainLegsPage());
        }

        private void Button_HorizontalPress_Click(object sender, RoutedEventArgs e)
        {
            HorizontalPress horizontalPress = new HorizontalPress();
            horizontalPress.ShowDialog();
        }

        private void Button_InclinePress_Click(object sender, RoutedEventArgs e)
        {
            InclinePress inclinePress = new InclinePress();
            inclinePress.ShowDialog();
        }

        private void Button_Butterfly_Click(object sender, RoutedEventArgs e)
        {
            Butterfly butterfly = new Butterfly();
            butterfly.ShowDialog();
        }

        private void Button_FlatteningDumbbells_Click(object sender, RoutedEventArgs e)
        {
            FlatteningDumbbells flatteningDumbbells = new FlatteningDumbbells();
            flatteningDumbbells.ShowDialog();
        }
        private void Button_Bars_Click(object sender, RoutedEventArgs e)
        {
            Bars bars = new Bars();
            bars.ShowDialog();
        }

        private void Button_BlockPress_Click(object sender, RoutedEventArgs e)
        {
            BlockPress blockPress = new BlockPress();
            blockPress.ShowDialog();
        }

        private void Button_DumbbellPress_Click(object sender, RoutedEventArgs e)
        {
            DumbbellPress dumbbellPress = new DumbbellPress();
            dumbbellPress.ShowDialog();
        }

        private void Button_HummerPress_Click(object sender, RoutedEventArgs e)
        {
            HummerPress hummerPress = new HummerPress();
            hummerPress.ShowDialog();
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
