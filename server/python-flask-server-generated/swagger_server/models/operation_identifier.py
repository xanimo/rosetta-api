# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class OperationIdentifier(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, index: int=None, network_index: int=None):  # noqa: E501
        """OperationIdentifier - a model defined in Swagger

        :param index: The index of this OperationIdentifier.  # noqa: E501
        :type index: int
        :param network_index: The network_index of this OperationIdentifier.  # noqa: E501
        :type network_index: int
        """
        self.swagger_types = {
            'index': int,
            'network_index': int
        }

        self.attribute_map = {
            'index': 'index',
            'network_index': 'network_index'
        }
        self._index = index
        self._network_index = network_index

    @classmethod
    def from_dict(cls, dikt) -> 'OperationIdentifier':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The OperationIdentifier of this OperationIdentifier.  # noqa: E501
        :rtype: OperationIdentifier
        """
        return util.deserialize_model(dikt, cls)

    @property
    def index(self) -> int:
        """Gets the index of this OperationIdentifier.

        The operation index is used to ensure each operation has a unique identifier within a transaction. This index is only relative to the transaction and NOT GLOBAL. The operations in each transaction should start from index 0. To clarify, there may not be any notion of an operation index in the blockchain being described.  # noqa: E501

        :return: The index of this OperationIdentifier.
        :rtype: int
        """
        return self._index

    @index.setter
    def index(self, index: int):
        """Sets the index of this OperationIdentifier.

        The operation index is used to ensure each operation has a unique identifier within a transaction. This index is only relative to the transaction and NOT GLOBAL. The operations in each transaction should start from index 0. To clarify, there may not be any notion of an operation index in the blockchain being described.  # noqa: E501

        :param index: The index of this OperationIdentifier.
        :type index: int
        """
        if index is None:
            raise ValueError("Invalid value for `index`, must not be `None`")  # noqa: E501

        self._index = index

    @property
    def network_index(self) -> int:
        """Gets the network_index of this OperationIdentifier.

        Some blockchains specify an operation index that is essential for client use. For example, Bitcoin uses a network_index to identify which UTXO was used in a transaction. network_index should not be populated if there is no notion of an operation index in a blockchain (typically most account-based blockchains).  # noqa: E501

        :return: The network_index of this OperationIdentifier.
        :rtype: int
        """
        return self._network_index

    @network_index.setter
    def network_index(self, network_index: int):
        """Sets the network_index of this OperationIdentifier.

        Some blockchains specify an operation index that is essential for client use. For example, Bitcoin uses a network_index to identify which UTXO was used in a transaction. network_index should not be populated if there is no notion of an operation index in a blockchain (typically most account-based blockchains).  # noqa: E501

        :param network_index: The network_index of this OperationIdentifier.
        :type network_index: int
        """

        self._network_index = network_index