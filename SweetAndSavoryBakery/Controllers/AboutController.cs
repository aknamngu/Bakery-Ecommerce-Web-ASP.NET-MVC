using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SweetAndSavoryBakery.Models;
using System.Collections.Generic;

namespace SweetAndSavoryBakery.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Locations()
        {
            // ⭐️ DỮ LIỆU CÁC CHI NHÁNH CỦA BẠN (Dữ liệu tĩnh, KHÔNG LẤY TỪ DB)
            var locations = new List<StoreLocation>
            {
                new StoreLocation
                {
                    Id = 1,
                    Name = "Chi nhánh Thảo Điền",
                    Address = "9 Ngô Quang Huy, Thảo Điền, TP. Thủ Đức, TP. HCM",
                    Phone = "0901 234 567",
                    WorkingHours = "8:00 - 21:00 (Hàng ngày)",
                    MapUrl = "https://www.google.com/maps/search/?api=1&query=9+Ngo+Quang+Huy,+TP+Thu+Duc,+TP+HCM"
                },
                new StoreLocation
                {
                    Id = 2,
                    Name = "Chi nhánh Quận 1",
                    Address = "47/5 Quốc Hương, P. An Khánh, TP. Thủ Đức, TP. HCM",
                    Phone = "0909 876 543",
                    WorkingHours = "8:00 - 22:00 (Hàng ngày)",
                    MapUrl = "https://www.google.com/maps/search/?api=1&query=47/5+Quoc+Huong,+P.+An+Khanh,+TP+Thu+Duc,+TP+HCM"
                }
              
            };

            // Truyền danh sách chi nhánh sang View Locations.cshtml
            return View(locations);
        }
    }
}