<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_bulletin.aspx.cs" Inherits="studyCommunity.manage_bulletin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong style="color:Green; font-size:20px">公告管理</strong>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" 
            BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" 
            CellSpacing="1" GridLines="None" AllowPaging="True" 
            AutoGenerateColumns="False" 
            onselectedindexchanging="GridView1_SelectedIndexChanging" 
            onrowdeleting="GridView1_RowDeleting" PageSize="5">
            <Columns>
                <asp:HyperLinkField DataTextField="Title" HeaderText="公告标题" />
                <asp:BoundField DataField="Date" HeaderText="发布日期" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
                <ControlStyle Font-Underline="False" />
                </asp:CommandField>
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
