<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="seekPassWord.aspx.cs" Inherits="studyCommunity.seekPassWord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="margin:0 auto" width="557px">
        <tr>
            <td align="right">
                用户名：
            </td>
            <td align="left" class="redtd">
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorUser" 
                    runat="server" ControlToValidate="txtUser" ErrorMessage="必须填写"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:LinkButton ID="btnSearchSou" runat="server">查找问题</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="right">
                密码提示问题：
            </td>
            <td align="left">
                <asp:TextBox ID="txtQues" runat="server"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right">
                密码提示答案：
            </td>
            <td align="left">
                <asp:TextBox ID="txtSoul" runat="server"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right">
                密码：
            </td>
            <td align="left">
                <asp:TextBox ID="txtPsw" runat="server"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3">
                <asp:Button ID="btnSearch" runat="server" Text="查找密码" 
                    onclick="btnSearch_Click" style="height: 21px" />
                &nbsp;
                <asp:Button ID="btnBack" runat="server" Text="返回" onclick="btnBack_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
