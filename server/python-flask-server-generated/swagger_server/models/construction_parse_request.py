# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.network_identifier import NetworkIdentifier  # noqa: F401,E501
from swagger_server import util


class ConstructionParseRequest(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, network_identifier: NetworkIdentifier=None, signed: bool=None, transaction: str=None):  # noqa: E501
        """ConstructionParseRequest - a model defined in Swagger

        :param network_identifier: The network_identifier of this ConstructionParseRequest.  # noqa: E501
        :type network_identifier: NetworkIdentifier
        :param signed: The signed of this ConstructionParseRequest.  # noqa: E501
        :type signed: bool
        :param transaction: The transaction of this ConstructionParseRequest.  # noqa: E501
        :type transaction: str
        """
        self.swagger_types = {
            'network_identifier': NetworkIdentifier,
            'signed': bool,
            'transaction': str
        }

        self.attribute_map = {
            'network_identifier': 'network_identifier',
            'signed': 'signed',
            'transaction': 'transaction'
        }
        self._network_identifier = network_identifier
        self._signed = signed
        self._transaction = transaction

    @classmethod
    def from_dict(cls, dikt) -> 'ConstructionParseRequest':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ConstructionParseRequest of this ConstructionParseRequest.  # noqa: E501
        :rtype: ConstructionParseRequest
        """
        return util.deserialize_model(dikt, cls)

    @property
    def network_identifier(self) -> NetworkIdentifier:
        """Gets the network_identifier of this ConstructionParseRequest.


        :return: The network_identifier of this ConstructionParseRequest.
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier: NetworkIdentifier):
        """Sets the network_identifier of this ConstructionParseRequest.


        :param network_identifier: The network_identifier of this ConstructionParseRequest.
        :type network_identifier: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def signed(self) -> bool:
        """Gets the signed of this ConstructionParseRequest.

        Signed is a boolean indicating whether the transaction is signed.  # noqa: E501

        :return: The signed of this ConstructionParseRequest.
        :rtype: bool
        """
        return self._signed

    @signed.setter
    def signed(self, signed: bool):
        """Sets the signed of this ConstructionParseRequest.

        Signed is a boolean indicating whether the transaction is signed.  # noqa: E501

        :param signed: The signed of this ConstructionParseRequest.
        :type signed: bool
        """
        if signed is None:
            raise ValueError("Invalid value for `signed`, must not be `None`")  # noqa: E501

        self._signed = signed

    @property
    def transaction(self) -> str:
        """Gets the transaction of this ConstructionParseRequest.

        This must be either the unsigned transaction blob returned by `/construction/payloads` or the signed transaction blob returned by `/construction/combine`.  # noqa: E501

        :return: The transaction of this ConstructionParseRequest.
        :rtype: str
        """
        return self._transaction

    @transaction.setter
    def transaction(self, transaction: str):
        """Sets the transaction of this ConstructionParseRequest.

        This must be either the unsigned transaction blob returned by `/construction/payloads` or the signed transaction blob returned by `/construction/combine`.  # noqa: E501

        :param transaction: The transaction of this ConstructionParseRequest.
        :type transaction: str
        """
        if transaction is None:
            raise ValueError("Invalid value for `transaction`, must not be `None`")  # noqa: E501

        self._transaction = transaction
