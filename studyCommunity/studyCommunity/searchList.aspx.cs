using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;

namespace studyCommunity
{
    public partial class searchList : System.Web.UI.Page
    {
        SoundBll sb = new SoundBll();
        VideoBll vb = new VideoBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Params["TutorialType"] == "Sound")
                {
                    dataPaging1.Count = sb.getSearchSoundCount(Request.Params["TypeID"], Request.Params["SearchKey"]);
                }
                else
                {
                    dataPaging1.Count = vb.getSearchVideoCount(Request.Params["TypeID"], Request.Params["SearchKey"]);
                }
                if (dataPaging1.Count == 0)
                {
                    dataPaging1.Visible = false;
                    PanelNone.Visible = true;
                }
            }
        }

        public void repBind()
        {
            if (Request.Params["TutorialType"] == "Sound")
            {
                PanelSound.Visible = true;
                PanelVideo.Visible = false;
                PanelNone.Visible = false;
                RepSound.DataSource = sb.selSearchSound(Request.Params["TypeID"], Request.Params["SearchKey"], dataPaging1.PageIndex, dataPaging1.PageSize);
                RepSound.DataBind();
            }
            else
            {
                PanelSound.Visible = false;
                PanelVideo.Visible = true;
                PanelNone.Visible = false;
                RepVideo.DataSource = vb.selSearchVideo(Request.Params["TypeID"], Request.Params["SearchKey"], dataPaging1.PageIndex, dataPaging1.PageSize);
                RepSound.DataBind();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}