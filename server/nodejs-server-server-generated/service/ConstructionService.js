'use strict';


/**
 * Create Network Transaction from Signatures
 * Combine creates a network-specific transaction from an unsigned transaction and an array of provided signatures. The signed transaction returned from this method will be sent to the `/construction/submit` endpoint by the caller.
 *
 * body ConstructionCombineRequest 
 * returns ConstructionCombineResponse
 **/
exports.constructionCombine = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "signed_transaction" : "signed_transaction"
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Derive an AccountIdentifier from a PublicKey
 * Derive returns the AccountIdentifier associated with a public key. Blockchains that require an on-chain action to create an account should not implement this method.
 *
 * body ConstructionDeriveRequest 
 * returns ConstructionDeriveResponse
 **/
exports.constructionDerive = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "metadata" : { },
  "address" : "address",
  "account_identifier" : {
    "metadata" : { },
    "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
    "sub_account" : {
      "metadata" : { },
      "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
    }
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
 * Get the Hash of a Signed Transaction
 * TransactionHash returns the network-specific transaction hash for a signed transaction.
 *
 * body ConstructionHashRequest 
 * returns TransactionIdentifierResponse
 **/
exports.constructionHash = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "metadata" : { },
  "transaction_identifier" : {
    "hash" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f"
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
 * Get Metadata for Transaction Construction
 * Get any information required to construct a transaction for a specific network. Metadata returned here could be a recent hash to use, an account sequence number, or even arbitrary chain state. The request used when calling this endpoint is created by calling `/construction/preprocess` in an offline environment. You should NEVER assume that the request sent to this endpoint will be created by the caller or populated with any custom parameters. This must occur in `/construction/preprocess`. It is important to clarify that this endpoint should not pre-construct any transactions for the client (this should happen in `/construction/payloads`). This endpoint is left purposely unstructured because of the wide scope of metadata that could be required.
 *
 * body ConstructionMetadataRequest 
 * returns ConstructionMetadataResponse
 **/
exports.constructionMetadata = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "metadata" : {
    "account_sequence" : 23,
    "recent_block_hash" : "0x52bc44d5378309ee2abf1539bf71de1b7d7be3b5"
  },
  "suggested_fee" : [ {
    "metadata" : { },
    "currency" : {
      "symbol" : "BTC",
      "metadata" : {
        "Issuer" : "Satoshi"
      },
      "decimals" : 8
    },
    "value" : "1238089899992"
  }, {
    "metadata" : { },
    "currency" : {
      "symbol" : "BTC",
      "metadata" : {
        "Issuer" : "Satoshi"
      },
      "decimals" : 8
    },
    "value" : "1238089899992"
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
 * Parse a Transaction
 * Parse is called on both unsigned and signed transactions to understand the intent of the formulated transaction. This is run as a sanity check before signing (after `/construction/payloads`) and before broadcast (after `/construction/combine`). 
 *
 * body ConstructionParseRequest 
 * returns ConstructionParseResponse
 **/
exports.constructionParse = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "signers" : [ "signers", "signers" ],
  "metadata" : { },
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
  "account_identifier_signers" : [ {
    "metadata" : { },
    "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
    "sub_account" : {
      "metadata" : { },
      "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
    }
  }, {
    "metadata" : { },
    "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
    "sub_account" : {
      "metadata" : { },
      "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
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


/**
 * Generate an Unsigned Transaction and Signing Payloads
 * Payloads is called with an array of operations and the response from `/construction/metadata`. It returns an unsigned transaction blob and a collection of payloads that must be signed by particular AccountIdentifiers using a certain SignatureType. The array of operations provided in transaction construction often times can not specify all \"effects\" of a transaction (consider invoked transactions in Ethereum). However, they can deterministically specify the \"intent\" of the transaction, which is sufficient for construction. For this reason, parsing the corresponding transaction in the Data API (when it lands on chain) will contain a superset of whatever operations were provided during construction.
 *
 * body ConstructionPayloadsRequest 
 * returns ConstructionPayloadsResponse
 **/
exports.constructionPayloads = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "unsigned_transaction" : "unsigned_transaction",
  "payloads" : [ {
    "address" : "address",
    "account_identifier" : {
      "metadata" : { },
      "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
      "sub_account" : {
        "metadata" : { },
        "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
      }
    },
    "hex_bytes" : "hex_bytes",
    "signature_type" : "ecdsa"
  }, {
    "address" : "address",
    "account_identifier" : {
      "metadata" : { },
      "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
      "sub_account" : {
        "metadata" : { },
        "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
      }
    },
    "hex_bytes" : "hex_bytes",
    "signature_type" : "ecdsa"
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
 * Create a Request to Fetch Metadata
 * Preprocess is called prior to `/construction/payloads` to construct a request for any metadata that is needed for transaction construction given (i.e. account nonce). The `options` object returned from this endpoint will be sent to the `/construction/metadata` endpoint UNMODIFIED by the caller (in an offline execution environment). If your Construction API implementation has configuration options, they MUST be specified in the `/construction/preprocess` request (in the `metadata` field).
 *
 * body ConstructionPreprocessRequest 
 * returns ConstructionPreprocessResponse
 **/
exports.constructionPreprocess = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "options" : { },
  "required_public_keys" : [ {
    "metadata" : { },
    "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
    "sub_account" : {
      "metadata" : { },
      "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
    }
  }, {
    "metadata" : { },
    "address" : "0x3a065000ab4183c6bf581dc1e55a605455fc6d61",
    "sub_account" : {
      "metadata" : { },
      "address" : "0x6b175474e89094c44da98b954eedeac495271d0f"
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


/**
 * Submit a Signed Transaction
 * Submit a pre-signed transaction to the node. This call should not block on the transaction being included in a block. Rather, it should return immediately with an indication of whether or not the transaction was included in the mempool. The transaction submission response should only return a 200 status if the submitted transaction could be included in the mempool. Otherwise, it should return an error.
 *
 * body ConstructionSubmitRequest 
 * returns TransactionIdentifierResponse
 **/
exports.constructionSubmit = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "metadata" : { },
  "transaction_identifier" : {
    "hash" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f"
  }
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

