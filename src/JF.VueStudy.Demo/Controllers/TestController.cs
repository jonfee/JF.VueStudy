using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace JF.VueStudy.Demo.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Test()
        {
            return Ok("这是一个测试接口。");
        }
    }
}
