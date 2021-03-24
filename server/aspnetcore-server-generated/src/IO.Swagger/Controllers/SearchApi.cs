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
    public class SearchApiController : ControllerBase
    { 
        /// <summary>
        /// [INDEXER] Search for Transactions
        /// </summary>
        /// <remarks>&#x60;/search/transactions&#x60; allows the caller to search for transactions that meet certain conditions. Some conditions include matching a transaction hash, containing an operation with a certain status, or containing an operation that affects a certain account. &#x60;/search/transactions&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.</remarks>
        /// <param name="body"></param>
        /// <response code="200">Expected response to a valid request</response>
        /// <response code="500">unexpected error</response>
        [HttpPost]
        [Route("/search/transactions")]
        [ValidateModelState]
        [SwaggerOperation("SearchTransactions")]
        [SwaggerResponse(statusCode: 200, type: typeof(SearchTransactionsResponse), description: "Expected response to a valid request")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "unexpected error")]
        public virtual IActionResult SearchTransactions([FromBody]SearchTransactionsRequest body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SearchTransactionsResponse));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"total_count\" : 5,\n  \"transactions\" : [ {\n    \"transaction\" : {\n      \"metadata\" : {\n        \"size\" : 12378,\n        \"lockTime\" : 1582272577\n      },\n      \"operations\" : [ {\n        \"amount\" : {\n          \"metadata\" : { },\n          \"currency\" : {\n            \"symbol\" : \"BTC\",\n            \"metadata\" : {\n              \"Issuer\" : \"Satoshi\"\n            },\n            \"decimals\" : 8\n          },\n          \"value\" : \"1238089899992\"\n        },\n        \"metadata\" : {\n          \"asm\" : \"304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd01 03301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2\",\n          \"hex\" : \"48304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd012103301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2\"\n        },\n        \"related_operations\" : [ {\n          \"index\" : 1\n        }, {\n          \"index\" : 2\n        } ],\n        \"type\" : \"Transfer\",\n        \"coin_change\" : {\n          \"coin_identifier\" : {\n            \"identifier\" : \"0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1\"\n          },\n          \"coin_action\" : \"coin_created\"\n        },\n        \"account\" : {\n          \"metadata\" : { },\n          \"address\" : \"0x3a065000ab4183c6bf581dc1e55a605455fc6d61\",\n          \"sub_account\" : {\n            \"metadata\" : { },\n            \"address\" : \"0x6b175474e89094c44da98b954eedeac495271d0f\"\n          }\n        },\n        \"operation_identifier\" : {\n          \"index\" : 5,\n          \"network_index\" : 0\n        },\n        \"status\" : \"Reverted\"\n      }, {\n        \"amount\" : {\n          \"metadata\" : { },\n          \"currency\" : {\n            \"symbol\" : \"BTC\",\n            \"metadata\" : {\n              \"Issuer\" : \"Satoshi\"\n            },\n            \"decimals\" : 8\n          },\n          \"value\" : \"1238089899992\"\n        },\n        \"metadata\" : {\n          \"asm\" : \"304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd01 03301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2\",\n          \"hex\" : \"48304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd012103301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2\"\n        },\n        \"related_operations\" : [ {\n          \"index\" : 1\n        }, {\n          \"index\" : 2\n        } ],\n        \"type\" : \"Transfer\",\n        \"coin_change\" : {\n          \"coin_identifier\" : {\n            \"identifier\" : \"0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1\"\n          },\n          \"coin_action\" : \"coin_created\"\n        },\n        \"account\" : {\n          \"metadata\" : { },\n          \"address\" : \"0x3a065000ab4183c6bf581dc1e55a605455fc6d61\",\n          \"sub_account\" : {\n            \"metadata\" : { },\n            \"address\" : \"0x6b175474e89094c44da98b954eedeac495271d0f\"\n          }\n        },\n        \"operation_identifier\" : {\n          \"index\" : 5,\n          \"network_index\" : 0\n        },\n        \"status\" : \"Reverted\"\n      } ],\n      \"transaction_identifier\" : {\n        \"hash\" : \"0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f\"\n      },\n      \"related_transactions\" : [ {\n        \"network_identifier\" : {\n          \"blockchain\" : \"bitcoin\",\n          \"sub_network_identifier\" : {\n            \"metadata\" : {\n              \"producer\" : \"0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5\"\n            },\n            \"network\" : \"shard 1\"\n          },\n          \"network\" : \"mainnet\"\n        },\n        \"direction\" : \"forward\"\n      }, {\n        \"network_identifier\" : {\n          \"blockchain\" : \"bitcoin\",\n          \"sub_network_identifier\" : {\n            \"metadata\" : {\n              \"producer\" : \"0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5\"\n            },\n            \"network\" : \"shard 1\"\n          },\n          \"network\" : \"mainnet\"\n        },\n        \"direction\" : \"forward\"\n      } ]\n    },\n    \"block_identifier\" : {\n      \"index\" : 1123941,\n      \"hash\" : \"0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85\"\n    }\n  }, {\n    \"transaction\" : {\n      \"metadata\" : {\n        \"size\" : 12378,\n        \"lockTime\" : 1582272577\n      },\n      \"operations\" : [ {\n        \"amount\" : {\n          \"metadata\" : { },\n          \"currency\" : {\n            \"symbol\" : \"BTC\",\n            \"metadata\" : {\n              \"Issuer\" : \"Satoshi\"\n            },\n            \"decimals\" : 8\n          },\n          \"value\" : \"1238089899992\"\n        },\n        \"metadata\" : {\n          \"asm\" : \"304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd01 03301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2\",\n          \"hex\" : \"48304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd012103301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2\"\n        },\n        \"related_operations\" : [ {\n          \"index\" : 1\n        }, {\n          \"index\" : 2\n        } ],\n        \"type\" : \"Transfer\",\n        \"coin_change\" : {\n          \"coin_identifier\" : {\n            \"identifier\" : \"0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1\"\n          },\n          \"coin_action\" : \"coin_created\"\n        },\n        \"account\" : {\n          \"metadata\" : { },\n          \"address\" : \"0x3a065000ab4183c6bf581dc1e55a605455fc6d61\",\n          \"sub_account\" : {\n            \"metadata\" : { },\n            \"address\" : \"0x6b175474e89094c44da98b954eedeac495271d0f\"\n          }\n        },\n        \"operation_identifier\" : {\n          \"index\" : 5,\n          \"network_index\" : 0\n        },\n        \"status\" : \"Reverted\"\n      }, {\n        \"amount\" : {\n          \"metadata\" : { },\n          \"currency\" : {\n            \"symbol\" : \"BTC\",\n            \"metadata\" : {\n              \"Issuer\" : \"Satoshi\"\n            },\n            \"decimals\" : 8\n          },\n          \"value\" : \"1238089899992\"\n        },\n        \"metadata\" : {\n          \"asm\" : \"304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd01 03301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2\",\n          \"hex\" : \"48304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd012103301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2\"\n        },\n        \"related_operations\" : [ {\n          \"index\" : 1\n        }, {\n          \"index\" : 2\n        } ],\n        \"type\" : \"Transfer\",\n        \"coin_change\" : {\n          \"coin_identifier\" : {\n            \"identifier\" : \"0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1\"\n          },\n          \"coin_action\" : \"coin_created\"\n        },\n        \"account\" : {\n          \"metadata\" : { },\n          \"address\" : \"0x3a065000ab4183c6bf581dc1e55a605455fc6d61\",\n          \"sub_account\" : {\n            \"metadata\" : { },\n            \"address\" : \"0x6b175474e89094c44da98b954eedeac495271d0f\"\n          }\n        },\n        \"operation_identifier\" : {\n          \"index\" : 5,\n          \"network_index\" : 0\n        },\n        \"status\" : \"Reverted\"\n      } ],\n      \"transaction_identifier\" : {\n        \"hash\" : \"0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f\"\n      },\n      \"related_transactions\" : [ {\n        \"network_identifier\" : {\n          \"blockchain\" : \"bitcoin\",\n          \"sub_network_identifier\" : {\n            \"metadata\" : {\n              \"producer\" : \"0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5\"\n            },\n            \"network\" : \"shard 1\"\n          },\n          \"network\" : \"mainnet\"\n        },\n        \"direction\" : \"forward\"\n      }, {\n        \"network_identifier\" : {\n          \"blockchain\" : \"bitcoin\",\n          \"sub_network_identifier\" : {\n            \"metadata\" : {\n              \"producer\" : \"0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5\"\n            },\n            \"network\" : \"shard 1\"\n          },\n          \"network\" : \"mainnet\"\n        },\n        \"direction\" : \"forward\"\n      } ]\n    },\n    \"block_identifier\" : {\n      \"index\" : 1123941,\n      \"hash\" : \"0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85\"\n    }\n  } ],\n  \"next_offset\" : 5\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SearchTransactionsResponse>(exampleJson)
                        : default(SearchTransactionsResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}