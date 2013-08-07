<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leftMenu.aspx.cs" Inherits="studyCommunity.leftMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function show(obj, idvalue) {
            var d = document.getElementById(idvalue);
            if (d.style.display == "none") {
                obj.style.backgroundImage = "url(../images/menudown.gif)";
                d.style.display = "";
            }
            else {
                obj.style.backgroundImage = "url(../images/menuup.gif)";
                d.style.display = "none";
            }
        }
    </script>
</head>
<body style="background:799ae1">
    <form id="form1" runat="server">
    <div>
        <table style="width: 158px;">
            <tr>
                <td onclick="show(this,'message')" style="color:Blue; font-family:黑体; background-image: url('../images/menudown.gif')" >
                    公告管理
                </td>
            </tr>
            <tr>
                <td>
                    <div id="message">
                        <a href="manage_issuanceBulletin.aspx" target="rightMenu" style="text-decoration: none">&nbsp;发布公告</a>
                        <br />
                        <a href="manage_bulletin.aspx" target="rightMenu" style="text-decoration: none">&nbsp;公告管理</a>
                    </div>
                </td> 
            </tr>
            <tr>
                <td onclick="show(this,'teach')" style="color:Blue; font-family:黑体; background-image: url('../images/menudown.gif')">
                    教程管理
                </td>
            </tr>
            <tr>
                <td>
                    <div id="teach">
                        <a href="manage_inssuanceTutorial.aspx" target="rightMenu" style="text-decoration: none">&nbsp;发布教程</a>
                        <br />
                        <a href="manage_video.aspx" target="rightMenu" style="text-decoration: none">&nbsp;视频管理</a>
                        <br />
                        <a href="manage_sound.aspx" target="rightMenu" style="text-decoration: none">&nbsp;语音管理</a>
                    </div>
                </td> 
            </tr>
            <tr>
                <td onclick="show(this,'user')" style="color:Blue; font-family:黑体; background-image: url('../images/menudown.gif')">
                    用户管理
                </td>
            </tr>
            <tr>
                <td>
                    <div id="user">
                        <a href="manage_user.aspx" target="rightMenu" style="text-decoration: none">&nbsp;用户管理</a>
                    </div>
                </td> 
            </tr>
            <tr>
                <td>
                    <img src="../images/www.GIF" alt="www.GIF" width="158" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
