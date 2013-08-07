using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyModel;
using StudyBll;

namespace studyCommunity
{
    public partial class manageLogin : System.Web.UI.Page
    {
        LoginBll lb = new LoginBll();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, ImageClickEventArgs e)
        {
            if (txtUser.Text.Trim() != "" && txtPsw.Text.Trim()!="")
            {
                tb_login login = new tb_login();
                login.Name = txtUser.Text.Trim();
                login.Pass = txtPsw.Text.Trim();
                if (lb.isLogin(login))
                {
                    Session["UserName"] = login.Name;
                    Response.Redirect("Manage/manageIndex.aspx");
                }
                else
                {
                    Response.Write("<script>alert('登陆失败！');location='manageLogin.aspx'</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('用户名或密码不能为空！');location='manageLogin.aspx'</script>");
            }
        }

        protected void btnCan_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}