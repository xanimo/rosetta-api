'use strict';

var utils = require('../utils/writer.js');
var Construction = require('../service/ConstructionService');

module.exports.constructionCombine = function constructionCombine (req, res, next, body) {
  Construction.constructionCombine(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.constructionDerive = function constructionDerive (req, res, next, body) {
  Construction.constructionDerive(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.constructionHash = function constructionHash (req, res, next, body) {
  Construction.constructionHash(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.constructionMetadata = function constructionMetadata (req, res, next, body) {
  Construction.constructionMetadata(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.constructionParse = function constructionParse (req, res, next, body) {
  Construction.constructionParse(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.constructionPayloads = function constructionPayloads (req, res, next, body) {
  Construction.constructionPayloads(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.constructionPreprocess = function constructionPreprocess (req, res, next, body) {
  Construction.constructionPreprocess(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.constructionSubmit = function constructionSubmit (req, res, next, body) {
  Construction.constructionSubmit(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
