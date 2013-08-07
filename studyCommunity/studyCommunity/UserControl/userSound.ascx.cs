using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;

namespace studyCommunity
{
    public partial class userSound : System.Web.UI.UserControl
    {
        SoundBll sb = new SoundBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater1.DataSource = sb.selTopSound().Tables[0];
                Repeater1.DataBind();
            }
        }
    }
}