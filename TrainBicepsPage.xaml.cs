using Kursach.Exercises.BicepsExcercises;
using Kursach.Exercises.CardioExcercises;
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
    /// Логика взаимодействия для TrainArmsPage.xaml
    /// </summary>
    public partial class TrainBicepsPage : Page
    {
        public TrainBicepsPage()
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

        private void Button_TrainTriceps_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainTricepsPage());
        }

        private void Button_BarLifting_Click(object sender, RoutedEventArgs e)
        {
            BarLifting barLifting = new BarLifting();
            barLifting.ShowDialog();
        }

        private void Button_Hammers_Click(object sender, RoutedEventArgs e)
        {
            Hammers hammers = new Hammers();
            hammers.ShowDialog();
        }

        private void Button_ScottBenchFift_Click(object sender, RoutedEventArgs e)
        {
            ScottBenchFift scottBenchFift = new ScottBenchFift();
            scottBenchFift.ShowDialog();
        }

        private void Button_IsolatedBicepsСurl_Click(object sender, RoutedEventArgs e)
        {
            IsolatedBicepsСurl isolatedBicepsСurl = new IsolatedBicepsСurl();
            isolatedBicepsСurl.ShowDialog();
        }

        private void Button_PullingRopeHandle_Click(object sender, RoutedEventArgs e)
        {
            PullingRopeHandle pullingRopeHandle = new PullingRopeHandle();
            pullingRopeHandle.ShowDialog();
        }

        private void Button_BicepsCurl_Click(object sender, RoutedEventArgs e)
        {
            BicepsCurl curl = new BicepsCurl();
            curl.ShowDialog();
        }

        private void Button_CardioExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new JoggingPage());
        }

        private void Button_UpperBodyExcercises_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UpperBodyExcercisesPage());
        }
    }
}
