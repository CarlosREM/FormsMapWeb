using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsMapWeb.ADT
{
    public class Slate
    {
        public String fieldID { get; set; }
        public String name { get; set; }
        public List<SlateComponent> questions { get; set; }

        override
        public String ToString()
        {
            String stringPlantilla = "\n-- SLATE --\n";
            stringPlantilla += "FieldID: " + fieldID + "\n";
            stringPlantilla += "Name: " + name + "\n";
            foreach (SlateComponent question in questions)
            {
                stringPlantilla += question.toString();
            }
            return stringPlantilla;
        }
    }
}