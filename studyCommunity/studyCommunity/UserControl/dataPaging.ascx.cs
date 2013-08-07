using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace studyCommunity.UserControl
{
    public delegate void degeGvBind();

    public partial class dataPaging : System.Web.UI.UserControl
    {
        public event degeGvBind GvBind;

        public int PageSize
        {
            get
            {
                if (ViewState["pageSize"] == null)
                {
                    return 5;
                }
                else
                {
                    return (int)ViewState["pageSize"];
                }
            }
            set { ViewState["pageSize"] = value; }
        }

        public int PageIndex
        {
            get
            {
                if (ViewState["pageIndex"] == null)
                {
                    return 1;
                }
                else
                {
                    return (int)ViewState["pageIndex"];
                }
            }
            set { ViewState["pageIndex"] = value; }
        }

        public int Count
        {
            get
            {
                if (ViewState["count"] == null)
                {
                    return 0;
                }
                else
                {
                    return (int)ViewState["count"];
                }
            }
            set { ViewState["count"] = value; }
        }

        public int PageCount
        {
            get
            {
                if (Count % PageSize == 0)
                {
                    return Count / PageSize;
                }
                else
                {
                    return Count / PageSize + 1;
                }
            }
        }

        private void bindlbl()
        {
            lblPageCount.Text = PageCount.ToString();
            lblPageIndex.Text = PageIndex.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (GvBind != null)
                {
                    GvBind();
                }
                bindlbl();
            }
        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            if (GvBind != null)
            {
                GvBind();
            }
            bindlbl();
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            if (PageIndex > 1)
            {
                PageIndex--;
            }
            if (GvBind != null)
            {
                GvBind();
            }
            bindlbl();
        }

        protected void btnDown_Click(object sender, EventArgs e)
        {
            if (PageIndex < PageCount)
            {
                PageIndex++;
            }
            if (GvBind != null)
            {
                GvBind();
            }
            bindlbl();
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            PageIndex = PageCount;
            if (GvBind != null)
            {
                GvBind();
            }
            bindlbl();
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPageIndex.Text) >= 1 && Convert.ToInt32(txtPageIndex.Text) <= PageCount)
            {
                PageIndex = Convert.ToInt32(txtPageIndex.Text);
            }
            if (GvBind != null)
            {
                GvBind();
            }
            bindlbl();
        }
    }
}