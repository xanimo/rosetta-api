# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.metadata_request import MetadataRequest  # noqa: E501
from swagger_server.models.network_list_response import NetworkListResponse  # noqa: E501
from swagger_server.models.network_options_response import NetworkOptionsResponse  # noqa: E501
from swagger_server.models.network_request import NetworkRequest  # noqa: E501
from swagger_server.models.network_status_response import NetworkStatusResponse  # noqa: E501
from swagger_server.test import BaseTestCase


class TestNetworkController(BaseTestCase):
    """NetworkController integration test stubs"""

    def test_network_list(self):
        """Test case for network_list

        Get List of Available Networks
        """
        body = MetadataRequest()
        response = self.client.open(
            '/network/list',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_network_options(self):
        """Test case for network_options

        Get Network Options
        """
        body = NetworkRequest()
        response = self.client.open(
            '/network/options',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_network_status(self):
        """Test case for network_status

        Get Network Status
        """
        body = NetworkRequest()
        response = self.client.open(
            '/network/status',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
