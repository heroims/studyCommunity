<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_videoSpeak.aspx.cs" Inherits="studyCommunity.manage_videoSpeak" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server" 
            onitemcommand="DataList1_ItemCommand">
            <ItemTemplate>
                <table border="1" cellspacing="0" style="width:100%;">
                    <tr>
                        <td>
                            发言人：
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Speakman") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr valign="top">
                        <td>
                            发言内容：
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtContainer" runat="server" Height="100px" 
                                TextMode="MultiLine" Width="300px" Text='<%# Bind("SpeakContent") %>' 
                                ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            发言时间:
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("SpeakDate") %>'></asp:Label>
                        </td>
                        <td align="right">
                            <asp:LinkButton ID="btnDel" runat="server" Font-Underline="False" 
                                CommandName="btnDel" CommandArgument='<%# Bind("SpeakID") %>'>【删除】</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        当前页码为：[<asp:Label ID="lblPageIndex" runat="server" Text="1"></asp:Label>]
        总页码为：[<asp:Label ID="lblPageCount" runat="server"></asp:Label>]
        <asp:LinkButton ID="btnFirstPage" runat="server" Font-Underline="False" 
            ForeColor="Red" onclick="btnFirstPage_Click">第一页</asp:LinkButton>
        <asp:LinkButton ID="btnUpPage" runat="server" Font-Underline="False" 
            ForeColor="Red" onclick="btnUpPage_Click">上一页</asp:LinkButton>
        <asp:LinkButton ID="btnDownPage" runat="server" Font-Underline="False" 
            ForeColor="Red" onclick="btnDownPage_Click">下一页</asp:LinkButton>
        <asp:LinkButton ID="btnLastPage" runat="server" Font-Underline="False" 
            ForeColor="Red" onclick="btnLastPage_Click">最后一页</asp:LinkButton>
    </div>
    </form>
</body>
</html>
