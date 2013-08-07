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
    public partial class bulletinInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BulletinBll bb = new BulletinBll();
                tb_Bulletin bull = bb.selOneBulletin(Convert.ToInt32(Request.Params["ID"]));
                lblTitle.Text = bull.Title;
                lblDate.Text = bull.Date.ToString();
                lblName.Text = bull.Name;
                txtContent.Text = bull.Content;
            }
        }
    }
}