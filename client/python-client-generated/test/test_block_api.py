# coding: utf-8

"""
    Rosetta

    Build Once. Integrate Your Blockchain Everywhere.  # noqa: E501

    OpenAPI spec version: 1.4.10
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.block_api import BlockApi  # noqa: E501
from swagger_client.rest import ApiException


class TestBlockApi(unittest.TestCase):
    """BlockApi unit test stubs"""

    def setUp(self):
        self.api = BlockApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_block(self):
        """Test case for block

        Get a Block  # noqa: E501
        """
        pass

    def test_block_transaction(self):
        """Test case for block_transaction

        Get a Block Transaction  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
