using Kursach.Exercises.BackExercises;
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
    /// Логика взаимодействия для TrainBackPage.xaml
    /// </summary>
    public partial class TrainBackPage : Page
    {
        public TrainBackPage()
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

        private void Button_TrainLegs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TrainLegsPage());
        }

        private void Button_UpperBlock_Click(object sender, RoutedEventArgs e)
        {
            UpperBlockWindow upperBlockWindow = new UpperBlockWindow();
            upperBlockWindow.ShowDialog();
        }

        private void Button_HorizontalBlock_Click(object sender, RoutedEventArgs e)
        {
            HorizontalBlock horizontalBlock = new HorizontalBlock();
            horizontalBlock.ShowDialog();   
        }

        private void Button_PullUps_Click(object sender, RoutedEventArgs e)
        {
            PullUps pullUps = new PullUps();
            pullUps.ShowDialog(); 
        }

        private void Button_Linkage_Click(object sender, RoutedEventArgs e)
        {
            Linkage linkage = new Linkage();
            linkage.ShowDialog();
        }

        private void Button_TPull_Click(object sender, RoutedEventArgs e)
        {
            TPull pull = new TPull();
            pull.ShowDialog();
        }

        private void Button_DumbbellRow_Click(object sender, RoutedEventArgs e)
        {
            DumbbellRow dumbbellRow = new DumbbellRow();
            dumbbellRow.ShowDialog();
        }

        private void Button_Hyperextension_Click(object sender, RoutedEventArgs e)
        {
            Hyperextension hyperextension = new Hyperextension();
            hyperextension.ShowDialog();
        }

        private void Button_Pullover_Click(object sender, RoutedEventArgs e)
        {
            Pullover pullover = new Pullover();
            pullover.ShowDialog();
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

