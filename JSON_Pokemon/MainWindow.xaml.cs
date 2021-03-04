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

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();

            // --------------------------------------------------------------- simply getting the JSON to connect ----------------------------
            AllPokemonAPI api;
            string url = "https://pokeapi.co/api/v2/pokemon?limit=1200";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllPokemonAPI>(json);

                // ---------------------------------------------------------------------------------------------------------------------------

            }






            // results is our first object (list) in the JSON 
            foreach (var item in api.results) //.OrderBy(x => x.name).ToList())   // HOW TO ORDER ALPHABELTICALLY x represents the class
            {
                lbxPokemon.Items.Add(item);
            }
        }

        private void lbxPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCharacter = (ResultObject)lbxPokemon.SelectedItem;


            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(selectedCharacter.url).Result;

                var selectedPokedex = JsonConvert.DeserializeObject<AllPokedexAPI>(json);


                imgPokemon.Source = new BitmapImage(new Uri(selectedPokedex.sprites.front_default));

                lblHeight.Content = selectedPokedex.height;
                lblWeight.Content = selectedPokedex.weight;
            }

            //switch statements for front and back


        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedCharacter = (ResultObject)lbxPokemon.SelectedItem;


            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(selectedCharacter.url).Result;

                var selectedPokedex = JsonConvert.DeserializeObject<AllPokedexAPI>(json);

                if(i == 1)
                {
                    imgPokemon.Source = new BitmapImage(new Uri(selectedPokedex.sprites.front_default));
                    i = 0;
                    lblI.Content = (i);
                }

                if (i == 0)
                {
                    
                    imgPokemon.Source = new BitmapImage(new Uri(selectedPokedex.sprites.back_default));
                    i++;

                    Console.WriteLine(i);
                    lblI.Content = (i);
                }



                lblHeight.Content = selectedPokedex.height;
                lblWeight.Content = selectedPokedex.weight;
            }
        }
    }
}
