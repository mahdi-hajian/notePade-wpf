using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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
            foreach (var item in dgone.Columns)
            {
                MemberInfo property = typeof(PersonelViewModel).GetProperty(item.Header.ToString());
                var attribute = property.GetCustomAttributes(typeof(DisplayNameAttribute))
                      .Cast<DisplayNameAttribute>().FirstOrDefault();
                string displayName = attribute.DisplayName;
                item.Header = displayName;
            }
        }

    }
}
