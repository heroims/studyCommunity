using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace studyCommunity
{
    public partial class Tutorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNet_Click(object sender, EventArgs e)
        {
            Response.Redirect("TutorialList.aspx?TypeID=1&TutorialType=" + Request.Params["TutorialType"]);
        }

        protected void btnAsp_Click(object sender, EventArgs e)
        {
            Response.Redirect("TutorialList.aspx?TypeID=2&TutorialType=" + Request.Params["TutorialType"]);
        }

        protected void btnJsp_Click(object sender, EventArgs e)
        {
            Response.Redirect("TutorialList.aspx?TypeID=3&TutorialType=" + Request.Params["TutorialType"]);
        }

        protected void btnVb_Click(object sender, EventArgs e)
        {
            Response.Redirect("TutorialList.aspx?TypeID=4&TutorialType=" + Request.Params["TutorialType"]);
        }

        protected void btnVc_Click(object sender, EventArgs e)
        {
            Response.Redirect("TutorialList.aspx?TypeID=5&TutorialType=" + Request.Params["TutorialType"]);
        }

        protected void btnDelphi_Click(object sender, EventArgs e)
        {
            Response.Redirect("TutorialList.aspx?TypeID=6&TutorialType=" + Request.Params["TutorialType"]);
        }
    }
}