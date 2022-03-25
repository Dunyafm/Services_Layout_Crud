using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceLayout.Data;
using ServiceLayout.Models;
using ServiceLayout.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayout.Controllers
{
    public class HomeController : Controller
    {
        //private readonly AppDbContext _context;
        //private readonly LayoutService _layoutService;

        public async Task<IActionResult> Index()
        {
            return View();

        }




    }
}
