<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="bulletinInfo.aspx.cs" Inherits="studyCommunity.bulletinInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%" border="1" cellpadding="0" cellspacing="0">
        <tr>
            <td align="center" style="font-family: 黑体; font-size: 20px;">
                标题：<asp:Label ID="lblTitle" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" 
                    ReadOnly="True" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                公告人：<asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
                公告时间：<asp:Label ID="lblDate" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
