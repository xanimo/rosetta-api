'use strict';


/**
 * [INDEXER] Get a range of BlockEvents
 * `/events/blocks` allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). `/events/blocks` is considered an \"indexer\" endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \"indexer\" MUST support this endpoint.
 *
 * body EventsBlocksRequest 
 * returns EventsBlocksResponse
 **/
exports.eventsBlocks = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "max_sequence" : 5,
  "events" : [ {
    "sequence" : 5,
    "type" : "block_added",
    "block_identifier" : {
      "index" : 1123941,
      "hash" : "0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85"
    }
  }, {
    "sequence" : 5,
    "type" : "block_added",
    "block_identifier" : {
      "index" : 1123941,
      "hash" : "0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85"
    }
  } ]
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

