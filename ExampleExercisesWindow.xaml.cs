﻿using System;
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
using System.Windows.Shapes;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для ExampleExercisesWindow.xaml
    /// </summary>
    public partial class ExampleExercisesWindow : Window
    {
        public ExampleExercisesWindow()
        {
            InitializeComponent();
            TrainsFrame.Content = new TrainBackPage();
        }
    }
}
