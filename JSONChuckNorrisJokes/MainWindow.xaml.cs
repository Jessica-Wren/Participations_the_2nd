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
            cbxJokeCategory.Items.Add("animal");
            cbxJokeCategory.Items.Add("career");
            cbxJokeCategory.Items.Add("celebrity");
            cbxJokeCategory.Items.Add("dev");
            cbxJokeCategory.Items.Add("explicit");
            cbxJokeCategory.Items.Add("fashion");
            cbxJokeCategory.Items.Add("food");
            cbxJokeCategory.Items.Add("history");
            cbxJokeCategory.Items.Add("money");
            cbxJokeCategory.Items.Add("movie");
            cbxJokeCategory.Items.Add("music");
            cbxJokeCategory.Items.Add("political");
            cbxJokeCategory.Items.Add("religion");
            cbxJokeCategory.Items.Add("science");
            cbxJokeCategory.Items.Add("sport");
            cbxJokeCategory.Items.Add("travel");

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
            if (cbxJokeCategory.SelectedItem == "All")
            {
                IfSelectedAll();
            }
            else if (cbxJokeCategory.SelectedItem == "animal")
            {
                IfSelectedAnimal();
            }
            else if (cbxJokeCategory.SelectedItem == "career")
            {
                IfSelectedCareer();
            }
            else if (cbxJokeCategory.SelectedItem == "celebrity")
            {
                IfSelectedCelebrity();
            }
            else if (cbxJokeCategory.SelectedItem == "dev")
            {
                IfSelectedDev();
            }
            else if (cbxJokeCategory.SelectedItem == "explicit")
            {
                IfSelectedExplicit();
            }
            else if (cbxJokeCategory.SelectedItem == "fashion")
            {
                IfSelectedFashion();
            }
            else if (cbxJokeCategory.SelectedItem == "food")
            {
                IfSelectedFood();
            }
            else if (cbxJokeCategory.SelectedItem == "history")
            {
                IfSelectedHistory();
            }
            else if (cbxJokeCategory.SelectedItem == "money")
            {
                IfSelectedMoney();
            }
            else if (cbxJokeCategory.SelectedItem == "movie")
            {
                IfSelectedMovie();
            }
            else if (cbxJokeCategory.SelectedItem == "music")
            {
                IfSelectedMusic();
            }
            else if (cbxJokeCategory.SelectedItem == "political")
            {
                IfSelectedPolitical();
            }
            else if (cbxJokeCategory.SelectedItem == "religion")
            {
                IfSelectedReligion();
            }
            else if (cbxJokeCategory.SelectedItem == "science")
            {
                IfSelectedScience();
            }
            else if (cbxJokeCategory.SelectedItem == "science")
            {
                IfSelectedScience();
            }
            else if (cbxJokeCategory.SelectedItem == "sport")
            {
                IfSelectedSport();
            }
            else if (cbxJokeCategory.SelectedItem == "travel")
            {
                IfSelectedTravel();
            }


        }

        private void IfSelectedTravel()
        {
            AllTravelAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=travel";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<AllTravelAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedSport()
        {
            AllSportAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=sport";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<AllSportAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedScience()
        {
            AllScienceAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=science";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<AllScienceAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedReligion()
        {
            AllReligionAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=religion";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<AllReligionAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedPolitical()
        {
            AllPoliticalAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=political";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<AllPoliticalAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedMusic()
        {
            AllMusicAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=music";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<AllMusicAPI>(json);

                lblTheJoke.Content = api;

            }
        }

        private void IfSelectedMovie()
        {
            AllMovieAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=movie";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<AllMovieAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedMoney()
        {
            AllMoneyAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=money";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllMoneyAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedHistory()
        {
            AllHistoryAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=history";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<AllHistoryAPI>(json);

                lblTheJoke.Content = api;
            }

           
        }

        private void IfSelectedFood()
        {
            AllFoodAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=food";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllFoodAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedFashion()
        {
            AllFashionAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=fashion";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllFashionAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedExplicit()
        {
            AllExplicitAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=explicit";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllExplicitAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedDev()
        {
            AllDevAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=dev";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllDevAPI>(json);

                lblTheJoke.Content = api;
            }
        }

        private void IfSelectedCelebrity()
        {
            AllCelebrityAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=celebrity";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllCelebrityAPI>(json);

                lblTheJoke.Content = api;

            }
        }

        private void IfSelectedCareer()
        {
            AllCareerAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=career";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllCareerAPI>(json);

                lblTheJoke.Content = api;

            }
        }

        private void IfSelectedAnimal()
        {
            AllAnimalAPI api;
            string url = "https://api.chucknorris.io/jokes/random?category=animal";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllAnimalAPI>(json);

                lblTheJoke.Content = api;

            }
        }
    }
}
