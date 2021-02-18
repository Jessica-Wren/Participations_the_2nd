using System;
using System.Collections.Generic;
using System.Text;

namespace WPF___Classes
{
    public class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }


        /// <summary>
        /// Default ctor
        /// </summary>
        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }
        
        /// <summary>
        /// Overloaded ctor
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
            return (Name + ", " + Address + " " + ZipCode);
        }
    }
}
