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

namespace PracticeDelete
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RickAndMortyAPI api;
            string url = "https://rickandmortyapi.com/api/character";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);

                

            }

            // results is our first object (list) in the JSON 
            foreach (var item in api.results) //.OrderBy(x => x.name).ToList())   // HOW TO ORDER ALPHABELTICALLY x represents the class
            {
                lbxListBox.Items.Add(item);
            }
        }

        private void lbxListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResultsObject selectedCharacter = (ResultsObject)lbxListBox.SelectedItem;
            MyWindow myNewWindow = new MyWindow();
            myNewWindow.MyShowImage(selectedCharacter);
            myNewWindow.ShowDialog();
        }
    }
}
