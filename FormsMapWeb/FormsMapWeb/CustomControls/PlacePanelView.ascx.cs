using FormsMapWeb.ADT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsMapWeb.CustomControls
{
    public partial class PlacePanelView : System.Web.UI.UserControl
    {
        private Place place;
        
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void btnInfo_Click(object sender, EventArgs e)
        {
            Boolean infoVisible = InfoPanel.Visible;

            InfoPanel.Visible = !infoVisible;
            btnInfo.Text = (!infoVisible) ? "+" : "-";
        }
    }
}