using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyBll;

namespace studyCommunity
{
    public partial class seekPassWord : System.Web.UI.Page
    {
        LoginBll lb = new LoginBll();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            txtPsw.Text = lb.getPass(txtUser.Text, txtSoul.Text, txtQues.Text);
            if (txtPsw.Text=="")
            {
                Response.Write("<script>alert('密码获取失败！');location='seekPassWord.aspx'</script>");
            }
        }
    }
}