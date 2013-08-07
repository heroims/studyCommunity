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
    public partial class Registe : System.Web.UI.Page
    {
        LoginBll lb = new LoginBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            tb_login login = new tb_login();
            if (txtUser.Text.Trim() != "")
            {
                if (lb.isUserName(txtUser.Text.Trim()))
                {
                    login.Name = txtUser.Text;
                    login.Pass = txtPsw1.Text;
                    if (rdoMan.Checked)
                    {
                        login.Sex = "男";
                    }
                    else
                    {
                        login.Sex = "女";
                    }
                    login.PassSolution = txtSolu.Text;
                    login.PassQuestion = txtQues.Text;
                    login.Zname = txtTureName.Text;
                    login.Idcard = txtPersonNum.Text;
                    login.Email = txtMail.Text;
                    if (lb.addLogin(login) > 0)
                    {
                        Session["UserName"] = login.Name;
                        Response.Write("<script>alert('注册成功！');location='index.aspx'</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('注册失败！')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('用户名已存在！');location='Registe.aspx'</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('用户名不能为空！');location='Registe.aspx'</script>");
            }
        }

        protected void btnCan_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}