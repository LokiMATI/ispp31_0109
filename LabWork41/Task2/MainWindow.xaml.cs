﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation animation = new();

            animation.To = Button.FontSize * 2;
            animation.Duration = TimeSpan.FromSeconds(1);
            animation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(4));
            animation.AutoReverse = true;

            Button.BeginAnimation(Button.FontSizeProperty, animation);

        }
    }
}