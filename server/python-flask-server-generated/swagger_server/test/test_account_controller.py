# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.account_balance_request import AccountBalanceRequest  # noqa: E501
from swagger_server.models.account_balance_response import AccountBalanceResponse  # noqa: E501
from swagger_server.models.account_coins_request import AccountCoinsRequest  # noqa: E501
from swagger_server.models.account_coins_response import AccountCoinsResponse  # noqa: E501
from swagger_server.models.error import Error  # noqa: E501
from swagger_server.test import BaseTestCase


class TestAccountController(BaseTestCase):
    """AccountController integration test stubs"""

    def test_account_balance(self):
        """Test case for account_balance

        Get an Account's Balance
        """
        body = AccountBalanceRequest()
        response = self.client.open(
            '/account/balance',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_account_coins(self):
        """Test case for account_coins

        Get an Account's Unspent Coins
        """
        body = AccountCoinsRequest()
        response = self.client.open(
            '/account/coins',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
