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

                Student myStudent = new Student()
            {
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                Major = tbxMajor.Text,
                GPA = Convert.ToDouble(tbxGPA.Text),
            };

            Address myAddress = new Address()
            {
                StreetName = tbxStreetName.Text,
               
                Zipcode = Convert.ToInt32(tbxZipcode.Text),

            };

            myStudent.Address = myAddress;

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

            MyNewForm myNewFormV = new MyNewForm();

            myNewFormV.ShowStudent(selectedStudent);
            myNewFormV.Show();
           
        }


    }
}
