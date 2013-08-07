using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;

namespace studyCommunity
{
    public delegate void btnClick();

    public partial class search : System.Web.UI.UserControl
    {
        TypeBll tb = new TypeBll();

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

        protected void btnSearch_Click(object sender, ImageClickEventArgs e)
        {
            if (ddlTutorialType.SelectedValue == "请选择教程类型")
            {
                Response.Write("<script>alert('请选择教程类型')</script>");
                Response.AddHeader("Refresh", "0"); 
            }
            else if (ddlType.SelectedIndex==0)
            {
                Response.Write("<script>alert('请选择课程类型')</script>");
                Response.AddHeader("Refresh", "0"); 
            }
            else
            {
                Response.Redirect("searchList.aspx?TutorialType=" + ddlTutorialType.SelectedValue + "&SearchKey=" + txtKeyWord.Text + "&TypeID=" + ddlType.SelectedIndex.ToString());
            }
        }
    }
}