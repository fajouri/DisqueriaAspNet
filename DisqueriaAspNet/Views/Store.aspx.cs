using DisqueriaAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace DisqueriaAspNet.Views
{
    public partial class Store : System.Web.UI.Page
    {
        
         MusicStoreEntities db;

         public Store()
        {
            db = new MusicStoreEntities() ;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDetalleAlbum();
        }

        private void CargarDetalleAlbum()
        {

            var id = int.Parse(Request.QueryString["id"]);
            var album = db.Albums.Find(id);

            imgAlbum.Alt = album.Title;
            imgAlbum.Src = album.AlbumArtUrl;
            hTitulo.InnerText = album.Title;
            pGenre.InnerText= album.Genre.Name;
            pArtist.InnerText= album.Artist.Name;
            pPrice.InnerText= String.Format("{0:F}", album.Price);
            btnAddToCart.HRef = "Cart.aspx?id="+id.ToString()+"&action=add";
    //       <p>
    //    <em>Genre:</em>
    //    @Model.Genre.Name
    //</p>
    //<p>
    //    <em>Artist:</em>
    //    @Model.Artist.Name
    //</p>
    //<p>
    //    <em>Price:</em>
    //    @String.Format("{0:F}", Model.Price)
    //</p>
    //<p class="button">
    //    @Html.ActionLink("Add to cart", "AddToCart", 
    //    "ShoppingCart", new { id = Model.AlbumId }, "")
    //</p>
        }



    }
}