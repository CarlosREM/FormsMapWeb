using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsMapWeb.CustomControls
{
    public partial class FormQuestionView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void loadQuestion(String question, String answer, String type, String hintString)
        {
            LblQuestionField.Text = question;
            LblAnswerField.Text = answer;
            LblTypeField.Text = type;

            String[] hints = hintString.Split('|');

            for (int i = 0; i < hints.Length; i++)
            {
                Label lblHint = new Label();
                lblHint.Font.Name = "Lato";
                lblHint.Text = "> " + hints[i];

                HintsPanel.Controls.Add(lblHint);
                if (i < hints.Length-1)
                    HintsPanel.Controls.Add(new LiteralControl("<br />"));
            }
        }
    }
}