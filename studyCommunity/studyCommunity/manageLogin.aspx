<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manageLogin.aspx.cs" Inherits="studyCommunity.manageLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/StyleSheet1.css" type="text/css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image:url(images/bei.GIF)">
        <div class="manageLogin">
            <table style="margin-left: 235px; margin-top: 110px; width:220; height: 100px;">
                <tr>
                    <td align="right">
                        用户名：
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtUser" runat="server" Width="125px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        密 码：
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtPsw" runat="server" Width="125px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="~/images/dengl.jpg" 
                            onclick="btnLogin_Click" />
                        &nbsp;
                        <asp:ImageButton ID="btnCan" runat="server" ImageUrl="~/images/quxiao.jpg" 
                            onclick="btnCan_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
