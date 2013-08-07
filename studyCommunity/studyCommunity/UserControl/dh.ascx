<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dh.ascx.cs" Inherits="studyCommunity.dh" %>
<map id="topmap" name="topmap" >
    <area alt="设为首页" shape="rect" coords="755, 0, 823, 30" href="#" onclick="this.style.behavior='url(#default#homepage)';this.setHomePage('http://localhost:7579/index.aspx');" />
    <area alt="收藏本页" shape="rect" coords="823, 0, 892, 30" href="javascript:window.external.AddFavorite('http://localhost:7579/index.aspx/','互动媒体学习社区系统')" />
    <area alt="首页" shape="rect" coords="287, 32, 386, 65" href="../index.aspx" />
    <area alt="发布教程" shape="rect" coords="386, 32, 492, 65" href="../issuance.aspx" />
    <area alt="视频课堂" shape="rect" coords="492, 32, 591, 65" href="../Tutorial.aspx?TutorialType=Video" />
    <area alt="语音课堂" shape="rect" coords="591, 32, 691, 65" href="../Tutorial.aspx?TutorialType=Sound" />
    <area alt="注册" shape="rect" coords="691, 32, 779, 65" href="../Registe.aspx" />
    <area alt="联系我们" shape="rect" coords="779, 32, 900, 65" href="#" />
</map>
<img id="index_01" src="~/images/index_01.jpg" runat="server" alt="index_01.jpg" style="width:1002px; height:83px" usemap="#topmap" />