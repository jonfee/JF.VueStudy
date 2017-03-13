using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web.Http;

namespace JF.VueStudy.Demo.Controllers
{
    [RoutePrefix("api/h5/")]
    public class H5Controller : ApiController
    {
        [HttpGet]
        public HttpResponseMessage sse()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            response.Content = new StringContent($"data:{DateTime.Now}\n\n", Encoding.UTF8, "text/event-stream");

            return response;
        }
    }
}
