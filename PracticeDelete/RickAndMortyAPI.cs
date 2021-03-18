using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDelete
{
    public class RickAndMortyAPI // FIrst brace
    {
        public InfoObject info { get; set; }
        public List<ResultsObject> results { get; set; }
        

    }

    public class ResultsObject
    {
        public string name { get; set; }
        public string image { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class InfoObject
    {
        public string next { get; set; }
    }
}
