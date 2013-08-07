<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Tutorial.aspx.cs" Inherits="studyCommunity.Tutorial" %>
<%@ Register src="UserControl/search.ascx" tagname="search" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:search ID="search1" runat="server" />
    <img src="images/ypkt.gif" alt="yinpin" width="557px" height="29px" />
    <table>
        <tr>
            <td align="left">
                <asp:LinkButton ID="btnNet" runat="server" Font-Underline="False" 
                    ForeColor="Black" onclick="btnNet_Click">.NET教程</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                本书全面介绍了ASP程序开发的各方面技术和技巧，共分17章，内容包括表单/窗口与导航条设计、代码封装技术、数据库技术、SQL查询相关技术、在线统计、视图/存储过程和触发器的应用、报表与打印、学习参考。
            </td>
        </tr>
        <tr>
            <td class="tdDLine">  
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:LinkButton ID="btnAsp" runat="server" Font-Underline="False" 
                    ForeColor="Black" onclick="btnAsp_Click">ASP教程</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                本书全面介绍了ASP程序开发的各方面技术和技巧，共分17章，内容包括表单/窗口与导航条设计、代码封装技术、数据库技术、SQL查询相关技术、在线统计、视图/存储过程和触发器的应用、报表与打印、学习参考。
            </td>
        </tr>
        <tr>
            <td class="tdDLine">  
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:LinkButton ID="btnJsp" runat="server" Font-Underline="False" 
                    ForeColor="Black" onclick="btnJsp_Click">JSP教程</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                本书全面介绍了ASP程序开发的各方面技术和技巧，共分17章，内容包括表单/窗口与导航条设计、代码封装技术、数据库技术、SQL查询相关技术、在线统计、视图/存储过程和触发器的应用、报表与打印、学习参考。
            </td>
        </tr>
        <tr>
            <td class="tdDLine">  
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:LinkButton ID="btnVb" runat="server" Font-Underline="False" 
                    ForeColor="Black" onclick="btnVb_Click">VB教程</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                本书全面介绍了ASP程序开发的各方面技术和技巧，共分17章，内容包括表单/窗口与导航条设计、代码封装技术、数据库技术、SQL查询相关技术、在线统计、视图/存储过程和触发器的应用、报表与打印、学习参考。
            </td>
        </tr>
        <tr>
            <td class="tdDLine">  
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:LinkButton ID="btnVc" runat="server" Font-Underline="False" 
                    ForeColor="Black" onclick="btnVc_Click">VC教程</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                本书全面介绍了ASP程序开发的各方面技术和技巧，共分17章，内容包括表单/窗口与导航条设计、代码封装技术、数据库技术、SQL查询相关技术、在线统计、视图/存储过程和触发器的应用、报表与打印、学习参考。
            </td>
        </tr>
        <tr>
            <td class="tdDLine">  
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:LinkButton ID="btnDelphi" runat="server" Font-Underline="False" 
                    ForeColor="Black" onclick="btnDelphi_Click">DELPHI教程</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                本书全面介绍了ASP程序开发的各方面技术和技巧，共分17章，内容包括表单/窗口与导航条设计、代码封装技术、数据库技术、SQL查询相关技术、在线统计、视图/存储过程和触发器的应用、报表与打印、学习参考。
            </td>
        </tr>
        <tr>
            <td class="tdDLine">  
            </td>
        </tr>
    </table>
</asp:Content>
