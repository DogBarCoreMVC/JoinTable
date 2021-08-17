using JoinTable.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoinTable.Controllers
{
    public class MenuController : Controller
    {
        MenuDBContext menuDB = new MenuDBContext();

        public IActionResult Index()
        {
            var Query = menuDB.GroupMenusTbls.Include("ListMenusTbls");
            return View(Query);
        }
    }
}
