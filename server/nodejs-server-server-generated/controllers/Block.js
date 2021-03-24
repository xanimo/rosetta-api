'use strict';

var utils = require('../utils/writer.js');
var Block = require('../service/BlockService');

module.exports.block = function block (req, res, next, body) {
  Block.block(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.blockTransaction = function blockTransaction (req, res, next, body) {
  Block.blockTransaction(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
