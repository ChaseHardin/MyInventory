using System.Web.Http;
using MyInventory.Business.Features.Inventory;
using MyInventory.Business.Features.Inventory.Commands;

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

        [HttpPost, Route("")]
        public virtual IHttpActionResult Post(InventoryViewModel inventory)
        {
            return Created(Request.RequestUri.PathAndQuery, new PostInventoryCommand(inventory).Execute());
        }
    }
}