<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manageIndex.aspx.cs" Inherits="studyCommunity.manageIndex" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function winClose() {
            if (confirm("确定要关闭网页吗？")) { 
                window.close(); 
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:0 auto; width:830px;">
        <map id="logmap" name="map" >
            <area alt="关闭系统" shape="rect" coords="681, 5, 746, 30" href="javascript:winClose()" />
            <area alt="重新登录" shape="rect" coords="746, 5, 808, 30" href="../manageLogin.aspx" />
            <area alt="网站首页" shape="rect" coords="636, 109, 724, 137" href="../index.aspx" />
            <area alt="退出登录" shape="rect" coords="724, 109, 811, 142" href="../manageLogin.aspx" />
        </map>
        <img src="../images/manageIndex_01.jpg" alt="manageIndex_01" usemap="#map" />
        <div style=" float:left; width:30%">
            <img src="../images/manageIndex_02.jpg" alt="manageIndex_02" width="100%" height="34px" />
            <iframe name="leftMenu" src="leftMenu.aspx" width="100%" style="height: 500px"></iframe>
        </div>
        <div  style=" float:right; width:70%">
            <img src="../images/manageIndex_03.jpg" alt="manageIndex_03" width="100%" height="34px" />
            <iframe name="rightMenu" src="rightMenu.aspx" width="100%" style="height: 500px"></iframe>
        </div>
        <div style="float:inherit; width:100%" align="center">
            客户服务中心热线：0431-****8981 Copynight 2007(C)******科技有限公司
        </div>
    </div>
    </form>
</body>
</html>
