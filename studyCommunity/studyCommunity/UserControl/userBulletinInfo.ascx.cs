using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;

namespace studyCommunity
{
    public partial class userBulletinInfo : System.Web.UI.UserControl
    {
        BulletinBll bb = new BulletinBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater1.DataSource = bb.selNewBulletin();
                Repeater1.DataBind();
            }
        }
    }
}