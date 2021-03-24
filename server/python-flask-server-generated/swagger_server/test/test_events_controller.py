# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.events_blocks_request import EventsBlocksRequest  # noqa: E501
from swagger_server.models.events_blocks_response import EventsBlocksResponse  # noqa: E501
from swagger_server.test import BaseTestCase


class TestEventsController(BaseTestCase):
    """EventsController integration test stubs"""

    def test_events_blocks(self):
        """Test case for events_blocks

        [INDEXER] Get a range of BlockEvents
        """
        body = EventsBlocksRequest()
        response = self.client.open(
            '/events/blocks',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
