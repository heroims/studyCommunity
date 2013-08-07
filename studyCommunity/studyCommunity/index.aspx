<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="studyCommunity.index" %>
<%@ Register src="UserControl/search.ascx" tagname="search" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:search ID="search1" runat="server" />
    <img src="images/yinpin.gif" alt="yinpin" width="557px" height="29px" />                        
    <asp:GridView ID="gvNewSound" Width="100%" runat="server" AutoGenerateColumns="False" 
        ShowHeader="False">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFormatString="seeTutorial.aspx?TutorialType=Sound&amp;TutorialID={0}" 
                DataTextField="SoundName">
            <ControlStyle Font-Underline="False" ForeColor="Black" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="TypeName" />
            <asp:BoundField DataField="FBDate" />
        </Columns>
    </asp:GridView>

    <img src="images/shipin.gif" alt="shipin" width="557px" height="29px" />
    <asp:GridView ID="gvNewVideo" Width="100%" runat="server" AutoGenerateColumns="False" 
        ShowHeader="False">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="VideoID" 
                DataNavigateUrlFormatString="seeTutorial.aspx?TutorialType=Video&amp;TutorialID={0}" 
                DataTextField="VideoName">
            <ControlStyle Font-Underline="False" ForeColor="Black" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="TypeName" />
            <asp:BoundField DataField="FBDate" />
        </Columns>
    </asp:GridView>
</asp:Content>
