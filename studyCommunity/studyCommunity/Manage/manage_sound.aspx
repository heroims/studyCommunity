<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_sound.aspx.cs" Inherits="studyCommunity.manage_sound" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="White" 
            BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" 
            GridLines="None" onselectedindexchanging="GridView1_SelectedIndexChanging" 
            onrowdeleting="GridView1_RowDeleting" PageSize="5">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="SoundID" 
                    DataNavigateUrlFormatString="manage_playSound.aspx?SoundID={0}" 
                    DataTextField="SoundName" HeaderText="语音名称">
                <ControlStyle Font-Underline="False" />
                </asp:HyperLinkField>
                <asp:BoundField HeaderText="发布日期" DataField="FBDate" />
                <asp:HyperLinkField HeaderText="管理留言" Text="管理" DataNavigateUrlFields="SoundID" 
                    DataNavigateUrlFormatString="manage_soundSpeak.aspx?SoundID={0}">
                <ControlStyle Font-Underline="False" />
                </asp:HyperLinkField>
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
