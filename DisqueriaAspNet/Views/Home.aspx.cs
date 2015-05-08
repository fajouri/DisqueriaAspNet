namespace DisqueriaAspNet.Views
{

    using DisqueriaAspNet.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI.HtmlControls;

    public partial class Home :  System.Web.UI.Page
    {
        MusicStoreEntities db;

        public Home()
        {
            db = new MusicStoreEntities() ;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            CargarAlbums();

        }

        private void CargarAlbums()
        {
            // Get most popular albums
            var albums = GetTopSellingAlbums(5);


            foreach (var album in albums)
            {
                var li = new HtmlGenericControl("li");

                var a = new HtmlGenericControl("a");
                a.Attributes.Add("href", "Store?id=" + album.AlbumId);
                
                var img = new HtmlGenericControl("img");
                img.Attributes.Add("alt", album.Title);
                img.Attributes.Add("src", album.AlbumArtUrl);

                var span = new HtmlGenericControl("span");
                span.InnerHtml= album.Title;
                
                a.Controls.Add(img);
                a.Controls.Add(span);
                li.Controls.Add(a);
                albumList.Controls.Add(li);
            }

            //            <ul id="albumList">
            //    @foreach (var album in Model)
            //    {
            //        <li><a href="@Url.Action("Details", "Store",
            //                new { id = album.AlbumId })">

            //            <img alt="@album.Title" src="@album.AlbumArtUrl" />
            //            <span>@album.Title</span> </a>
            //        </li>
            //    }
            //</ul>

        }

        private List<Album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count

            return db.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}