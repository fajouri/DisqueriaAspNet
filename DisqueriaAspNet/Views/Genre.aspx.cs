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
    public partial class Genre : System.Web.UI.Page
    {
         MusicStoreEntities db;

         public Genre()
        {
            db = new MusicStoreEntities() ;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           CargarAlbums();

        }

        private void CargarAlbums()
        {
             var genre = Request.QueryString["genre"];
            var albums = BuscarPorGenero(genre);


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

          
        }

        private List<Album> BuscarPorGenero(string genre)
        {
            return db.Albums.Where(x => x.Genre.Name == genre)
                .ToList();
        }
    }
}