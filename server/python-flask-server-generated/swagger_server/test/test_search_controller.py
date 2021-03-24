# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.search_transactions_request import SearchTransactionsRequest  # noqa: E501
from swagger_server.models.search_transactions_response import SearchTransactionsResponse  # noqa: E501
from swagger_server.test import BaseTestCase


class TestSearchController(BaseTestCase):
    """SearchController integration test stubs"""

    def test_search_transactions(self):
        """Test case for search_transactions

        [INDEXER] Search for Transactions
        """
        body = SearchTransactionsRequest()
        response = self.client.open(
            '/search/transactions',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
