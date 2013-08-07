<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Registe.aspx.cs" Inherits="studyCommunity.Registe" %>
<%@ MasterType VirtualPath="~/Site2.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:0 auto; width:557px;">
        <table class="tableZc">
            <tr>
                <td colspan="4" class="tdZchy">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                        <Services>
                            <asp:ServiceReference Path="~/WSValidate.asmx" />
                        </Services>
                    </asp:ScriptManager>
                    <script type="text/javascript">
                        function isUser() {
                            var txtUser = document.getElementById("ContentPlaceHolder1_txtUser");
                            studyCommunity.WSValidate.isUserName(txtUser.value,alertMsg);
                        }
                        function alertMsg(res) {
                            alert(res);
                        }
                    </script>
                </td>
            </tr>
            <tr>
            <td>
                
            </td>
            <td align="right">

                用户名：</td>
            <td align="left" class="redtd">
                
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                
                *</td>
            <td align="left" class="redtd">
                
                <input id="btnValidate" type="button" onclick="isUser()" value="检测用户名" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
                    ControlToValidate="txtUser" ErrorMessage="必须填写"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                
                </td>
                <td align="right">

                    密码：</td>
                <td align="left" class="redtd">
                
                    <asp:TextBox ID="txtPsw1" runat="server" TextMode="Password"></asp:TextBox>
                
                    *</td>
                <td align="left" class="redtd">
                
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPass" runat="server" 
                        ControlToValidate="txtPsw1" ErrorMessage="必须填写"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                
                </td>
                <td align="right">
                    确认密码：</td>
                <td align="left">

                    <asp:TextBox ID="txtPsw2" runat="server" TextMode="Password"></asp:TextBox>            
                
                </td>
                <td align="left" class="redtd">
                
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtPsw1" ControlToValidate="txtPsw2" ErrorMessage="两次密码不一致"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                
                </td>
                <td align="right">

                    性别：</td>
                <td align="left">
                
                    <asp:RadioButton ID="rdoMan" runat="server" GroupName="sex" Text="男" 
                        Checked="True" />
                    <asp:RadioButton ID="rdoWomen" runat="server" GroupName="sex" Text="女" />
                
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                
                </td>
                <td align="right">

                    密码提示问题：</td>
                <td align="left">
                
                    <asp:TextBox ID="txtQues" runat="server"></asp:TextBox>
                
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                
                </td>
                <td align="right">

                    密码提示答案：</td>
                <td align="left">
                
                    <asp:TextBox ID="txtSolu" runat="server"></asp:TextBox>
                
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                
                </td>
                <td align="right">

                    真实姓名：</td>
                <td align="left">
                
                    <asp:TextBox ID="txtTureName" runat="server"></asp:TextBox>
                
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                
                </td>
                <td align="right">

                    身份证号：</td>
                <td align="left">
                
                    <asp:TextBox ID="txtPersonNum" runat="server"></asp:TextBox>
                
                </td>
                <td align="left" class="redtd">
                
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorPersonNum" 
                        runat="server" ControlToValidate="txtPersonNum" ErrorMessage="身份证号码不正确" 
                        ValidationExpression="\d{17}[\d|X]|\d{15}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                
                </td>
                <td align="right">

                    Email：</td>
                <td align="left" class="redtd">
                
                    <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
                
                    *</td>
                <td align="left" class="redtd">
                
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" 
                        ControlToValidate="txtMail" ErrorMessage="必须填写"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" 
                        runat="server" ControlToValidate="txtMail" ErrorMessage="邮箱地址不正确" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="4">
                    <asp:Button ID="btnReg" runat="server" Text="注册" onclick="btnReg_Click" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnCan" runat="server" Text="取消" onclick="btnCan_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
