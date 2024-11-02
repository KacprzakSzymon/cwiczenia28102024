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

namespace cwiczenia28102024
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Visibility = Visibility.Hidden;
            MessageBox.Show("Witaj świecie!");
            btnStart.Visibility = Visibility.Visible;
        }

        private void btntime_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btntime_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;
            btntime.Content = data.ToString("T");
        }

        private void btntime_MouseLeave(object sender, MouseEventArgs e)
        {
            btntime.Content = "Czas";
        }

        private void btnEnable_Click(object sender, MouseEventArgs e)
        {
            btnStart.IsEnabled=true;
        }
        private void btnYes_Click(object sender, MouseEventArgs e)
        {
            if((string)btnYes.Content=="Nie")
                MessageBox.Show("tak myślałem");
            else
            {
                btnNo.Content="Tak";
                btnYes.Content="Nie";
            }
        }
        private void btnNo_Click(object sender, MouseEventArgs e)
        {
            if((string)btnNo.Content=="Nie")
                MessageBox.Show("tak myślałem");
            else
            {
                btnNo.Content="Nie";
                btnYes.Content="Tak";
            }
        }
    }
}
