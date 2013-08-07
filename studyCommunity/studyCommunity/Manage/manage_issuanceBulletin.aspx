<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_issuanceBulletin.aspx.cs" Inherits="studyCommunity.manage_issuanceBulletin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%" border="1" cellspacing="0" >
            <tr>
                <td colspan="2" style="color:Purple; font-family:黑体; font-size:25px">
                    发布公告
                </td>
            </tr>
            <tr>
                <td align="center">
                    公告标题：
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" Width="300px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center">
                    公告内容：
                </td>
                <td>
                    <asp:TextBox ID="txtContainer" runat="server" Height="150px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center">
                    公告人：
                </td>
                <td>
                    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnIssuance" runat="server" Text="发布" 
                        onclick="btnIssuance_Click" />
                    &nbsp;
                    <asp:Button ID="btnClear" runat="server" Text="重置" onclick="btnClear_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
