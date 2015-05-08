<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Store.aspx.cs" Inherits="DisqueriaAspNet.Views.Store" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- <h3><em id="albumName" ></em> Albums</h3>--%>

     <h2 runat="server" id="hTitulo"></h2>
    
    <p> <img id="imgAlbum" runat="server" src="empty" alt="empty"/> </p>

    <div id="albumDetails" clientidmode="Static">

    <p id="pGenre" runat="server"><em>Genre:</em></p>
    <p id="pArtist" runat="server"><em>Artist:</em></p>
    <p id="pPrice" runat="server"><em>Price:</em></p>
    <p><a id="btnAddToCart" class="button" runat="server">Add to cart</a></p>

    </div>

   

<%--<p>
    <img alt="@Model.Title" src="@Model.AlbumArtUrl" />
</p>

<div id="album-details">
    <p>
        <em>Genre:</em>
        @Model.Genre.Name
    </p>
    <p>
        <em>Artist:</em>
        @Model.Artist.Name
    </p>
    <p>
        <em>Price:</em>
        @String.Format("{0:F}", Model.Price)
    </p>
    <p class="button">
        @Html.ActionLink("Add to cart", "AddToCart", 
        "ShoppingCart", new { id = Model.AlbumId }, "")
    </p>
</div>--%>

   
</asp:Content>

<%--@model MvcMusicStore.Models.Album

@{
    ViewBag.Title = "Album - " + Model.Title;
}--%>

<%--<h2>@Model.Title</h2>

<p>
    <img alt="@Model.Title" src="@Model.AlbumArtUrl" />
</p>

<div id="albumDetails">
    <p>
        <em>Genre:</em>
        @Model.Genre.Name
    </p>
    <p>
        <em>Artist:</em>
        @Model.Artist.Name
    </p>
    <p>
        <em>Price:</em>
        @String.Format("{0:F}", Model.Price)
    </p>
    <p class="button">
        @Html.ActionLink("Add to cart", "AddToCart", 
        "ShoppingCart", new { id = Model.AlbumId }, "")
    </p>
</div>--%>

