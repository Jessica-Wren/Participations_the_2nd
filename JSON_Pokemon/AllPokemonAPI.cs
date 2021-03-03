using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Pokemon
{
    class AllPokemonAPI // The first ever curly bracket
    {
        public List<ResultObject> results { get; set; }
    }

    public class ResultObject
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    class AllPokedexAPI // first bracket
    {

        public int height { get; set; }
        public int weight { get; set; }
        public SpritesObject sprites { get; set; }

        public override string ToString()
        {
            return ("Height: " + height + " Weight: " + weight);
        }

        
    }

    public class SpritesObject
    {
        public string back_default { get; set; }
        public string front_default { get; set; }

    }
}
