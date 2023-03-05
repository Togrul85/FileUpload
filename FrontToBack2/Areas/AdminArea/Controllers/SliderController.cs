﻿using FrontToBack2.DAL;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack2.Areas.AdminArea.Controllers
{

    [Area("AdminArea")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public SliderController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View(_appDbContext.Sliders.ToList());
        }
    }
}
