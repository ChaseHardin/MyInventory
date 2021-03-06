﻿using System;
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

        [HttpGet, Route("{inventoryId}")]
        public virtual IHttpActionResult GetById(Guid inventoryId)
        {
            return Ok(new GetInventoryByIdCommand(inventoryId).Execute());
        }

        [HttpPost, Route("")]
        public virtual IHttpActionResult Post(InventoryViewModel inventory)
        {
            return Created(Request.RequestUri.PathAndQuery, new PostInventoryCommand(inventory).Execute());
        }

        [HttpPut, Route("{inventoryId}")]
        public virtual IHttpActionResult Put(Guid inventoryId, InventoryViewModel inventory)
        {
            return Ok(new PutInventoryCommand(inventoryId, inventory).Execute());
        }

        [HttpDelete, Route("{inventoryId}")]
        public virtual IHttpActionResult Delete(Guid inventoryId)
        {
            return Ok(new DeleteInventoryCommand(inventoryId).Execute());
        }
    }
}