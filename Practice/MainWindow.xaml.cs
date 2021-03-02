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

        private void btnSubmitInfo_Click(object sender, RoutedEventArgs e)
        {
            bool checkForBlank = true;

            if (string.IsNullOrWhiteSpace(tbxFirstName.Text) == true)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a vaild field (letters) for the First Name box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            if (string.IsNullOrWhiteSpace(tbxLastName.Text) == true)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a valid field (letters) for the Last Name box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            if (string.IsNullOrWhiteSpace(tbxMajor.Text) == true)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a valid field (letters) for the Major box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }


            double gpa;
            if (double.TryParse(tbxGPA.Text, out gpa) == false)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a valid field (numbers with or without decimals) for the GPA box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }


            int streetnum;
            if (int.TryParse(tbxStreetNumber.Text, out streetnum) == false)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a valid field (integers) for the Street Number box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            if (string.IsNullOrWhiteSpace(tbxStreetName.Text) == true)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a valid field (letters) for the Street Name box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            if (string.IsNullOrWhiteSpace(tbxState.Text) == true)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a valid field (letters) for the State box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            if (string.IsNullOrWhiteSpace(tbxCity.Text) == true)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a valid field (letters) for the City box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            int zipCode;
            if (int.TryParse(tbxZipcode.Text, out zipCode) == false)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a valid field (integers) for the Zipcode box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            if (checkForBlank == false)
            {
                return;
            }

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

        private void lbxTheListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            

            Student selectedStudent = (Student)lbxTheListBox.SelectedItem;
            Address selectedAddress = (Address)lbxTheListBox.SelectedItem;
            MyWindow myNewWindow = new MyWindow();
            myNewWindow.StudentInfo2(selectedStudent);
            myNewWindow.StudentInfo3(selectedAddress);
            myNewWindow.ShowDialog();


        }
    }
}
