using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;

namespace studyCommunity
{
    public partial class manage_sound : System.Web.UI.Page
    {
        SoundBll sb = new SoundBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvBind();
            }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridView1.PageIndex = e.NewSelectedIndex;
            gvBind();
        }

        private void gvBind()
        {
            GridView1.DataSource = sb.selSound();
            GridView1.DataKeyNames = new string[] { "SoundID" };
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int soundID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            if (sb.delSound(soundID) > 0)
            {
                Response.Write("删除成功！");
            }
            gvBind();
        }
    }
}