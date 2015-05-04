using DisqueriaAspNet.Models;
//using DisqueriaAspNet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace DisqueriaAspNet
{
    public partial class Site : System.Web.UI.MasterPage
    {
        MusicStoreEntities db;

        public Site()
        {
            db = new MusicStoreEntities() ;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            MostrarGeneros();

        }

        private void MostrarGeneros()
        {
           // var service = AlbumService.GetObject();
            //var listaGeneros = service.GetGeneros();

            var listaGeneros = db.Genres.Select(x=>x).ToList();

            foreach (var genero in listaGeneros)
            {
                var li = new HtmlGenericControl("li");
                var elementoGenero = new HtmlGenericControl("a");
                elementoGenero.Attributes.Add("href", "page.htm");
                elementoGenero.InnerText = genero.Name;
                li.Controls.Add(elementoGenero);

                generos.Controls.Add(li);
            }
           
        }


    }
}