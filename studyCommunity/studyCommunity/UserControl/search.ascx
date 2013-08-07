<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="search.ascx.cs" Inherits="studyCommunity.search" %>
<link type="text/css" rel="Stylesheet" href="../css/StyleSheet1.css" />
<table>
    <tr>
        <td colspan="4" class="search">
        </td>
    </tr>
    <tr>
        <td>
            教程类型
            <asp:DropDownList ID="ddlTutorialType" runat="server">
                <asp:ListItem Value="请选择教程类型">请选择教程类型</asp:ListItem>
                <asp:ListItem Value="Sound">语音</asp:ListItem>
                <asp:ListItem Value="Video">视频</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            语言
            <asp:DropDownList ID="ddlType" runat="server">
            </asp:DropDownList>
        </td>
        <td>
            关键字
         
            <asp:TextBox ID="txtKeyWord" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/images/sousuo.gif" 
                onclick="btnSearch_Click" />
        </td>
    </tr>
</table>