using FormsMapWeb.ADT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsMapWeb.CustomControls
{
    public partial class SlatePanelView : System.Web.UI.UserControl
    {
        private Slate slate;
        protected void Page_Load(object sender, EventArgs e) { }

        public void LoadSlate(Slate newSlate)
        {
            slate = newSlate;
            lblKey.Text = slate.name;
            lblNameField.Text = slate.name;
            lblIdField.Text = slate.fieldID;

            for (int i = 0; i < slate.questions.Count; i++)
            {
                SlateCompView componentView = LoadControl("~/CustomControls/SlateCompView.ascx") as SlateCompView;
                componentView.loadQuestion(slate.questions[i]);
                PanelPreguntas.Controls.Add(componentView);
            }
        }

        protected void btnInfo_Click(object sender, EventArgs e)
        {
            Boolean infoVisible = InfoPanel.Visible;

            InfoPanel.Visible = !infoVisible;
            btnInfo.Text = (!infoVisible) ? "+" : "-";
        }
    }
}