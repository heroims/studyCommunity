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
    public partial class manage_videoSpeak : System.Web.UI.Page
    {
        SpeakBll sb = new SpeakBll();

        public int Count
        {
            get { return (int)ViewState["pageCount"]; }
            set { ViewState["pageCount"] = value; }
        }

        public int PageCount
        {
            get 
            {
                if (Count%5==0)
                {
                    return Count / 5;
                }
                else
                {
                    return Count / 5 + 1;
                }
            }
        }

        public int PageIndex 
        {
            get { return (int)ViewState["pageIndex"]; }
            set { ViewState["pageIndex"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageIndex = Convert.ToInt32(lblPageIndex.Text);
                gvBind();
            }
        }

        private void lblBind()
        {
            lblPageCount.Text = PageCount.ToString();
            lblPageIndex.Text = PageIndex.ToString();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "btnDel")
            {
                sb.delSpeak((int)e.CommandArgument);
            }
        }

        private void gvBind()
        {
            int videoID = Convert.ToInt32(Request.Params["videoID"]);
            Count = sb.getPageCount("Video", videoID);
            DataList1.DataSource = sb.selPagingSpeak("Video", videoID, PageIndex, 5);
            DataList1.DataBind();
            lblBind();
        }

        protected void btnFirstPage_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            gvBind();
        }

        protected void btnLastPage_Click(object sender, EventArgs e)
        {
            PageIndex = PageCount;
            gvBind();
        }

        protected void btnUpPage_Click(object sender, EventArgs e)
        {
            if (PageIndex>1)
            {
                PageIndex--;
            }
            gvBind();
        }

        protected void btnDownPage_Click(object sender, EventArgs e)
        {
            if (PageIndex < PageCount)
            {
                PageIndex++;
            }
            gvBind();
        }
    }
}