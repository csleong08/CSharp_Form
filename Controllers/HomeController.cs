using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Form.Models;

namespace Form.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("create")]
        public IActionResult Create(User myUser)
        {
            if(ModelState.IsValid)
            {
                return View("Success", myUser);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
