# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.mempool_response import MempoolResponse  # noqa: E501
from swagger_server.models.mempool_transaction_request import MempoolTransactionRequest  # noqa: E501
from swagger_server.models.mempool_transaction_response import MempoolTransactionResponse  # noqa: E501
from swagger_server.models.network_request import NetworkRequest  # noqa: E501
from swagger_server.test import BaseTestCase


class TestMempoolController(BaseTestCase):
    """MempoolController integration test stubs"""

    def test_mempool(self):
        """Test case for mempool

        Get All Mempool Transactions
        """
        body = NetworkRequest()
        response = self.client.open(
            '/mempool',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_mempool_transaction(self):
        """Test case for mempool_transaction

        Get a Mempool Transaction
        """
        body = MempoolTransactionRequest()
        response = self.client.open(
            '/mempool/transaction',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
