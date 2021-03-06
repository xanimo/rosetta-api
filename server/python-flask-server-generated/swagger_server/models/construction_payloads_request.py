# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.network_identifier import NetworkIdentifier  # noqa: F401,E501
from swagger_server.models.operation import Operation  # noqa: F401,E501
from swagger_server.models.public_key import PublicKey  # noqa: F401,E501
from swagger_server import util


class ConstructionPayloadsRequest(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, network_identifier: NetworkIdentifier=None, operations: List[Operation]=None, metadata: object=None, public_keys: List[PublicKey]=None):  # noqa: E501
        """ConstructionPayloadsRequest - a model defined in Swagger

        :param network_identifier: The network_identifier of this ConstructionPayloadsRequest.  # noqa: E501
        :type network_identifier: NetworkIdentifier
        :param operations: The operations of this ConstructionPayloadsRequest.  # noqa: E501
        :type operations: List[Operation]
        :param metadata: The metadata of this ConstructionPayloadsRequest.  # noqa: E501
        :type metadata: object
        :param public_keys: The public_keys of this ConstructionPayloadsRequest.  # noqa: E501
        :type public_keys: List[PublicKey]
        """
        self.swagger_types = {
            'network_identifier': NetworkIdentifier,
            'operations': List[Operation],
            'metadata': object,
            'public_keys': List[PublicKey]
        }

        self.attribute_map = {
            'network_identifier': 'network_identifier',
            'operations': 'operations',
            'metadata': 'metadata',
            'public_keys': 'public_keys'
        }
        self._network_identifier = network_identifier
        self._operations = operations
        self._metadata = metadata
        self._public_keys = public_keys

    @classmethod
    def from_dict(cls, dikt) -> 'ConstructionPayloadsRequest':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ConstructionPayloadsRequest of this ConstructionPayloadsRequest.  # noqa: E501
        :rtype: ConstructionPayloadsRequest
        """
        return util.deserialize_model(dikt, cls)

    @property
    def network_identifier(self) -> NetworkIdentifier:
        """Gets the network_identifier of this ConstructionPayloadsRequest.


        :return: The network_identifier of this ConstructionPayloadsRequest.
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier: NetworkIdentifier):
        """Sets the network_identifier of this ConstructionPayloadsRequest.


        :param network_identifier: The network_identifier of this ConstructionPayloadsRequest.
        :type network_identifier: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def operations(self) -> List[Operation]:
        """Gets the operations of this ConstructionPayloadsRequest.


        :return: The operations of this ConstructionPayloadsRequest.
        :rtype: List[Operation]
        """
        return self._operations

    @operations.setter
    def operations(self, operations: List[Operation]):
        """Sets the operations of this ConstructionPayloadsRequest.


        :param operations: The operations of this ConstructionPayloadsRequest.
        :type operations: List[Operation]
        """
        if operations is None:
            raise ValueError("Invalid value for `operations`, must not be `None`")  # noqa: E501

        self._operations = operations

    @property
    def metadata(self) -> object:
        """Gets the metadata of this ConstructionPayloadsRequest.


        :return: The metadata of this ConstructionPayloadsRequest.
        :rtype: object
        """
        return self._metadata

    @metadata.setter
    def metadata(self, metadata: object):
        """Sets the metadata of this ConstructionPayloadsRequest.


        :param metadata: The metadata of this ConstructionPayloadsRequest.
        :type metadata: object
        """

        self._metadata = metadata

    @property
    def public_keys(self) -> List[PublicKey]:
        """Gets the public_keys of this ConstructionPayloadsRequest.


        :return: The public_keys of this ConstructionPayloadsRequest.
        :rtype: List[PublicKey]
        """
        return self._public_keys

    @public_keys.setter
    def public_keys(self, public_keys: List[PublicKey]):
        """Sets the public_keys of this ConstructionPayloadsRequest.


        :param public_keys: The public_keys of this ConstructionPayloadsRequest.
        :type public_keys: List[PublicKey]
        """

        self._public_keys = public_keys
