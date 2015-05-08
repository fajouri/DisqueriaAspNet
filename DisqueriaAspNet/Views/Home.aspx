<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DisqueriaAspNet.Views.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="promotion">
    </div>
    <h3><em>Fresh</em> off the grill</h3>

    <div id="divAlbumList">
        <ul runat="server" id="albumList" clientidmode="Static"></ul>
    </div>
   
</asp:Content>