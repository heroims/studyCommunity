<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="searchList.aspx.cs" Inherits="studyCommunity.searchList" %>
<%@ Register src="UserControl/dataPaging.ascx" tagname="dataPaging" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PanelSound" runat="server">
        <asp:Repeater ID="RepSound" runat="server">
            <HeaderTemplate>
                <table width="100%">
                    <tr>
                        <td>
                            语音名称
                        </td>
                        <td>
                            发布日期
                        </td>
                        <td>
                            发布人
                        </td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <a href='seeTutorial.aspx?TutorialType=Sound&TutorialID=<%#Eval("SoundID")%>' style="text-decoration: none; color: #000000"><%#Eval("SoundName")%></a>
                    </td>
                    <td>
                        <%#Eval("FBDate")%>
                    </td>
                    <td>
                        <%#Eval("Name")%>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </asp:Panel>
    <asp:Panel ID="PanelVideo" runat="server">
        <asp:Repeater ID="RepVideo" runat="server">
            <HeaderTemplate>
                <table width="100%">
                    <tr>
                        <td>
                            视频名称
                        </td>
                        <td>
                            发布日期
                        </td>
                        <td>
                            发布人
                        </td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <a href='seeTutorial.aspx?TutorialType=Video&TutorialID=<%#Eval("VideoID")%>' style="text-decoration: none; color: #000000"><%#Eval("VideoName")%></a>
                    </td>
                    <td>
                        <%#Eval("FBDate")%>
                    </td>
                    <td>
                        <%#Eval("Name")%>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>      
    </asp:Panel>
    <uc1:dataPaging ID="dataPaging1" runat="server" OnGvBind="repBind" />
    <asp:Panel ID="PanelNone" runat="server">
        <h1>查询的教程不存在！请返回。</h1>
        <asp:LinkButton ID="btnBack" runat="server" onclick="btnBack_Click">返回</asp:LinkButton>
    </asp:Panel>
</asp:Content>
