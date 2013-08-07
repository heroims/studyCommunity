<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="issuance.aspx.cs" Inherits="studyCommunity.issuance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="images/pangbian.GIF" alt="pangbian" />
    <asp:ImageButton ID="btnIssuance" runat="server" 
        ImageUrl="~/images/fabuanniu_01.jpg" CausesValidation="False" 
        onclick="btnIssuance_Click" />
    <asp:ImageButton ID="btnIssuancedVideo" runat="server" 
        ImageUrl="~/images/fabuanniu_02.jpg" CausesValidation="False" 
        onclick="btnIssuancedVideo_Click" />
    <asp:ImageButton ID="btnIssuancedSound" runat="server" 
        ImageUrl="~/images/fabuanniu_03.jpg" CausesValidation="False" 
        onclick="btnIssuancedSound_Click" />
    <asp:ImageButton ID="btnExit" runat="server" 
        ImageUrl="~/images/fabuanniu_04.gif" CausesValidation="False" 
        onclick="btnExit_Click" />
    <asp:Panel ID="PanelFB" runat="server">
        <img src="images/fbjc.gif" alt="fbjc" />
        <table width="557px">
            <tr>
                <td>
                    教程名称：
                </td>
                <td align="left">
                    <asp:TextBox ID="txtTitle" Width="300px" runat="server"></asp:TextBox>
                </td>
                <td align="left" style="color:Red" >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
                        ControlToValidate="txtTitle" ErrorMessage="必须填写"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    教程类型：
                </td>
                <td align="left">
                    <asp:RadioButton ID="rdoVideo" runat="server" Checked="True" 
                        GroupName="TutorialType" Text="视频" />
                    <asp:RadioButton ID="rdoSound" runat="server" GroupName="TutorialType" 
                        Text="语音" />
                </td>
            </tr>
            <tr>
                <td>
                    课程类型：
                </td>
                <td align="left">
                    <asp:DropDownList ID="ddlType" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    内容简介：
                </td>
                <td align="left">
                    <asp:TextBox ID="txtContainer" runat="server" TextMode="MultiLine" 
                        Height="150px" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    上传教程：
                </td>
                <td align="left">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:Button ID="btnIssuanced" runat="server" Text="发布" 
                        onclick="btnIssuanced_Click" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnClear" runat="server" Text="重置" onclick="btnClear_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="PanelYvideo" runat="server">   
        <asp:GridView ID="gvFBVideo" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="White" 
            BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" 
            GridLines="None" PageSize="5" onrowdeleting="gvFBVideo_RowDeleting">
            <Columns>
                <asp:BoundField HeaderText="编号" DataField="RowID" />
                <asp:BoundField DataField="VideoName" HeaderText="视频名称" />
                <asp:BoundField DataField="TypeName" HeaderText="语言类型" />
                <asp:BoundField DataField="FBDate" HeaderText="发布日期" />
                <asp:HyperLinkField HeaderText="查看留言" Text="查看" DataNavigateUrlFields="VideoID" 
                    DataNavigateUrlFormatString="seeTutorial.aspx?TutorialType=Video&amp;TutorialID={0}">
                <ControlStyle Font-Underline="False" />
                </asp:HyperLinkField>
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
                <ControlStyle Font-Underline="False" ForeColor="Black" />
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
    </asp:Panel>
    <asp:Panel ID="PanelYsound" runat="server">
        <asp:GridView ID="gvFBSound" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="White" 
            BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" 
            GridLines="None" PageSize="5" onrowdeleting="gvFBSound_RowDeleting">
            <Columns>
                <asp:BoundField HeaderText="编号" DataField="RowID" />
                <asp:BoundField DataField="SoundName" HeaderText="语音名称" />
                <asp:BoundField DataField="TypeName" HeaderText="语言类型" />
                <asp:BoundField DataField="FBDate" HeaderText="发布日期" />
                <asp:HyperLinkField HeaderText="查看留言" Text="查看" DataNavigateUrlFields="SoundID" 
                    DataNavigateUrlFormatString="seeTutorial.aspx?TutorialType=Sound&amp;TutorialID={0}">
                <ControlStyle Font-Underline="False" />
                </asp:HyperLinkField>
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
                <ControlStyle Font-Underline="False" ForeColor="Black" />
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
    </asp:Panel>
</asp:Content>
