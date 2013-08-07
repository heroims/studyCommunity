using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;
using StudyModel;

namespace studyCommunity
{
    public partial class index : System.Web.UI.Page
    {
        SoundBll sb = new SoundBll();
        VideoBll vb = new VideoBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvBind();
            }
        }

        private void gvBind()
        {
            gvNewSound.DataSource = sb.selNewSound().Tables[0];
            gvNewVideo.DataSource = vb.selNewViedo().Tables[0];
            gvNewSound.DataBind();
            gvNewVideo.DataBind();
        }
    }
}