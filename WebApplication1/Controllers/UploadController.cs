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
                var ship = (AddingSitesToBlackListClass)xs.Deserialize(stream);


                using (var db = new SpaceFleetDbContext())
                {
                    var dbs = new DbSpaceShip();
                    foreach (var s in ship.SitesList)
                    {
                        dbs.SitesList = new Collection<DbFlight>();
                        foreach (var flight in ship.SitesList)
                        {
                            dbs.SitesList.Add(new DbFlight()
                            {
                                Adress = flight.Adress,
                                AdressPubl = flight.AdressPubl,
                            });
                        }
                    }

                    db.SpaceShips.Add(dbs);
                    db.SaveChanges();
                }


                return View(ship);
            }
        }

        public ActionResult Image(int id)
        {
            byte[] foto;
            using (var db = new SpaceFleetDbContext())
            {
                foto = db.Flights.Find(id).Screenshot;
            }
            return base.File(foto, "image/jpeg");
        }

        public ActionResult List()
        {
            List<DbSpaceShip> list;
            using (var db = new SpaceFleetDbContext())
            {
                list = db.SpaceShips.Include(s => s.SitesList).ToList();
            }

            return View(list);
        }
    }
}