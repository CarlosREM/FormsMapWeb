using Firebase.Database;
using FormsMapWeb.ADT;
using FormsMapWeb.CustomControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsMapWeb
{
    public partial class MainWindow : System.Web.UI.Page
    {
        private FirebaseClient firebaseClient = new FirebaseClient("https://formsmap-ac3a9.firebaseio.com/");

        private static int currentPanel;
        private const int FORMS_PANEL = 1,
                          SLATES_PANEL = 2,
                          PLACES_PANEL = 3;

        private static List<Control> ContentPanelControls = new List<Control>();

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (ContentPanelControls.Count > 0)
            {
                FillContentPanel();
            }
            */
        }

        protected void btnFormularios_Click(object sender, EventArgs e)
        {
            ContentPanelControls.Clear();
            currentPanel = FORMS_PANEL;
            enableButtons();

            RegisterAsyncTask(new PageAsyncTask(LoadFormulariosAsync));
        }
        private async Task LoadFormulariosAsync()
        {
            var bdArray = await firebaseClient
                                   .Child("Forms")
                                   .OnceAsync<Form>();

            foreach (var obj in bdArray)
            {
                FormPanelView panel = LoadControl("~/CustomControls/FormPanelView.ascx") as FormPanelView;

                panel.LoadForm(obj.Object);

                ContentPanel.Controls.Add(panel);
            }
            FillContentPanel();
        }

        protected void btnPlantillas_Click(object sender, EventArgs e)
        {
            ContentPanelControls.Clear();
            currentPanel = SLATES_PANEL;
            enableButtons();

            RegisterAsyncTask(new PageAsyncTask(LoadPlantillasAsync));
        }
        private async Task LoadPlantillasAsync()
        {
            var bdArray = await firebaseClient
                                   .Child("Slates")
                                   .OnceAsync<Slate>();

            foreach (var obj in bdArray)
            {
                Slate s = new Slate();
                s.name = obj.Object.name;
                s.fieldID = obj.Object.fieldID;
                s.questions = obj.Object.questions;

                Debug.WriteLine(s.ToString());
            }
        }

        protected void btnLugares_Click(object sender, EventArgs e)
        {
            ContentPanelControls.Clear();
            currentPanel = PLACES_PANEL;
            enableButtons();

            RegisterAsyncTask(new PageAsyncTask(LoadLugaresAsync));
        }
        private async Task LoadLugaresAsync()
        {
            var bdArray = await firebaseClient
                                   .Child("Places")
                                   .OnceAsync<Place>();

            foreach (var obj in bdArray)
            {
                PlacePanelView panel = LoadControl("~/CustomControls/PlacePanelView.ascx") as PlacePanelView;

                panel.LoadPlace(obj.Object);

                ContentPanel.Controls.Add(panel);

            }
        }

        private void enableButtons()
        {
            btnFormularios.Enabled = (currentPanel != FORMS_PANEL);
            btnPlantillas.Enabled = (currentPanel != SLATES_PANEL);
            btnLugares.Enabled = (currentPanel != PLACES_PANEL);
            if (!btnRefresh.Enabled)
                btnRefresh.Enabled = true;
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            ContentPanelControls.Clear();

            int a = currentPanel;
            switch (a)
            {
                case FORMS_PANEL:
                    RegisterAsyncTask(new PageAsyncTask(LoadFormulariosAsync));
                    break;

                case SLATES_PANEL:
                    RegisterAsyncTask(new PageAsyncTask(LoadPlantillasAsync));
                    break;

                case PLACES_PANEL:
                    RegisterAsyncTask(new PageAsyncTask(LoadLugaresAsync));
                    break;

                default:
                    Debug.WriteLine("Error: CurrentPanel="+currentPanel);
                    break;
            }
        }

        private void FillContentPanel()
        {
            foreach(Control c in ContentPanelControls)
            {
                ContentPanel.Controls.Add(c);
            }
        }
    }
}