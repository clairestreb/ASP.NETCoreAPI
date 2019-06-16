using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainCanvas.Controllers
{
    [Route("api/[controller]/[action]")]
    public class Test3Controller : Controller
    {
          public string TestAction1()
        {
            return "TestAction1 - action/controller option";
        }

        public string TestAction2()
        {
            return "TestAction2 - action/controller option";
        }
    }
}
