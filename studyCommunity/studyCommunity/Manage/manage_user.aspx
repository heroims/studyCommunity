<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_user.aspx.cs" Inherits="studyCommunity.manage_user" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
            CellPadding="3" CellSpacing="1" GridLines="None" AllowPaging="True" 
            onselectedindexchanging="GridView1_SelectedIndexChanging" 
            onrowcommand="GridView1_RowCommand" onrowdeleting="GridView1_RowDeleting" 
            onrowdatabound="GridView1_RowDataBound">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="用户名" />
                <asp:TemplateField HeaderText="状态" ShowHeader="False">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="false" 
                            CommandName="" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="LoginDate" HeaderText="注册时间" />
                <asp:TemplateField HeaderText="操作" ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                            CommandName="btnLock" Font-Underline="False" Text='<%# Eval("_lock1") %>' 
                            CommandArgument='<%# Eval("Name") %>'></asp:LinkButton>
                    </ItemTemplate>
                    <ControlStyle Font-Underline="False" />
                </asp:TemplateField>
                <asp:CommandField HeaderText="删除" ControlStyle-Font-Underline="false" 
                    ShowDeleteButton="True" >
                    <ControlStyle Font-Underline="False"></ControlStyle>
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
