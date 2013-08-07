<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userSound.ascx.cs" Inherits="studyCommunity.userSound" %>
<link type="text/css" rel="Stylesheet" href="../css/StyleSheet1.css" />
<table>
    <tr>
        <td class="userSound">
        </td>
    </tr>
    <tr>
        <td>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <a href='../seeTutorial.aspx?TutorialType=Sound&TutorialID=<%#Eval("SoundID")%>' style="text-decoration: none; color: #000000"><%#Eval("SoundName")%></a>
                    <%#Eval("TypeName")%>
                    <%#Eval("ClickSum")%>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </td>
    </tr>
</table>