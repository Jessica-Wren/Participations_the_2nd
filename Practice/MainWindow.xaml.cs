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

namespace Practice
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = tbxName.Text;
            string bday = tbxBDay.Text;

            DateTime responseDate = Convert.ToDateTime(bday);

            var today = DateTime.Today;
            var finalResult = today.Year - responseDate.Year;
            

            MessageBox.Show(name + ", you are" + finalResult + " years old this year","HI");

            lblName.Content = Brushes.AntiqueWhite;

            

        }

        private void btnButton_MouseEnter(object sender, MouseEventArgs e)
        {
            grdChangeMe.Background = Brushes.Tomato;
        }

        private void btnButton_MouseLeave(object sender, MouseEventArgs e)
        {
            grdChangeMe.Background = Brushes.PapayaWhip;
        }
    }
}
