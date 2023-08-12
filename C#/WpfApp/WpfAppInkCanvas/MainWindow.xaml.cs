﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppInkCanvas
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode))) 
            {
                lstEditingMode.Items.Add(mode);
            }
            lstEditingMode.SelectedIndex = (int)inkCanvas.EditingMode;
        }

        private void inkGester(object sender, InkCanvasGestureEventArgs e)
        {
            String gesture = "";
            foreach (GestureRecognitionResult res in e.GetGestureRecognitionResults())
            {
                gesture += res.ApplicationGesture.ToString() + "; ";

                gestureName.Text = gesture;
            }
        }


    }
}
