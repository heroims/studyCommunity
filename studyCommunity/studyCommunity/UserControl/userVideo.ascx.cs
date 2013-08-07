using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;

namespace studyCommunity
{
    public partial class userVideo : System.Web.UI.UserControl
    {
        VideoBll vb = new VideoBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater1.DataSource = vb.selTopVideo().Tables[0];
                Repeater1.DataBind();
            }
        }
    }
}