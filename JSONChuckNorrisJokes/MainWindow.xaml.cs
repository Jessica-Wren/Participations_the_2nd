using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSONChuckNorrisJokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cbxJokeCategory.Items.Add("All");

            
        }

        private void IfSelectedAll()
        {
            AllJokesAPI api;
            string url = "https://api.chucknorris.io/jokes/random";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllJokesAPI>(json);

                lblTheJoke.Content = api;

            }
        }

        private void btnGetJoke_Click(object sender, RoutedEventArgs e)
        {
            IfSelectedAll();
        }
    }
}
