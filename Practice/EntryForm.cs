using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        /// <summary>
        /// Default/Empty CTOR
        /// </summary>
        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }

        /// <summary>
        /// Filled CTOR
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="zipCode"></param>
        public EntryForm(string name, string address, int zipCode)
        {
            Name = name;
            Address = address;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return (Name + " " + Address + " " + ZipCode);
        }
    }
}
