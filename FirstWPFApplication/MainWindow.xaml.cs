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

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tbxName.Clear();
            tbxBirthday.Clear();
            lblNyeh.Content = string.Empty;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
        //https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday

            string birthdayResponse = tbxBirthday.Text;
            DateTime result = Convert.ToDateTime(birthdayResponse);
            var today = DateTime.Today;
            var finalResult = today.Year - result.Year;
            string nameResponse = tbxName.Text;

            MessageBox.Show(nameResponse + ", you are, or will be, " + finalResult + " years old this year.");

            lblNyeh.Content = "Nyeh heh heh!";

        }

        private void btnCalculate_MouseEnter(object sender, MouseEventArgs e)
        {
            changeMe.Background = Brushes.BlueViolet;
        }

        private void btnCalculate_MouseLeave(object sender, MouseEventArgs e)
        {
            changeMe.Background = Brushes.CornflowerBlue;
        }
    }
}
