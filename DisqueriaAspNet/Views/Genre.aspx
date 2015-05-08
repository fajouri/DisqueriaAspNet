<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Genre.aspx.cs" Inherits="DisqueriaAspNet.Views.Genre" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- <h3><em id="albumName" ></em> Albums</h3>--%>

    <div id="divAlbumList">
        <ul runat="server" id="albumList" clientidmode="Static"></ul>
    </div>
   
</asp:Content>

