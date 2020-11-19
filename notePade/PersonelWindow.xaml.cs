using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace notePade
{
    /// <summary>
    /// Interaction logic for PersonelWindow.xaml
    /// </summary>
    public partial class PersonelWindow : Window
    {
        public PersonelWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PersonelViewModel personelViewModel = new PersonelViewModel();
            dgone.ItemsSource = personelViewModel.Personels.ToList();
        }

        private void dgone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
