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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonNovel_Click(object sender, RoutedEventArgs e)
        {
            var meret = Convert.ToInt32(textboxMeret.Text);
            if (meret<9)
            {
                meret += 1;
            }
            textboxMeret.Text = meret.ToString();
        }

        private void buttonCsokkent_Click(object sender, RoutedEventArgs e)
        {
            var meret = Convert.ToInt32(textboxMeret.Text);
            if (meret>4)
            {
                meret -= 1;
            }
            textboxMeret.Text = meret.ToString();
        }
    }
}
