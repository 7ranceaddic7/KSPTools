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
using Kerbal_Space_Program_Tools;

namespace Kerbal_Space_Progam_Tools
{
    /// <summary>
    /// Interaction logic for Phase_Angle_Map.xaml
    /// </summary>
    public partial class Phase_Angle_Map : Window
    {
        public Phase_Angle_Map()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = WindowState.Minimized;
        }

        private void PrevBtn_Click(object sender, RoutedEventArgs e)
        {
            Pages.PageMissionCalc mypage = new Pages.PageMissionCalc();
            mypage.buttonStop3.IsChecked = true;
        }
    }

    
}
