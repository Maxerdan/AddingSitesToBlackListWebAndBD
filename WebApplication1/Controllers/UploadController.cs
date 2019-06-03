using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.DataAccessPostgreSqlProvider;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using AddingSitesToBlackList;

namespace WebApplication1.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoUpload(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                var xs = new XmlSerializer(typeof(AddingSitesToBlackListClass));
                var site = (AddingSitesToBlackListClass)xs.Deserialize(stream);


                using (var db = new AddSitesDBContext())
                {
                    var dbs = new DbSites();
                    foreach (var s in site.SitesList)
                    {
                        dbs.SitesList = new Collection<DbListOfSites>();
                        foreach (var list in site.SitesList)
                        {
                            dbs.SitesList.Add(new DbListOfSites()
                            {
                                Adress = list.Adress,
                                AdressPubl = list.AdressPubl,
                                Violation = list.Violation,
                                Stat = list.Stat,
                                BlockDate = list.BlockDate,
                                Reason = list.Reason,
                                PublishDate = list.PublishDate,
                            });
                        }
                    }

                    db.SpaceShips.Add(dbs);
                    db.SaveChanges();
                }
                return View(site);
            }
        }

        //public ActionResult Image(int id)
        //{
        //    byte[] foto;
        //    using (var db = new AddSitesDBContext())
        //    {
        //        foto = db.Flights.Find(id).Screenshot;
        //    }
        //    return base.File(foto, "image/jpeg");
        //}

        public ActionResult List()
        {
            List<DbSites> list;
            using (var db = new AddSitesDBContext())
            {
                list = db.SpaceShips.Include(s => s.SitesList).ToList();
            }

            return View(list);
        }
    }
}