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

namespace Classes_3
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

        private void btnSubmitInfo_Click(object sender, RoutedEventArgs e)
        {

            int streetnum;
            int.TryParse(tbxStreetNumber.Text, out streetnum);

            int zipCode;
            int.TryParse(tbxZipcode.Text, out zipCode);


                Student myStudent = new Student
            {
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                Major = tbxMajor.Text,
                GPA = Convert.ToDouble(tbxGPA.Text),
            };

            myStudent.SetAddress(streetnum, tbxStreetName.Text, tbxState.Text, tbxCity.Text, zipCode);
            lbxTheListBox.Items.Add(myStudent);


            tbxCity.Clear();
            tbxFirstName.Clear();
            tbxGPA.Clear();
            tbxLastName.Clear();
            tbxMajor.Clear();
            tbxState.Clear();
            tbxStreetName.Clear();
            tbxStreetNumber.Clear();
            tbxZipcode.Clear();
        }
    }
}
