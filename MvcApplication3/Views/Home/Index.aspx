<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" MasterPageFile="~/Views/Site.Master"%>

<asp:Content ID="homeTitle" ContentPlaceHolderID="TitleSM" runat="server">
    Home
</asp:Content>

<asp:Content ID="leftSide" ContentPlaceHolderID="LeftContent" runat="server">
    <div>Hi1</div>
</asp:Content>

<asp:Content ID="MainArea" ContentPlaceHolderID="ContentArea" runat="server">
    <div style="width:auto;height:auto">main</div>
</asp:Content>

<asp:Content ID="RightSide" ContentPlaceHolderID="RightContent" runat="server">
    <div>Hi1</div>
</asp:Content>