using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;

namespace studyCommunity
{
    public partial class TutorialList : System.Web.UI.Page
    {
        SoundBll sb = new SoundBll();
        VideoBll vb = new VideoBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Params["TutorialType"] == "Sound")
                {
                    dataPaging1.Count = sb.getSearchSoundCount(Request.Params["TypeID"], "");
                }
                else
                {
                    dataPaging1.Count = vb.getSearchVideoCount(Request.Params["TypeID"], "");
                }
                if (RepSound.Items.Count == 0 && RepVideo.Items.Count == 0)
                {
                    dataPaging1.Visible = false;
                }
            }
        }

        public void repBind()
        {
            if (Request.Params["TutorialType"] == "Sound")
            {
                PanelSound.Visible = true;
                PanelVideo.Visible = false;
                RepSound.DataSource = sb.selSearchSound(Request.Params["TypeID"], "", dataPaging1.PageIndex, dataPaging1.PageSize);
                RepSound.DataBind();
            }
            else
            {
                PanelSound.Visible = false;
                PanelVideo.Visible = true;
                RepVideo.DataSource = vb.selSearchVideo(Request.Params["TypeID"], "", dataPaging1.PageIndex, dataPaging1.PageSize);
                RepSound.DataBind();
            }
        }
    }
}