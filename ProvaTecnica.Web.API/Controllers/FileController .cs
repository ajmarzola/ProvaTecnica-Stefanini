using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProvaTecnica.Business;

namespace ProvaTecnica.Web.API.Controllers
{
    public class FileController : ApiController
    {
        // POST: api/File
        [ResponseType(typeof(bool))]
        public async Task<IHttpActionResult> Process(string pPath, string pType)
        {
            using (var bll = new FileBll())
            {
                return Ok(await bll.Process(pPath, pType));
            }
        }
    }
}