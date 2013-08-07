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
    public partial class entry : System.Web.UI.UserControl
    {
        LoginBll lb = new LoginBll();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, ImageClickEventArgs e)
        {
            tb_login login=new tb_login();
            login.Name=txtUser.Text;
            login.Pass=txtPsw.Text;
            if (txtCheckNum.Text==Session["ValidateCode"].ToString())
            {
                if (lb.isLogin(login))
                {
                    Session["UserName"] = login.Name;
                    Response.AddHeader("Refresh", "0"); 
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                    Response.AddHeader("Refresh", "0"); 
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