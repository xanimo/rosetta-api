'use strict';


/**
 * Get List of Available Networks
 * This endpoint returns a list of NetworkIdentifiers that the Rosetta server supports.
 *
 * body MetadataRequest 
 * returns NetworkListResponse
 **/
exports.networkList = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "network_identifiers" : [ {
    "blockchain" : "bitcoin",
    "sub_network_identifier" : {
      "metadata" : {
        "producer" : "0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5"
      },
      "network" : "shard 1"
    },
    "network" : "mainnet"
  }, {
    "blockchain" : "bitcoin",
    "sub_network_identifier" : {
      "metadata" : {
        "producer" : "0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5"
      },
      "network" : "shard 1"
    },
    "network" : "mainnet"
  } ]
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Get Network Options
 * This endpoint returns the version information and allowed network-specific types for a NetworkIdentifier. Any NetworkIdentifier returned by /network/list should be accessible here. Because options are retrievable in the context of a NetworkIdentifier, it is possible to define unique options for each network.
 *
 * body NetworkRequest 
 * returns NetworkOptionsResponse
 **/
exports.networkOptions = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "allow" : {
    "balance_exemptions" : [ {
      "sub_account_address" : "staking",
      "currency" : {
        "symbol" : "BTC",
        "metadata" : {
          "Issuer" : "Satoshi"
        },
        "decimals" : 8
      },
      "exemption_type" : "greater_or_equal"
    }, {
      "sub_account_address" : "staking",
      "currency" : {
        "symbol" : "BTC",
        "metadata" : {
          "Issuer" : "Satoshi"
        },
        "decimals" : 8
      },
      "exemption_type" : "greater_or_equal"
    } ],
    "mempool_coins" : true,
    "operation_types" : [ "TRANSFER", "TRANSFER" ],
    "historical_balance_lookup" : true,
    "operation_statuses" : [ {
      "status" : "SUCCESS",
      "successful" : true
    }, {
      "status" : "SUCCESS",
      "successful" : true
    } ],
    "timestamp_start_index" : 0,
    "call_methods" : [ "eth_call", "eth_call" ],
    "errors" : [ {
      "retriable" : true,
      "code" : 12,
      "description" : "This error is returned when the requested AccountIdentifier is improperly formatted.",
      "details" : {
        "address" : "0x1dcc4de8dec75d7aab85b567b6",
        "error" : "not base64"
      },
      "message" : "Invalid account format"
    }, {
      "retriable" : true,
      "code" : 12,
      "description" : "This error is returned when the requested AccountIdentifier is improperly formatted.",
      "details" : {
        "address" : "0x1dcc4de8dec75d7aab85b567b6",
        "error" : "not base64"
      },
      "message" : "Invalid account format"
    } ]
  },
  "version" : {
    "metadata" : { },
    "rosetta_version" : "1.2.5",
    "node_version" : "1.0.2",
    "middleware_version" : "0.2.7"
  }
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Get Network Status
 * This endpoint returns the current status of the network requested. Any NetworkIdentifier returned by /network/list should be accessible here.
 *
 * body NetworkRequest 
 * returns NetworkStatusResponse
 **/
exports.networkStatus = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "current_block_identifier" : {
    "index" : 1123941,
    "hash" : "0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85"
  },
  "peers" : [ {
    "metadata" : { },
    "peer_id" : "0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5"
  }, {
    "metadata" : { },
    "peer_id" : "0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5"
  } ],
  "sync_status" : {
    "target_index" : 150,
    "synced" : true,
    "stage" : "header sync",
    "current_index" : 100
  },
  "current_block_timestamp" : 1582833600000
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

