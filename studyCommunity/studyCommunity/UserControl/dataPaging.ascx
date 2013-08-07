<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dataPaging.ascx.cs" Inherits="studyCommunity.UserControl.dataPaging" %>
<div style="width:100%">
    当前页码为：[<asp:Label ID="lblPageIndex" runat="server" Text="1"></asp:Label>]
    总页码为：[<asp:Label ID="lblPageCount" runat="server" Text=""></asp:Label>]
    <asp:LinkButton ID="btnFirst" runat="server" onclick="btnFirst_Click" 
        Font-Underline="False" ForeColor="Red">首页</asp:LinkButton>
    <asp:LinkButton ID="btnUp" runat="server" onclick="btnUp_Click" 
        Font-Underline="False" ForeColor="Red">上一页</asp:LinkButton>
    <asp:LinkButton ID="btnDown" runat="server" onclick="btnDown_Click" 
        Font-Underline="False" ForeColor="Red">下一页</asp:LinkButton>
    <asp:LinkButton ID="btnLast" runat="server" onclick="btnLast_Click" 
        Font-Underline="False" ForeColor="Red">末页</asp:LinkButton>
    <asp:TextBox ID="txtPageIndex" runat="server" Width="21px"></asp:TextBox>
    <asp:LinkButton ID="btnGo" runat="server" onclick="btnGo_Click" 
        Font-Underline="False" ForeColor="Red">GO</asp:LinkButton>
</div>