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

namespace WpfAppPropertyInj
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding binding2 = new Binding();
            binding2.ElementName = "myTextBox";
            binding2.Path = new PropertyPath("Text");
            myTextBlock2.SetBinding(TextBlock.TextProperty, binding2);

            myTextBox.Text = "111";
        }

        private void button_UpdateData_Click(object sender, RoutedEventArgs e)
        {
            Phone phone = (Phone)this.Resources["nexusPhone"];//
            phone.Company = "LG";
            phone.Title = "Nexus2";
            phone.Price = 80000;
        }
    }
}
