<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="seeTutorial.aspx.cs" Inherits="studyCommunity.seeTutorial" %>
<%@ Register src="UserControl/dataPaging.ascx" tagname="dataPaging" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="images/pangbian.GIF" alt="shipin" width="557px" height="29px" />
    <table style="width: 100%;"  cellspacing="0">
        <tr>
            <td colspan="3" align="center">
                <strong style="color:Blue">教程名称:</strong>
                <asp:Label ID="lblTutorialName" runat="server"></asp:Label>
                &nbsp;&nbsp;
                点击率:
                <asp:Label ID="lblClickSum" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <embed src="<%=Url%>" style="width: 100%" ></embed>
            </td>
        </tr>
        <tr>
            <td>
                内容简介：
            </td>
            <td id="Content" rowspan="3">
                <asp:TextBox ID="txtContainer" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>                   
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="right">
                发布人：
            </td>
            <td id="Name">
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="right">
                发布日期：
            </td>
            <td id="FBDate">
                <asp:Label ID="lblFBDate" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="center">
                <asp:Button ID="btnDownLoad" runat="server" Text="下载" 
                    onclick="btnDownLoad_Click" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                验证码：
                <asp:TextBox ID="txtCheck" runat="server" Width="75px"></asp:TextBox>
                <script type="text/javascript">
                    function vali() {
                        var random = Math.random();
                        var imgValidate = document.getElementById("imgVali");
                        imgValidate.src = "ValidateCode.aspx? " + random;
                    }
                </script>
                <img id="imgVali" width="60px" height="25px" alt="ValidateCode" src="ValidateCode.aspx?" />
                <a href="javascript:vali()" style="color: #000000; text-decoration: none">看不清</a>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td valign="top">
                留言内容：
                <asp:TextBox ID="txtLeaveContent" runat="server" Height="125px" TextMode="MultiLine" 
                    Width="275px"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="center">
                <asp:Button ID="btnSpeak" runat="server" Text="发言" onclick="btnSpeak_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="3" align="center">
                <div style="width: 470px">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <table border="1" cellspacing="0" style="width:100%;">
                                <tr>
                                    <td align="right">
                                        发言人：
                                    </td>
                                    <td align="left" colspan="2">
                                        <%#Eval("Speakman")%>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td align="right">
                                        发言内容：
                                    </td>
                                    <td align="left" colspan="2">
                                        <textarea id="txtContent" cols="50" rows="6"><%#Eval("SpeakContent")%></textarea>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        发言时间:
                                    </td>
                                    <td align="left">  
                                        <%#Eval("SpeakDate")%>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:Repeater>                   
                </div>
            </td>
        </tr>
    </table>
    <uc1:dataPaging ID="dataPaging1" OnGvBind="gvBind" runat="server" />
</asp:Content>
