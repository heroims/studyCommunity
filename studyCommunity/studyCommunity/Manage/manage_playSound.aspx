<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_playSound.aspx.cs" Inherits="studyCommunity.manage_playSound" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <embed src="<%=SUrl%>" style="width: 350px; height: 40px" ></embed>
        <table style="width: 100%;"  cellspacing="0">
            <tr>
                <td> 
                </td>
                <td colspan="2">
                    <strong style="color:Blue">视频名称:</strong>
                    <asp:Label ID="lblVideoName" runat="server"></asp:Label>
                    &nbsp;&nbsp;
                    点击率:
                    <asp:Label ID="lblClickSum" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    内容简介：
                </td>
                <td colspan="2" rowspan="3">
                    <asp:TextBox ID="txtContent" Width="100%" Rows="3" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td align="right">
                    发布人：
                </td>
                <td>
                    <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td align="right">
                    发布日期：
                </td>
                <td>
                    <asp:Label ID="lblFBDate" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td valign="top" colspan="2">
                    留言内容：
                 
                    <asp:TextBox ID="txtContainer" runat="server" Height="135px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td align="center">
                    <asp:Button ID="btnInssuance" runat="server" Text="发  言" 
                        onclick="btnInssuance_Click" />
                </td>
            </tr>
            </table>
    </div>
    </form>
</body>
</html>
