using System.Web.Http;
using Archive.Core;

namespace Archive.Api.Controller
{
    public class ArchiveController : ApiController
    {
        public IHttpActionResult Get()
        {
            ArchiveLib archive = new ArchiveLib();
            archive.WriteFile("demo string");
            return Ok();
        }
    }
}
