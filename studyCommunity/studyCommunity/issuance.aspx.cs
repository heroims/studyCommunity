using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyModel;
using StudyBll;
using System.IO;

namespace studyCommunity
{
    public partial class issuance : System.Web.UI.Page
    {
        TypeBll tb = new TypeBll();
        SoundBll sb = new SoundBll();
        VideoBll vb = new VideoBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PanelFB.Visible = false;
                PanelYsound.Visible = false;
                PanelYvideo.Visible = false;
                if (Session["UserName"]==null)
                {
                    Response.Write("<script>alert('请先登录用户!');location='index.aspx'</script>");
                }
                else
                {
                    PanelFB.Visible = true;
                    ddlBind();
                }     
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

        private void gvSoundBind()
        {
            gvFBSound.DataSource = sb.selMySound(Session["UserName"].ToString()).Tables[0];
            gvFBSound.DataKeyNames = new string[] { "SoundID" };
            gvFBSound.DataBind();
        }

        private void gvVideoBind()
        {
            gvFBVideo.DataSource = vb.selMyVideo(Session["UserName"].ToString()).Tables[0];
            gvFBVideo.DataKeyNames = new string[] { "VideoID" };
            gvFBVideo.DataBind();
        }

        protected void btnIssuanced_Click(object sender, EventArgs e)
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
                        string filePath = Server.MapPath("./video/");
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
                        string filePath = Server.MapPath("./sound/");
                        FileUpload1.SaveAs(filePath + newFileName);
                        tb_Sound sound = new tb_Sound();
                        sound.SoundContent = txtContainer.Text;
                        sound.SoundName = txtTitle.Text;
                        sound.SoundUrl = filePath + newFileName;
                        sound.Name = Session["UserName"].ToString();
                        sound.SoundType = Convert.ToInt32(ddlType.SelectedIndex);
                        sb.addSound(sound);
                    }
                    Response.Write("<script>alert('上传成功')</script>");
                    Response.AddHeader("Refresh", "0");
                }
            }
            catch (Exception ee)
            {
                Response.Write(ee.Message);
                throw;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtContainer.Text = "";
            txtTitle.Text = "";
            rdoVideo.Checked = true;
            ddlBind();
        }

        protected void btnExit_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnIssuance_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["UserName"]!=null)
            {
                ddlBind();
                PanelFB.Visible = true;
                PanelYsound.Visible = false;
                PanelYvideo.Visible = false;
            }
        }

        protected void btnIssuancedVideo_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["UserName"]!=null)
            {
                PanelFB.Visible = false;
                PanelYsound.Visible = false;
                PanelYvideo.Visible = true;
                gvVideoBind();
            }
        }

        protected void btnIssuancedSound_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["UserName"] != null)
            {
                PanelFB.Visible = false;
                PanelYsound.Visible = true;
                PanelYvideo.Visible = false;
                gvSoundBind();
            }
        }

        protected void gvFBVideo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvFBVideo.DataKeys[e.RowIndex].Value);
            File.Delete(vb.selVideoUrl(id));
            if (vb.delVideo(id) > 0)
            {
                Response.Write("<script>alert('删除成功！')</script>");      
            }
            gvVideoBind();
        }

        protected void gvFBSound_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvFBSound.DataKeys[e.RowIndex].Value);
            File.Delete(sb.selSoundUrl(id));
            if (sb.delSound(id) > 0)
            {
                Response.Write("<script>alert('删除成功！')</script>");
            }
            gvSoundBind();
        }
    }
}