using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;
namespace studyCommunity
{
    public partial class manage_user : System.Web.UI.Page
    {
        LoginBll lb = new LoginBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvBind();
            }
        }

        private void gvBind()
        {
            GridView1.DataSource = lb.selLogin();
            GridView1.DataKeyNames = new string[] { "ID" };
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridView1.PageIndex = e.NewSelectedIndex;
            gvBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btnLock")
            {

                    lb.updateLockLogin(e.CommandArgument.ToString());
                
            }
            gvBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            lb.delLogin(id);
            gvBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType==DataControlRowType.DataRow)
            {
                ImageButton ib = (ImageButton)e.Row.Cells[1].FindControl("ImageButton1");
                LinkButton btn = (LinkButton)e.Row.Cells[3].FindControl("LinkButton1");
                if (btn.Text == "0")
                {
                    btn.Text = "加锁";
                    ib.ImageUrl = "~/images/kaisuo.gif";
                }
                else
                {
                    btn.Text = "解锁";
                    ib.ImageUrl = "~/images/suo.gif";
                }
            }
        }
    }
}