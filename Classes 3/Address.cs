using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_3
{
    public class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }


        /// <summary>
        /// Default/Empty CTOR
        /// </summary>
        public Address()
        {
            StreetNumber = 0;
            StreetName = string.Empty;
            State = string.Empty;
            City = string.Empty;
            Zipcode = 0;
        }


        /// <summary>
        /// Overloaded CTOR
        /// </summary>
        /// <param name="streetnumber"></param>
        /// <param name="streetname"></param>
        /// <param name="state"></param>
        /// <param name="city"></param>
        /// <param name="zipcode"></param>
        public Address(int streetnumber, string streetname, string state, string city, int zipcode)
        {
            StreetNumber = streetnumber;
            StreetName = streetname;
            State = state;
            City = city;
            Zipcode = zipcode;
        }
    }
}
