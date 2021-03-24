# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.network_identifier import NetworkIdentifier  # noqa: F401,E501
from swagger_server.models.public_key import PublicKey  # noqa: F401,E501
from swagger_server import util


class ConstructionMetadataRequest(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, network_identifier: NetworkIdentifier=None, options: object=None, public_keys: List[PublicKey]=None):  # noqa: E501
        """ConstructionMetadataRequest - a model defined in Swagger

        :param network_identifier: The network_identifier of this ConstructionMetadataRequest.  # noqa: E501
        :type network_identifier: NetworkIdentifier
        :param options: The options of this ConstructionMetadataRequest.  # noqa: E501
        :type options: object
        :param public_keys: The public_keys of this ConstructionMetadataRequest.  # noqa: E501
        :type public_keys: List[PublicKey]
        """
        self.swagger_types = {
            'network_identifier': NetworkIdentifier,
            'options': object,
            'public_keys': List[PublicKey]
        }

        self.attribute_map = {
            'network_identifier': 'network_identifier',
            'options': 'options',
            'public_keys': 'public_keys'
        }
        self._network_identifier = network_identifier
        self._options = options
        self._public_keys = public_keys

    @classmethod
    def from_dict(cls, dikt) -> 'ConstructionMetadataRequest':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ConstructionMetadataRequest of this ConstructionMetadataRequest.  # noqa: E501
        :rtype: ConstructionMetadataRequest
        """
        return util.deserialize_model(dikt, cls)

    @property
    def network_identifier(self) -> NetworkIdentifier:
        """Gets the network_identifier of this ConstructionMetadataRequest.


        :return: The network_identifier of this ConstructionMetadataRequest.
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier: NetworkIdentifier):
        """Sets the network_identifier of this ConstructionMetadataRequest.


        :param network_identifier: The network_identifier of this ConstructionMetadataRequest.
        :type network_identifier: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def options(self) -> object:
        """Gets the options of this ConstructionMetadataRequest.

        Some blockchains require different metadata for different types of transaction construction (ex: delegation versus a transfer). Instead of requiring a blockchain node to return all possible types of metadata for construction (which may require multiple node fetches), the client can populate an options object to limit the metadata returned to only the subset required.  # noqa: E501

        :return: The options of this ConstructionMetadataRequest.
        :rtype: object
        """
        return self._options

    @options.setter
    def options(self, options: object):
        """Sets the options of this ConstructionMetadataRequest.

        Some blockchains require different metadata for different types of transaction construction (ex: delegation versus a transfer). Instead of requiring a blockchain node to return all possible types of metadata for construction (which may require multiple node fetches), the client can populate an options object to limit the metadata returned to only the subset required.  # noqa: E501

        :param options: The options of this ConstructionMetadataRequest.
        :type options: object
        """

        self._options = options

    @property
    def public_keys(self) -> List[PublicKey]:
        """Gets the public_keys of this ConstructionMetadataRequest.


        :return: The public_keys of this ConstructionMetadataRequest.
        :rtype: List[PublicKey]
        """
        return self._public_keys

    @public_keys.setter
    def public_keys(self, public_keys: List[PublicKey]):
        """Sets the public_keys of this ConstructionMetadataRequest.


        :param public_keys: The public_keys of this ConstructionMetadataRequest.
        :type public_keys: List[PublicKey]
        """

        self._public_keys = public_keys