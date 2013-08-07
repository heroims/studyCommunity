using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace studyCommunity
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserName"] != null)
                {
                    PanelEntry.Visible = false;
                    PanelHello.Visible = true;
                    UserName.Text = Session["UserName"].ToString();
                }
                else
                {
                    PanelEntry.Visible = true;
                    PanelHello.Visible = false;
                }
            }
        }

        protected void btnLose_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null;
            Response.AddHeader("Refresh", "0"); 
        }
    }
}