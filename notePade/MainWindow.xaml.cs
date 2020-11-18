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

namespace notePade
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

        private void New_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "";
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFile = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "text file|*.txt",
                Title = "لطفا فایلی انتخاب کنید"
            };
            openFile.ShowDialog();
            if (openFile.SafeFileName != "")
            txt1.Text = System.IO.File.ReadAllText (openFile.FileName);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            txt1.Background = Brushes.Red;
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            txt1.Background = Brushes.Yellow;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFile = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "text file|*.txt",
                Title = "محل ذخیره فایل را انخاب کنید"
            };
            saveFile.ShowDialog();
            if (saveFile.SafeFileName != "")
                System.IO.File.WriteAllText(saveFile.FileName, txt1.Text);
        }
    }
}
