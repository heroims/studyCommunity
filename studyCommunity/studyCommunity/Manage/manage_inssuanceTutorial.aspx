<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_inssuanceTutorial.aspx.cs" Inherits="studyCommunity.manage_inssuanceTutorial" %>

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
                    发布教程
                </td>
            </tr>
            <tr>
                <td align="center">
                    教程名称：
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" Width="300px" ></asp:TextBox>
                </td>
                <td style="color:Red">
                   必须填写 
                </td>
            </tr>
            <tr>
                <td align="center">
                    教程类型：
                </td>
                <td>
                    <asp:RadioButton ID="rdoVideo" runat="server" Checked="True" Text="视频" GroupName="teachStyle" />
                    <asp:RadioButton ID="rdoSound" runat="server" Text="语音" GroupName="teachStyle" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    课程类型：
                </td>
                <td>
                    <asp:DropDownList ID="ddlType" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="center">
                    内容简介：
                </td>
                <td>
                    <asp:TextBox ID="txtContainer" runat="server" Height="180px" TextMode="MultiLine" 
                        Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center">
                    上传教程：
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnInssuance" runat="server" Text="发布" 
                        onclick="btnInssuance_Click" />
                    &nbsp;
                    <asp:Button ID="btnClear" runat="server" Text="重置" onclick="btnClear_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
