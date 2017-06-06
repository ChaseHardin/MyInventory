using System.Web.Http;
using MyInventory.Business.Features.Inventory;

namespace MyInventory.API.Features.Inventory
{
    [RoutePrefix("api/inventory")]
    public class InventoryController : ApiController
    {
        [HttpGet, Route("")]
        public virtual IHttpActionResult Get()
        {
            return Ok(new GetInventoryCommand().Execute());
        }
    }
}
