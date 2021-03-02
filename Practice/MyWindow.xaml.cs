using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practice
{
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
       
        public MyWindow()
        {
            InitializeComponent();
        }

        public void StudentInfo2(Student myWindowStudent)
        {
             lblHey.Content = myWindowStudent.FirstName;
            lblLastName.Content = myWindowStudent.LastName;
            

        }

        public void StudentInfo3(Address myWindowAddress)
        {
            lblZip.Content = myWindowAddress.Zipcode;
        }
    }
}
