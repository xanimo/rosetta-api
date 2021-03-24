# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.direction import Direction  # noqa: F401,E501
from swagger_server.models.network_identifier import NetworkIdentifier  # noqa: F401,E501
from swagger_server.models.transaction_identifier import TransactionIdentifier  # noqa: F401,E501
from swagger_server import util


class RelatedTransaction(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, network_identifier: NetworkIdentifier=None, transaction_identifier: TransactionIdentifier=None, direction: Direction=None):  # noqa: E501
        """RelatedTransaction - a model defined in Swagger

        :param network_identifier: The network_identifier of this RelatedTransaction.  # noqa: E501
        :type network_identifier: NetworkIdentifier
        :param transaction_identifier: The transaction_identifier of this RelatedTransaction.  # noqa: E501
        :type transaction_identifier: TransactionIdentifier
        :param direction: The direction of this RelatedTransaction.  # noqa: E501
        :type direction: Direction
        """
        self.swagger_types = {
            'network_identifier': NetworkIdentifier,
            'transaction_identifier': TransactionIdentifier,
            'direction': Direction
        }

        self.attribute_map = {
            'network_identifier': 'network_identifier',
            'transaction_identifier': 'transaction_identifier',
            'direction': 'direction'
        }
        self._network_identifier = network_identifier
        self._transaction_identifier = transaction_identifier
        self._direction = direction

    @classmethod
    def from_dict(cls, dikt) -> 'RelatedTransaction':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The RelatedTransaction of this RelatedTransaction.  # noqa: E501
        :rtype: RelatedTransaction
        """
        return util.deserialize_model(dikt, cls)

    @property
    def network_identifier(self) -> NetworkIdentifier:
        """Gets the network_identifier of this RelatedTransaction.


        :return: The network_identifier of this RelatedTransaction.
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier: NetworkIdentifier):
        """Sets the network_identifier of this RelatedTransaction.


        :param network_identifier: The network_identifier of this RelatedTransaction.
        :type network_identifier: NetworkIdentifier
        """

        self._network_identifier = network_identifier

    @property
    def transaction_identifier(self) -> TransactionIdentifier:
        """Gets the transaction_identifier of this RelatedTransaction.


        :return: The transaction_identifier of this RelatedTransaction.
        :rtype: TransactionIdentifier
        """
        return self._transaction_identifier

    @transaction_identifier.setter
    def transaction_identifier(self, transaction_identifier: TransactionIdentifier):
        """Sets the transaction_identifier of this RelatedTransaction.


        :param transaction_identifier: The transaction_identifier of this RelatedTransaction.
        :type transaction_identifier: TransactionIdentifier
        """
        if transaction_identifier is None:
            raise ValueError("Invalid value for `transaction_identifier`, must not be `None`")  # noqa: E501

        self._transaction_identifier = transaction_identifier

    @property
    def direction(self) -> Direction:
        """Gets the direction of this RelatedTransaction.


        :return: The direction of this RelatedTransaction.
        :rtype: Direction
        """
        return self._direction

    @direction.setter
    def direction(self, direction: Direction):
        """Sets the direction of this RelatedTransaction.


        :param direction: The direction of this RelatedTransaction.
        :type direction: Direction
        """
        if direction is None:
            raise ValueError("Invalid value for `direction`, must not be `None`")  # noqa: E501

        self._direction = direction
