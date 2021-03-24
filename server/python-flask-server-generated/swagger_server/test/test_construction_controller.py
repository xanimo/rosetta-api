# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.construction_combine_request import ConstructionCombineRequest  # noqa: E501
from swagger_server.models.construction_combine_response import ConstructionCombineResponse  # noqa: E501
from swagger_server.models.construction_derive_request import ConstructionDeriveRequest  # noqa: E501
from swagger_server.models.construction_derive_response import ConstructionDeriveResponse  # noqa: E501
from swagger_server.models.construction_hash_request import ConstructionHashRequest  # noqa: E501
from swagger_server.models.construction_metadata_request import ConstructionMetadataRequest  # noqa: E501
from swagger_server.models.construction_metadata_response import ConstructionMetadataResponse  # noqa: E501
from swagger_server.models.construction_parse_request import ConstructionParseRequest  # noqa: E501
from swagger_server.models.construction_parse_response import ConstructionParseResponse  # noqa: E501
from swagger_server.models.construction_payloads_request import ConstructionPayloadsRequest  # noqa: E501
from swagger_server.models.construction_payloads_response import ConstructionPayloadsResponse  # noqa: E501
from swagger_server.models.construction_preprocess_request import ConstructionPreprocessRequest  # noqa: E501
from swagger_server.models.construction_preprocess_response import ConstructionPreprocessResponse  # noqa: E501
from swagger_server.models.construction_submit_request import ConstructionSubmitRequest  # noqa: E501
from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.transaction_identifier_response import TransactionIdentifierResponse  # noqa: E501
from swagger_server.test import BaseTestCase


class TestConstructionController(BaseTestCase):
    """ConstructionController integration test stubs"""

    def test_construction_combine(self):
        """Test case for construction_combine

        Create Network Transaction from Signatures
        """
        body = ConstructionCombineRequest()
        response = self.client.open(
            '/construction/combine',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_construction_derive(self):
        """Test case for construction_derive

        Derive an AccountIdentifier from a PublicKey
        """
        body = ConstructionDeriveRequest()
        response = self.client.open(
            '/construction/derive',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_construction_hash(self):
        """Test case for construction_hash

        Get the Hash of a Signed Transaction
        """
        body = ConstructionHashRequest()
        response = self.client.open(
            '/construction/hash',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_construction_metadata(self):
        """Test case for construction_metadata

        Get Metadata for Transaction Construction
        """
        body = ConstructionMetadataRequest()
        response = self.client.open(
            '/construction/metadata',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_construction_parse(self):
        """Test case for construction_parse

        Parse a Transaction
        """
        body = ConstructionParseRequest()
        response = self.client.open(
            '/construction/parse',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_construction_payloads(self):
        """Test case for construction_payloads

        Generate an Unsigned Transaction and Signing Payloads
        """
        body = ConstructionPayloadsRequest()
        response = self.client.open(
            '/construction/payloads',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_construction_preprocess(self):
        """Test case for construction_preprocess

        Create a Request to Fetch Metadata
        """
        body = ConstructionPreprocessRequest()
        response = self.client.open(
            '/construction/preprocess',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_construction_submit(self):
        """Test case for construction_submit

        Submit a Signed Transaction
        """
        body = ConstructionSubmitRequest()
        response = self.client.open(
            '/construction/submit',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
