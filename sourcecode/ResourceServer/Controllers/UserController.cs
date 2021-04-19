namespace ResourceServer.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    public class UserController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "v1", "v2" };
        }

    }
}
