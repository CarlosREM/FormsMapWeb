using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsMapWeb.ADT
{
    public class Place
    {
        public string info { set; get; }
        public double lat { set; get; }
        public double Long { set; get; }
        public string name { set; get; }
        public string imageURL { set; get; }

        override
        public string ToString()
        {
            return name + "\t Lat:" + lat + " - Long: " + Long;
        }
    }
}