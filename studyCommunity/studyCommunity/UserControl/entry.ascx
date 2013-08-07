<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="entry.ascx.cs" Inherits="studyCommunity.entry" %>
<link type="text/css" rel="Stylesheet" href="../css/StyleSheet1.css" />
<script type="text/javascript">
    function validate() {
        var random = Math.random();
        var imgValidate = document.getElementById("imgValidate");
        imgValidate.src = "../ValidateCode.aspx? " + random;
    }
</script>
<div id="login" class="login">
    用户名：<asp:TextBox ID="txtUser" runat="server" Width="60px"></asp:TextBox>
    密码：<asp:TextBox ID="txtPsw" runat="server" Width="60px" TextMode="Password"></asp:TextBox>
    验证码：<asp:TextBox ID="txtCheckNum" runat="server" Width="60px"></asp:TextBox>
    <img id="imgValidate" width="60px" height="25px" alt="ValidateCode" src="../ValidateCode.aspx?" />
    <a href="javascript:validate()" style="color: #000000; text-decoration: none">看不清</a>
    <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="~/images/denglu.gif" 
        onclick="btnLogin_Click" style="height: 16px" />
    <asp:LinkButton ID="btnNew" runat="server" Font-Bold="True" 
        Font-Underline="False" ForeColor="White" PostBackUrl="~/Registe.aspx">【新用户注册】</asp:LinkButton>
    <asp:LinkButton ID="btnPass" runat="server" Font-Underline="False" 
        ForeColor="White" PostBackUrl="~/seekPassWord.aspx">忘记密码</asp:LinkButton>
</div>