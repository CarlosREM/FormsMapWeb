using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsMapWeb.ADT
{
    public class Form
    {
        public String key { get; set; }
        public String slateName { get; set; }
        public String placeName { get; set; }
        public List<String> questions { get; set; }
        public List<String> questionTypes { get; set; }
        public List<String> hints { get; set; }
        public List<String> answers { get; set; }

        override
        public String ToString()
        {
            return "ID: " + answers[0] + " - S: " + slateName + " - P: " + placeName;
        }

    }
}