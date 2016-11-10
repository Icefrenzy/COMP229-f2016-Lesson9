using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COMP229_f2016_Lesson9.Models;

namespace COMP229_f2016_Lesson9.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: Store
        public ActionResult Index()
        {

            return View(db.Genres.ToList());
        }

        // GET: Store/Browse?genre=disco
        public ActionResult Browse(string genre="Disco")
        {
            if (genre == String.Empty || genre == null)
            {
                genre = "Disco";
            }

            Genre genreModel = new Genre(genre);


            return View(genreModel);
        }

        // GET: Store/Details/5
        public ActionResult Details(int? id = 1)
        {
            Album album = new Album("Album" + id);
            return View(album);
        }

        
    }
}
