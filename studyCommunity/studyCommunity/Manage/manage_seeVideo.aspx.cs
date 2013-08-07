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
    public partial class manage_seeVideo : System.Web.UI.Page
    {
        VideoBll vb = new VideoBll();
        SpeakBll sb = new SpeakBll();
        string _vUrl;

        public string VUrl
        {
            get { return _vUrl; }
            set { _vUrl = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dataSouceBind();
            }
        }

        private void dataSouceBind()
        {
            tb_Video video = new tb_Video();
            video = vb.selOneVideo(Convert.ToInt32(Request.Params["VideoID"]));
            VUrl = video.VideoUrl;
            lblClickSum.Text = video.ClickSum.ToString();
            lblFBDate.Text = video.FBDate.ToString();
            lblName.Text = video.Name;
            lblVideoName.Text = video.VideoName;
            txtContent.Text = video.VideoContent;
        }

        protected void btnInssuance_Click(object sender, EventArgs e)
        {
            tb_Speak speak = new tb_Speak();
            speak.Speakman = Session["UserName"].ToString();
            speak.TutorialType = "Video";
            speak.TutorialID = Convert.ToInt32(Request.Params["VideoID"]);
            speak.SpeakContent = txtContainer.Text;
            sb.addSpeak(speak);
        }
    }
}