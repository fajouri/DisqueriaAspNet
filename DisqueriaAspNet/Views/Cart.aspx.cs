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
    public partial class Cart : System.Web.UI.Page
    {
        ShoppingCart db;
        //MusicStoreEntities storeDB;

        public Cart()
        {
            db = new ShoppingCart() ;
            //storeDB = new MusicStoreEntities();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var cart = ShoppingCart.GetCart(this.Context);

            var id = Request.QueryString["id"];
            if (id != null)
            {
                //var idAlbum = int.Parse(id);
                //var addedAlbum = storeDB.Albums
                //.Single(album => album.AlbumId == idAlbum);

                cart.AddToCart(int.Parse(id));
            }

            foreach (var item in cart.GetCartItems())
	        {
                var tr = new HtmlTableRow();
                tr.ID = "row-" + item.RecordId;
                tr.ClientIDMode = System.Web.UI.ClientIDMode.Static;
                var tdAlbumName = new HtmlTableCell();
                var a = new HtmlGenericControl("a") { InnerText=item.Album.Title};
                a.Attributes.Add("href", "Store?id=" + item.Album.AlbumId);
                tdAlbumName.Controls.Add(a);
                var tdPrice = new HtmlTableCell() { InnerText = String.Format("{0:F}", item.Album.Price) };
                var tdQuantity = new HtmlTableCell() { InnerText = item.Count.ToString(), ID = "item-count-" + item.RecordId };
                var tdRemoveLink = new HtmlTableCell();

                tr.Cells.Add(tdAlbumName);
                tr.Cells.Add(tdPrice);
                tr.Cells.Add(tdQuantity);
                tr.Cells.Add(tdRemoveLink);
                tableCart.Rows.Add(tr);
            }
            var liFinal = new HtmlTableRow();
            var tdTitulo = new HtmlTableCell() { InnerText = "Total" };
            var tdvacio1 = new HtmlTableCell();
            var tdvacio2 = new HtmlTableCell();
            var tdTotal = new HtmlTableCell() { ID = "cartTotal", ClientIDMode = System.Web.UI.ClientIDMode.Static, InnerText = cart.GetTotal().ToString() };

            liFinal.Cells.Add(tdTitulo);
            liFinal.Cells.Add(tdvacio1);
            liFinal.Cells.Add(tdvacio2);
            liFinal.Cells.Add(tdTotal);
            tableCart.Rows.Add(liFinal);

        }

        //
        // AJAX: /ShoppingCart/RemoveFromCart/5

        //public static string RemoveFromCart(int id)
        //{
        //    // Remove the item from the cart
        //    var cart = ShoppingCart.GetCart(this.HttpContext);

        //    // Get the name of the album to display confirmation
        //    string albumName = storeDB.Carts
        //        .Single(item => item.RecordId == id).Album.Title;

        //    // Remove from cart
        //    int itemCount = cart.RemoveFromCart(id);

        //    // Display the confirmation message
        //    var results = new ShoppingCartRemoveViewModel
        //    {
        //        Message = Server.HtmlEncode(albumName) +
        //            " has been removed from your shopping cart.",
        //        CartTotal = cart.GetTotal(),
        //        CartCount = cart.GetCount(),
        //        ItemCount = itemCount,
        //        DeleteId = id
        //    };

        //    return Json(results);
        //}
    }
}