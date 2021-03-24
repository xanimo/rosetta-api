'use strict';

var utils = require('../utils/writer.js');
var Network = require('../service/NetworkService');

module.exports.networkList = function networkList (req, res, next, body) {
  Network.networkList(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.networkOptions = function networkOptions (req, res, next, body) {
  Network.networkOptions(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.networkStatus = function networkStatus (req, res, next, body) {
  Network.networkStatus(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
