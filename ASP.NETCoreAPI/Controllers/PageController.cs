using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MainCanvas.Controllers
{
    
    public class PageController : Controller
    {
        [Route("pages/page1")]
        public ViewResult MainView()
        {
            return View("\\MainTestPage.cshtml");
        }
    }
}
