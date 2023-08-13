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

namespace WpfAppClass
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            Document doc = new Document();
            doc.Owner = this;
            doc.Show();
            (Application.Current as App).Documents.Add(doc);
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            foreach(Document doc in ((App)Application.Current as App).Documents) 
            {
                doc.SetContent("Update at" + DateTime.Now.ToLongTimeString());
            }

        }
    }
}
