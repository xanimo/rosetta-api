# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.network_identifier import NetworkIdentifier  # noqa: F401,E501
from swagger_server.models.transaction_identifier import TransactionIdentifier  # noqa: F401,E501
from swagger_server import util


class MempoolTransactionRequest(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, network_identifier: NetworkIdentifier=None, transaction_identifier: TransactionIdentifier=None):  # noqa: E501
        """MempoolTransactionRequest - a model defined in Swagger

        :param network_identifier: The network_identifier of this MempoolTransactionRequest.  # noqa: E501
        :type network_identifier: NetworkIdentifier
        :param transaction_identifier: The transaction_identifier of this MempoolTransactionRequest.  # noqa: E501
        :type transaction_identifier: TransactionIdentifier
        """
        self.swagger_types = {
            'network_identifier': NetworkIdentifier,
            'transaction_identifier': TransactionIdentifier
        }

        self.attribute_map = {
            'network_identifier': 'network_identifier',
            'transaction_identifier': 'transaction_identifier'
        }
        self._network_identifier = network_identifier
        self._transaction_identifier = transaction_identifier

    @classmethod
    def from_dict(cls, dikt) -> 'MempoolTransactionRequest':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The MempoolTransactionRequest of this MempoolTransactionRequest.  # noqa: E501
        :rtype: MempoolTransactionRequest
        """
        return util.deserialize_model(dikt, cls)

    @property
    def network_identifier(self) -> NetworkIdentifier:
        """Gets the network_identifier of this MempoolTransactionRequest.


        :return: The network_identifier of this MempoolTransactionRequest.
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier: NetworkIdentifier):
        """Sets the network_identifier of this MempoolTransactionRequest.


        :param network_identifier: The network_identifier of this MempoolTransactionRequest.
        :type network_identifier: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def transaction_identifier(self) -> TransactionIdentifier:
        """Gets the transaction_identifier of this MempoolTransactionRequest.


        :return: The transaction_identifier of this MempoolTransactionRequest.
        :rtype: TransactionIdentifier
        """
        return self._transaction_identifier

    @transaction_identifier.setter
    def transaction_identifier(self, transaction_identifier: TransactionIdentifier):
        """Sets the transaction_identifier of this MempoolTransactionRequest.


        :param transaction_identifier: The transaction_identifier of this MempoolTransactionRequest.
        :type transaction_identifier: TransactionIdentifier
        """
        if transaction_identifier is None:
            raise ValueError("Invalid value for `transaction_identifier`, must not be `None`")  # noqa: E501

        self._transaction_identifier = transaction_identifier
