using FormsMapWeb.ADT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsMapWeb.CustomControls
{
    public partial class SlateCompView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void loadQuestion(SlateComponent component)
        {
            LblQuestionField.Text = component.question;
            LblTypeField.Text = component.type;

            for (int i = 0; i < component.hints.Count; i++)
            {
                Label lblHint = new Label();
                lblHint.Font.Name = "Lato";
                lblHint.Text = "> " + component.hints[i];

                HintsPanel.Controls.Add(lblHint);
                if (i < component.hints.Count - 1)
                    HintsPanel.Controls.Add(new LiteralControl("<br />"));
            }
        }
    }
}