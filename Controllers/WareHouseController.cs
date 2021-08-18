using JoinTable.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoinTable.Controllers
{
    public class WareHouseController : Controller
    {
        WareHouseDBContext wareHouseDB = new WareHouseDBContext();

        public IActionResult Index()
        {
            var Query = wareHouseDB.ProductsTbls.Include(c => c.Category);
            //ProductsTbls เป็นตารางหลัก แล้วทำการ joinTable Category โดยอาศัย function Include เข้ามาช่วยทำงาน
            return View(Query);
        }
    }
}
