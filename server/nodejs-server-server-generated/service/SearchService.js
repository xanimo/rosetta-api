'use strict';


/**
 * [INDEXER] Search for Transactions
 * `/search/transactions` allows the caller to search for transactions that meet certain conditions. Some conditions include matching a transaction hash, containing an operation with a certain status, or containing an operation that affects a certain account. `/search/transactions` is considered an \"indexer\" endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \"indexer\" MUST support this endpoint.
 *
 * body SearchTransactionsRequest 
 * returns SearchTransactionsResponse
 **/
exports.searchTransactions = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "total_count" : 5,
  "transactions" : [ {
    "transaction" : {
      "metadata" : {
        "size" : 12378,
        "lockTime" : 1582272577
      },
      "operations" : [ {
        "amount" : {
          "metadata" : { },
          "currency" : {
            "symbol" : "BTC",
            "metadata" : {
              "Issuer" : "Satoshi"
            },
            "decimals" : 8
          },
          "value" : "1238089899992"
        },
        "metadata" : {
          "asm" : "304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd01 03301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2",
          "hex" : "48304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd012103301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2"
        },
        "related_operations" : [ {
          "index" : 1
        }, {
          "index" : 2
        } ],
        "type" : "Transfer",
        "coin_change" : {
          "coin_identifier" : {
            "identifier" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1"
          },
          "coin_action" : "coin_created"
        },
        "account" : {
          "metadata" : { },
          "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
          "sub_account" : {
            "metadata" : { },
            "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
          }
        },
        "operation_identifier" : {
          "index" : 5,
          "network_index" : 0
        },
        "status" : "Reverted"
      }, {
        "amount" : {
          "metadata" : { },
          "currency" : {
            "symbol" : "BTC",
            "metadata" : {
              "Issuer" : "Satoshi"
            },
            "decimals" : 8
          },
          "value" : "1238089899992"
        },
        "metadata" : {
          "asm" : "304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd01 03301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2",
          "hex" : "48304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd012103301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2"
        },
        "related_operations" : [ {
          "index" : 1
        }, {
          "index" : 2
        } ],
        "type" : "Transfer",
        "coin_change" : {
          "coin_identifier" : {
            "identifier" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1"
          },
          "coin_action" : "coin_created"
        },
        "account" : {
          "metadata" : { },
          "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
          "sub_account" : {
            "metadata" : { },
            "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
          }
        },
        "operation_identifier" : {
          "index" : 5,
          "network_index" : 0
        },
        "status" : "Reverted"
      } ],
      "transaction_identifier" : {
        "hash" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f"
      },
      "related_transactions" : [ {
        "network_identifier" : {
          "blockchain" : "bitcoin",
          "sub_network_identifier" : {
            "metadata" : {
              "producer" : "0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5"
            },
            "network" : "shard 1"
          },
          "network" : "mainnet"
        },
        "direction" : "forward"
      }, {
        "network_identifier" : {
          "blockchain" : "bitcoin",
          "sub_network_identifier" : {
            "metadata" : {
              "producer" : "0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5"
            },
            "network" : "shard 1"
          },
          "network" : "mainnet"
        },
        "direction" : "forward"
      } ]
    },
    "block_identifier" : {
      "index" : 1123941,
      "hash" : "0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85"
    }
  }, {
    "transaction" : {
      "metadata" : {
        "size" : 12378,
        "lockTime" : 1582272577
      },
      "operations" : [ {
        "amount" : {
          "metadata" : { },
          "currency" : {
            "symbol" : "BTC",
            "metadata" : {
              "Issuer" : "Satoshi"
            },
            "decimals" : 8
          },
          "value" : "1238089899992"
        },
        "metadata" : {
          "asm" : "304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd01 03301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2",
          "hex" : "48304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd012103301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2"
        },
        "related_operations" : [ {
          "index" : 1
        }, {
          "index" : 2
        } ],
        "type" : "Transfer",
        "coin_change" : {
          "coin_identifier" : {
            "identifier" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1"
          },
          "coin_action" : "coin_created"
        },
        "account" : {
          "metadata" : { },
          "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
          "sub_account" : {
            "metadata" : { },
            "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
          }
        },
        "operation_identifier" : {
          "index" : 5,
          "network_index" : 0
        },
        "status" : "Reverted"
      }, {
        "amount" : {
          "metadata" : { },
          "currency" : {
            "symbol" : "BTC",
            "metadata" : {
              "Issuer" : "Satoshi"
            },
            "decimals" : 8
          },
          "value" : "1238089899992"
        },
        "metadata" : {
          "asm" : "304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd01 03301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2",
          "hex" : "48304502201fd8abb11443f8b1b9a04e0495e0543d05611473a790c8939f089d073f90509a022100f4677825136605d732e2126d09a2d38c20c75946cd9fc239c0497e84c634e3dd012103301a8259a12e35694cc22ebc45fee635f4993064190f6ce96e7fb19a03bb6be2"
        },
        "related_operations" : [ {
          "index" : 1
        }, {
          "index" : 2
        } ],
        "type" : "Transfer",
        "coin_change" : {
          "coin_identifier" : {
            "identifier" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1"
          },
          "coin_action" : "coin_created"
        },
        "account" : {
          "metadata" : { },
          "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
          "sub_account" : {
            "metadata" : { },
            "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
          }
        },
        "operation_identifier" : {
          "index" : 5,
          "network_index" : 0
        },
        "status" : "Reverted"
      } ],
      "transaction_identifier" : {
        "hash" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f"
      },
      "related_transactions" : [ {
        "network_identifier" : {
          "blockchain" : "bitcoin",
          "sub_network_identifier" : {
            "metadata" : {
              "producer" : "0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5"
            },
            "network" : "shard 1"
          },
          "network" : "mainnet"
        },
        "direction" : "forward"
      }, {
        "network_identifier" : {
          "blockchain" : "bitcoin",
          "sub_network_identifier" : {
            "metadata" : {
              "producer" : "0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5"
            },
            "network" : "shard 1"
          },
          "network" : "mainnet"
        },
        "direction" : "forward"
      } ]
    },
    "block_identifier" : {
      "index" : 1123941,
      "hash" : "0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85"
    }
  } ],
  "next_offset" : 5
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

