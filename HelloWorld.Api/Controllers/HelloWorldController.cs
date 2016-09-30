using HelloWorld.Data;
using System.Web.Http;

namespace HelloWorld.Api.Controllers
{
    public class HelloWorldController : ApiController
    {
        IDataRepository data;

        public HelloWorldController(IDataRepository _data)
        {
            data = _data;
        }

        public string Get()
        {
            return data.GetValue();
        }
    }
}
