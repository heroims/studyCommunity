using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using StudyBll;

namespace studyCommunity
{
    /// <summary>
    /// WSValidate 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    [System.Web.Script.Services.ScriptService]
    public class WSValidate : System.Web.Services.WebService
    {
        [WebMethod]
        public string isUserName(string user)
        {
            LoginBll lb = new LoginBll();
            if (user.Trim()=="")
            {
                return "用户名不能为空";
            }
            else
            {
                if (lb.isUserName(user))
                {
                    return "恭喜用户名可用";
                }
                else
                {
                    return "用户名已用";
                }
            }
        }
    }
}
