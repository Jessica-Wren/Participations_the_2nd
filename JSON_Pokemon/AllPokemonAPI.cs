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
}
