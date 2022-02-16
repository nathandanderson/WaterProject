using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterProject.Models;

namespace WaterProject.Controllers
{
    public class HomeController : Controller
    {
        private IWaterProjectRepository repo;

        public HomeController(IWaterProjectRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 5;

            var blah = repo.Projects
                .OrderBy(p => p.ProjectName)
                .Skip(pageSize*(pageNum-1))
                .Take(pageSize);

            return View(blah);
        }

    }
}
