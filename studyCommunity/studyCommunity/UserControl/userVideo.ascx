<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userVideo.ascx.cs" Inherits="studyCommunity.userVideo" %>
<link type="text/css" rel="Stylesheet" href="../css/StyleSheet1.css" />
<table>
    <tr>
        <td class="userVideo">
        </td>
    </tr>
    <tr>
        <td>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <a href='../seeTutorial.aspx?TutorialType=Video&TutorialID=<%#Eval("VideoID")%>' style="text-decoration: none; color: #000000"><%#Eval("VideoName")%></a>
                    <%#Eval("TypeName")%>
                    <%#Eval("ClickSum")%>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </td>
    </tr>
</table>