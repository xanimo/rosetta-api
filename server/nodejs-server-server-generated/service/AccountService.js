'use strict';


/**
 * Get an Account's Balance
 * Get an array of all AccountBalances for an AccountIdentifier and the BlockIdentifier at which the balance lookup was performed. The BlockIdentifier must always be returned because some consumers of account balance data need to know specifically at which block the balance was calculated to compare balances they compute from operations with the balance returned by the node. It is important to note that making a balance request for an account without populating the SubAccountIdentifier should not result in the balance of all possible SubAccountIdentifiers being returned. Rather, it should result in the balance pertaining to no SubAccountIdentifiers being returned (sometimes called the liquid balance). To get all balances associated with an account, it may be necessary to perform multiple balance requests with unique AccountIdentifiers. It is also possible to perform a historical balance lookup (if the server supports it) by passing in an optional BlockIdentifier.
 *
 * body AccountBalanceRequest 
 * returns AccountBalanceResponse
 **/
exports.accountBalance = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "balances" : [ {
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
  } ],
  "metadata" : {
    "sequence_number" : 23
  },
  "block_identifier" : {
    "index" : 1123941,
    "hash" : "0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85"
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
 * Get an Account's Unspent Coins
 * Get an array of all unspent coins for an AccountIdentifier and the BlockIdentifier at which the lookup was performed. If your implementation does not support coins (i.e. it is for an account-based blockchain), you do not need to implement this endpoint. If you implementation does support coins (i.e. it is fro a UTXO-based blockchain), you MUST also complete the `/account/balance` endpoint. It is important to note that making a coins request for an account without populating the SubAccountIdentifier should not result in the coins of all possible SubAccountIdentifiers being returned. Rather, it should result in the coins pertaining to no SubAccountIdentifiers being returned. To get all coins associated with an account, it may be necessary to perform multiple coin requests with unique AccountIdentifiers. Optionally, an implementation may choose to support updating an AccountIdentifier's unspent coins based on the contents of the mempool. Note, using this functionality breaks any guarantee of idempotency.
 *
 * body AccountCoinsRequest 
 * returns AccountCoinsResponse
 **/
exports.accountCoins = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "metadata" : {
    "sequence_number" : 23
  },
  "coins" : [ {
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
    "coin_identifier" : {
      "identifier" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1"
    }
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
    "coin_identifier" : {
      "identifier" : "0x2f23fd8cca835af21f3ac375bac601f97ead75f2e79143bdf71fe2c4be043e8f:1"
    }
  } ],
  "block_identifier" : {
    "index" : 1123941,
    "hash" : "0x1f2cc6c5027d2f201a5453ad1119574d2aed23a392654742ac3c78783c071f85"
  }
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

