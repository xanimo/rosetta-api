# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.call_request import CallRequest  # noqa: E501
from swagger_server.models.call_response import CallResponse  # noqa: E501
from swagger_server.models.error import Error  # noqa: E501
from swagger_server.test import BaseTestCase


class TestCallController(BaseTestCase):
    """CallController integration test stubs"""

    def test_call(self):
        """Test case for call

        Make a Network-Specific Procedure Call
        """
        body = CallRequest()
        response = self.client.open(
            '/call',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
