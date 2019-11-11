using FormsMapWeb.ADT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsMapWeb.CustomControls
{
    public partial class FormPanelView : System.Web.UI.UserControl
    {
        private Form form;

        protected void Page_Load(object sender, EventArgs e) {}

        public void LoadForm(Form newForm)
        {
            form = newForm;
            lblKey.Text = form.key;
            lblSlate.Text = "Nombre Plantilla: " + form.slateName;
            lblPlace.Text = "Nombre Lugar: " + form.placeName;

            for (int i = 0; i < form.questions.Count; i++)
            {
                FormQuestionView questionView = LoadControl("~/CustomControls/FormQuestionView.ascx") as FormQuestionView;
                questionView.loadQuestion(form.questions[i], form.answers[i], form.questionTypes[i], form.hints[i]);
                PanelPreguntas.Controls.Add(questionView);
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