using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Firebase.Database;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FormsMapWeb
{
    public partial class ListaPlantillas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            obtenerPlantillas();
        }


        public async void obtenerPlantillas()
        {
            //Simulate test user data and login timestamp
   
            //Save non identifying data to Firebase
            var firebaseClient = new FirebaseClient("https://formsmap-ac3a9.firebaseio.com/");
            var Plantillas = await firebaseClient
              .Child("Slates")
              .OnceAsync<Plantilla>();

            var plantillasList = new List<Plantilla>();

            foreach (var p in Plantillas)
            {
                var newPlantilla = new Plantilla();
                newPlantilla.name = p.Object.name;
                newPlantilla.fieldID = p.Object.fieldID;
                newPlantilla.questions = p.Object.questions;
                plantillasList.Add(newPlantilla);
            }

            foreach (Plantilla p in plantillasList)
            {
                Debug.WriteLine(p.toString());
            }
        }
    }
}