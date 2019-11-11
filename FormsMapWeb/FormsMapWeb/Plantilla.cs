using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsMapWeb
{
    public class Plantilla
    {
        public String fieldID { get; set; }
        public String name { get; set; }
        public List<Question> questions { get; set; }
        
        public String toString()
        {
            String stringPlantilla = "";
            stringPlantilla += "FieldID: " + fieldID + "\n";
            stringPlantilla += "Name: " + name + "\n";
            foreach (Question question in questions)
            {
                stringPlantilla += question.toString();
            }
            return stringPlantilla;
        }
    }
}