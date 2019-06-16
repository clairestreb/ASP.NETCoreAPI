using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MainCanvas.Controllers
{
    
    public class TestController : ControllerBase
    {
        [Route("api/action1")]
        public string TestAction1()
        {
            return "TestAction1";
        }
        [Route("api/action2")]
        public string TestAction2()
        {
            return "TestAction2";
        }
    }
}