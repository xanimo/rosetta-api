# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.network_identifier import NetworkIdentifier  # noqa: F401,E501
from swagger_server.models.signature import Signature  # noqa: F401,E501
from swagger_server import util


class ConstructionCombineRequest(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, network_identifier: NetworkIdentifier=None, unsigned_transaction: str=None, signatures: List[Signature]=None):  # noqa: E501
        """ConstructionCombineRequest - a model defined in Swagger

        :param network_identifier: The network_identifier of this ConstructionCombineRequest.  # noqa: E501
        :type network_identifier: NetworkIdentifier
        :param unsigned_transaction: The unsigned_transaction of this ConstructionCombineRequest.  # noqa: E501
        :type unsigned_transaction: str
        :param signatures: The signatures of this ConstructionCombineRequest.  # noqa: E501
        :type signatures: List[Signature]
        """
        self.swagger_types = {
            'network_identifier': NetworkIdentifier,
            'unsigned_transaction': str,
            'signatures': List[Signature]
        }

        self.attribute_map = {
            'network_identifier': 'network_identifier',
            'unsigned_transaction': 'unsigned_transaction',
            'signatures': 'signatures'
        }
        self._network_identifier = network_identifier
        self._unsigned_transaction = unsigned_transaction
        self._signatures = signatures

    @classmethod
    def from_dict(cls, dikt) -> 'ConstructionCombineRequest':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ConstructionCombineRequest of this ConstructionCombineRequest.  # noqa: E501
        :rtype: ConstructionCombineRequest
        """
        return util.deserialize_model(dikt, cls)

    @property
    def network_identifier(self) -> NetworkIdentifier:
        """Gets the network_identifier of this ConstructionCombineRequest.


        :return: The network_identifier of this ConstructionCombineRequest.
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier: NetworkIdentifier):
        """Sets the network_identifier of this ConstructionCombineRequest.


        :param network_identifier: The network_identifier of this ConstructionCombineRequest.
        :type network_identifier: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def unsigned_transaction(self) -> str:
        """Gets the unsigned_transaction of this ConstructionCombineRequest.


        :return: The unsigned_transaction of this ConstructionCombineRequest.
        :rtype: str
        """
        return self._unsigned_transaction

    @unsigned_transaction.setter
    def unsigned_transaction(self, unsigned_transaction: str):
        """Sets the unsigned_transaction of this ConstructionCombineRequest.


        :param unsigned_transaction: The unsigned_transaction of this ConstructionCombineRequest.
        :type unsigned_transaction: str
        """
        if unsigned_transaction is None:
            raise ValueError("Invalid value for `unsigned_transaction`, must not be `None`")  # noqa: E501

        self._unsigned_transaction = unsigned_transaction

    @property
    def signatures(self) -> List[Signature]:
        """Gets the signatures of this ConstructionCombineRequest.


        :return: The signatures of this ConstructionCombineRequest.
        :rtype: List[Signature]
        """
        return self._signatures

    @signatures.setter
    def signatures(self, signatures: List[Signature]):
        """Sets the signatures of this ConstructionCombineRequest.


        :param signatures: The signatures of this ConstructionCombineRequest.
        :type signatures: List[Signature]
        """
        if signatures is None:
            raise ValueError("Invalid value for `signatures`, must not be `None`")  # noqa: E501

        self._signatures = signatures