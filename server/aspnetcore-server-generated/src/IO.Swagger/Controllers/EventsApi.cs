/*
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * OpenAPI spec version: 1.4.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class EventsApiController : ControllerBase
    { 
        /// <summary>
        /// [INDEXER] Get a range of BlockEvents
        /// </summary>
        /// <remarks>&#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.</remarks>
        /// <param name="body"></param>
        /// <response code="200">Expected response to a valid request</response>
        /// <response code="500">unexpected error</response>
        [HttpPost]
        [Route("/events/blocks")]
        [ValidateModelState]
        [SwaggerOperation("EventsBlocks")]
        [SwaggerResponse(statusCode: 200, type: typeof(EventsBlocksResponse), description: "Expected response to a valid request")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "unexpected error")]
        public virtual IActionResult EventsBlocks([FromBody]EventsBlocksRequest body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EventsBlocksResponse));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"max_sequence\" : 5,\n  \"events\" : [ {\n    \"sequence\" : 5,\n    \"type\" : \"block_added\",\n    \"block_identifier\" : {\n      \"index\" : 1123941,\n      \"hash\" : \"0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85\"\n    }\n  }, {\n    \"sequence\" : 5,\n    \"type\" : \"block_added\",\n    \"block_identifier\" : {\n      \"index\" : 1123941,\n      \"hash\" : \"0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85\"\n    }\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<EventsBlocksResponse>(exampleJson)
                        : default(EventsBlocksResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
