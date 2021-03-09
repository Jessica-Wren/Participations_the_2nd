using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class AllPokemonAPI //FIST BRACE
    {
        public List<ResultsObject> results { get; set; }

    }

    public class ResultsObject // inside the results object list
    {
        public string name { get; set; }
        public string url { get; set; }


        public override string ToString()
        {
            return name;
        }
    }

    public class AllPokedexAPI //FIRST BRACE
    {
        public int height { get; set; }
        public int weight { get; set; }
        public CharacterImages sprites { get; set; }
    }

    public class CharacterImages
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
    }
}
