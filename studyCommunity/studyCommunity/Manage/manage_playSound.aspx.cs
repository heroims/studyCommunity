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
    public partial class manage_playSound : System.Web.UI.Page
    {
        SoundBll soundb = new SoundBll();
        SpeakBll speakb = new SpeakBll();

        string _sUrl;

        public string SUrl
        {
            get { return _sUrl; }
            set { _sUrl = value; }
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
            tb_Sound sound = new tb_Sound();
            sound = soundb.selOneSound(Convert.ToInt32(Request.Params["SoundID"]));
            SUrl = sound.SoundUrl;
            lblClickSum.Text = sound.ClickSum.ToString();
            lblFBDate.Text = sound.FBDate.ToString();
            lblName.Text = sound.Name;
            lblVideoName.Text = sound.SoundName;
            txtContent.Text = sound.SoundContent;
        }

        protected void btnInssuance_Click(object sender, EventArgs e)
        {
            tb_Speak speak = new tb_Speak();
            speak.Speakman = Session["UserName"].ToString();
            speak.TutorialType = "Sound";
            speak.TutorialID = Convert.ToInt32(Request.Params["SoundID"]);
            speak.SpeakContent = txtContainer.Text;
            speakb.addSpeak(speak);
        }
    }
}