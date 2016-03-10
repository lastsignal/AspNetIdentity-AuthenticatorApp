using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class TestController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                Property = "Value",
                UserName = User.Identity.Name,
                Link = ConfigService.Account.ManageUrl
            });
        }
    }
}
