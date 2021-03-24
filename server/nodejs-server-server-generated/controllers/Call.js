'use strict';

var utils = require('../utils/writer.js');
var Call = require('../service/CallService');

module.exports.call = function call (req, res, next, body) {
  Call.call(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
