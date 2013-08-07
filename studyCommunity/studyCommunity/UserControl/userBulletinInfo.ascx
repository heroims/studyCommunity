<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userBulletinInfo.ascx.cs" Inherits="studyCommunity.userBulletinInfo" %>
<link type="text/css" rel="Stylesheet" href="../css/StyleSheet1.css" />
<table>
    <tr>
        <td class="userBulletinInfo">
        </td>
    </tr>
    <tr>
        <td>
            <marquee direction="up" onmouseout="this.start()" onmouseover="this.stop()" scrollamount="2">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <a href='../bulletinInfo.aspx?ID=<%#Eval("ID")%>' style="text-decoration:none">
                            <%#Eval("Title")%>
                            <%#Eval("Date")%>
                        </a>
                        <br />
                        <br />
                    </ItemTemplate>
                </asp:Repeater>
            </marquee>
        </td>
    </tr>
</table>