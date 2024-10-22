using BT4_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT4_ASP.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            string connectionString = "Data Source=DESKTOP-SD252UH;Initial Catalog=QuanLySanPham;Integrated Security=True";
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connectionString);
            List<Catalog> dsCatalog = context.Catalogs.ToList();
            return View(dsCatalog);
        }
    }
}