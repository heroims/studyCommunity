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
    public partial class manage_issuanceBulletin : System.Web.UI.Page
    {
        BulletinBll ibb = new BulletinBll();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIssuance_Click(object sender, EventArgs e)
        {
            tb_Bulletin bull = new tb_Bulletin();
            bull.Title = txtTitle.Text;
            bull.Content = txtContainer.Text;
            bull.Name = txtUser.Text;
            if (ibb.addBulletin(bull) > 0)
            {
                Response.Write("添加成功！");
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtContainer.Text = "";
            txtUser.Text = "";
        }
    }
}