using Angular2_.net_MVC_Angular4.DBContext;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular2_.net_MVC_Angular4.Controllers
{
    public class BaseAPIController : ApiController
    {
        protected readonly UserDBEntities UserDB = new UserDBEntities();
        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }
    }
}