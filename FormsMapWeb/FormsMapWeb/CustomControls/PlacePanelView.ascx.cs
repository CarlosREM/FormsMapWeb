
using Firebase.Database.Query;
using FormsMapWeb.ADT;
using System;
using System.Threading.Tasks;
using System.Web.UI;
using Firebase.Database;

namespace FormsMapWeb.CustomControls
{
    public partial class PlacePanelView : System.Web.UI.UserControl
    {
        private Place place;
        private FirebaseClient firebaseClient;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                firebaseClient = new FirebaseClient("https://formsmap-ac3a9.firebaseio.com/");
            }
        }

        public void LoadPlace(Place newPlace)
        {
            place = newPlace;
            lblKey.Text = place.name;
            lblNameField.Text = place.name;
            lblImgField.Text = place.imageURL;
            lblLatField.Text = place.lat.ToString();
            lblLonField.Text = place.Long.ToString();
            lblInfoField.Text = place.info;

        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            place.info = lblInfoField.Text;
            publishPlace();
        }
        protected async Task publishPlace()
        {
            var result = await firebaseClient.Child("Places").PostAsync(place);
        }


        protected void btnInfo_Click(object sender, EventArgs e)
        {
            Boolean infoVisible = InfoPanel.Visible;

            InfoPanel.Visible = !infoVisible;
            btnInfo.Text = (!infoVisible) ? "+" : "-";
        }
    }
}