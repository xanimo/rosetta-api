# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.block_request import BlockRequest  # noqa: E501
from swagger_server.models.block_response import BlockResponse  # noqa: E501
from swagger_server.models.block_transaction_request import BlockTransactionRequest  # noqa: E501
from swagger_server.models.block_transaction_response import BlockTransactionResponse  # noqa: E501
from swagger_server.models.error import Error  # noqa: E501
from swagger_server.test import BaseTestCase


class TestBlockController(BaseTestCase):
    """BlockController integration test stubs"""

    def test_block(self):
        """Test case for block

        Get a Block
        """
        body = BlockRequest()
        response = self.client.open(
            '/block',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_block_transaction(self):
        """Test case for block_transaction

        Get a Block Transaction
        """
        body = BlockTransactionRequest()
        response = self.client.open(
            '/block/transaction',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
