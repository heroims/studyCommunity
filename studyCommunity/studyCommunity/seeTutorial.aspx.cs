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
    public partial class seeTutorial : System.Web.UI.Page
    {
        SpeakBll speakb = new SpeakBll();
        SoundBll soundb = new SoundBll();
        VideoBll videob = new VideoBll();
        string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserName"] == null)
                {
                    Response.Write("<script>alert('请先登录用户!');location='index.aspx'</script>");
                }
                dataPaging1.Count = speakb.getPageCount(Request.Params["TutorialType"], Convert.ToInt32(Request.Params["SoundID"]));
                dataSouceBind();
            }
        }

        private void dataSouceBind()
        {
            if (Request.Params["TutorialType"] == "Sound")
            {
                tb_Sound sound = new tb_Sound();
                int SoundID = Convert.ToInt32(Request.Params["TutorialID"]);
                soundb.AddClickNum(SoundID);
                sound = soundb.selOneSound(SoundID);
                Url = sound.SoundUrl;
                lblClickSum.Text = sound.ClickSum.ToString();
                lblFBDate.Text = sound.FBDate.ToString();
                lblName.Text = sound.Name;
                lblTutorialName.Text = sound.SoundName;
                txtContainer.Text = sound.SoundContent;
            }
            else
            {
                tb_Video video = new tb_Video();
                int VideoID = Convert.ToInt32(Request.Params["TutorialID"]);
                videob.AddClickNum(VideoID);
                video = videob.selOneVideo(VideoID);
                Url = video.VideoUrl;
                lblClickSum.Text = video.ClickSum.ToString();
                lblFBDate.Text = video.FBDate.ToString();
                lblName.Text = video.Name;
                lblTutorialName.Text = video.VideoName;
                txtContainer.Text = video.VideoContent;
            }
        }

        public void gvBind()
        {
            if (Request.Params["TutorialType"] == "Sound")
            {
                int soundID = Convert.ToInt32(Request.Params["TutorialID"]);
                Repeater1.DataSource = speakb.selPagingSpeak("Sound", soundID, dataPaging1.PageIndex, dataPaging1.PageSize);
                Repeater1.DataBind();
            }
            else
            {
                int videoID = Convert.ToInt32(Request.Params["TutorialID"]);
                Repeater1.DataSource = speakb.selPagingSpeak("Video", videoID, dataPaging1.PageIndex, dataPaging1.PageSize);
                Repeater1.DataBind();
            }
        }

        protected void btnDownLoad_Click(object sender, EventArgs e)
        {
            Response.Redirect(Url);
        }

        protected void btnSpeak_Click(object sender, EventArgs e)
        {
            if (txtCheck.Text==Session["ValidateCode"].ToString())
            {
                if (Request.Params["TutorialType"] == "Sound")
                {
                    tb_Speak speak = new tb_Speak();
                    speak.Speakman = Session["UserName"].ToString();
                    speak.TutorialType = "Sound";
                    speak.TutorialID = Convert.ToInt32(Request.Params["TutorialID"]);
                    speak.SpeakContent = txtLeaveContent.Text;
                    if (speakb.addSpeak(speak) > 0)
                    {
                        Response.Write("<script>alert('发言成功')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('发言失败')</script>");
                    }
                    gvBind();
                }
                else
                {
                    tb_Speak speak = new tb_Speak();
                    speak.Speakman = Session["UserName"].ToString();
                    speak.TutorialType = "Video";
                    speak.TutorialID = Convert.ToInt32(Request.Params["TutorialID"]);
                    speak.SpeakContent = txtLeaveContent.Text;
                    if (speakb.addSpeak(speak)>0)
                    {
                        Response.Write("<script>alert('发言成功')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('发言失败')</script>");
                    }
                    gvBind();
                }
            }
            else
            {
                Response.Write("<script>alert('验证码错误！')</script>");
                Response.AddHeader("Refresh", "0");
            }
        }
    }
}