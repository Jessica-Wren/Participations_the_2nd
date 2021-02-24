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

namespace Classes_3
{
    /// <summary>
    /// Interaction logic for MyNewForm.xaml
    /// </summary>
    public partial class MyNewForm : Window
    {
        public string GetYouOver { get; set; }

        public MyNewForm()
        {
            InitializeComponent();
        }

        /*public void ShowStudent(Student selectedStudent)
        {
            lblHi.Content = selectedStudent;
        }*/


    }
}
