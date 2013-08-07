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
    public partial class manage_inssuanceTutorial : System.Web.UI.Page
    {
        TypeBll tb = new TypeBll();
        SoundBll sb = new SoundBll();
        VideoBll vb = new VideoBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlBind();
            }
        }

        private void ddlBind()
        {
            ddlType.DataSource = tb.selType();
            ddlType.DataTextField = "TypeName";
            ddlType.DataValueField = "TypeID";
            ddlType.DataBind();
            ddlType.Items.Insert(0, "请选择课程类型");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtContainer.Text = "";
            txtTitle.Text = "";
            rdoVideo.Checked = true;
            ddlBind();
        }

        protected void btnInssuance_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlType.SelectedIndex == 0)
                {
                    Response.Write("<script>alert('请选择课程类型')</script>");
                }
                else
                {
                    string fileName = FileUpload1.FileName;
                    string newFileName = Guid.NewGuid().ToString() + fileName.Substring(fileName.LastIndexOf("."));
                    if (rdoVideo.Checked == true)
                    {
                        string filePath = Server.MapPath("../video/");
                        FileUpload1.SaveAs(filePath + newFileName);
                        tb_Video video = new tb_Video();
                        video.VideoContent = txtContainer.Text;
                        video.VideoName = txtTitle.Text;
                        video.VideoUrl = filePath + newFileName;
                        video.Name = Session["UserName"].ToString();
                        video.VideoType = Convert.ToInt32(ddlType.SelectedIndex);
                        vb.addVideo(video);
                    }
                    else
                    {
                        string filePath = Server.MapPath("../sound/");
                        FileUpload1.SaveAs(filePath + newFileName);
                        tb_Sound sound = new tb_Sound();
                        sound.SoundContent = txtContainer.Text;
                        sound.SoundName = txtTitle.Text;
                        sound.SoundUrl = filePath + newFileName;
                        sound.Name = Session["UserName"].ToString();
                        sound.SoundType = Convert.ToInt32(ddlType.SelectedIndex);
                        sb.addSound(sound);
                    }
                    Response.Write("上传成功");
                }
            }
            catch (Exception ee)
            {
                Response.Write(ee.Message);
                throw;
            }
        }
    }
}