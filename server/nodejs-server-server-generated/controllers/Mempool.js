'use strict';

var utils = require('../utils/writer.js');
var Mempool = require('../service/MempoolService');

module.exports.mempool = function mempool (req, res, next, body) {
  Mempool.mempool(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.mempoolTransaction = function mempoolTransaction (req, res, next, body) {
  Mempool.mempoolTransaction(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
