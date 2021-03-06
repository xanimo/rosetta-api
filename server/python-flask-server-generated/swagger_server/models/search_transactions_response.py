# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.block_transaction import BlockTransaction  # noqa: F401,E501
from swagger_server import util


class SearchTransactionsResponse(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, transactions: List[BlockTransaction]=None, total_count: int=None, next_offset: int=None):  # noqa: E501
        """SearchTransactionsResponse - a model defined in Swagger

        :param transactions: The transactions of this SearchTransactionsResponse.  # noqa: E501
        :type transactions: List[BlockTransaction]
        :param total_count: The total_count of this SearchTransactionsResponse.  # noqa: E501
        :type total_count: int
        :param next_offset: The next_offset of this SearchTransactionsResponse.  # noqa: E501
        :type next_offset: int
        """
        self.swagger_types = {
            'transactions': List[BlockTransaction],
            'total_count': int,
            'next_offset': int
        }

        self.attribute_map = {
            'transactions': 'transactions',
            'total_count': 'total_count',
            'next_offset': 'next_offset'
        }
        self._transactions = transactions
        self._total_count = total_count
        self._next_offset = next_offset

    @classmethod
    def from_dict(cls, dikt) -> 'SearchTransactionsResponse':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The SearchTransactionsResponse of this SearchTransactionsResponse.  # noqa: E501
        :rtype: SearchTransactionsResponse
        """
        return util.deserialize_model(dikt, cls)

    @property
    def transactions(self) -> List[BlockTransaction]:
        """Gets the transactions of this SearchTransactionsResponse.

        transactions is an array of BlockTransactions sorted by most recent BlockIdentifier (meaning that transactions in recent blocks appear first). If there are many transactions for a particular search, transactions may not contain all matching transactions. It is up to the caller to paginate these transactions using the max_block field.  # noqa: E501

        :return: The transactions of this SearchTransactionsResponse.
        :rtype: List[BlockTransaction]
        """
        return self._transactions

    @transactions.setter
    def transactions(self, transactions: List[BlockTransaction]):
        """Sets the transactions of this SearchTransactionsResponse.

        transactions is an array of BlockTransactions sorted by most recent BlockIdentifier (meaning that transactions in recent blocks appear first). If there are many transactions for a particular search, transactions may not contain all matching transactions. It is up to the caller to paginate these transactions using the max_block field.  # noqa: E501

        :param transactions: The transactions of this SearchTransactionsResponse.
        :type transactions: List[BlockTransaction]
        """
        if transactions is None:
            raise ValueError("Invalid value for `transactions`, must not be `None`")  # noqa: E501

        self._transactions = transactions

    @property
    def total_count(self) -> int:
        """Gets the total_count of this SearchTransactionsResponse.

        total_count is the number of results for a given search. Callers typically use this value to concurrently fetch results by offset or to display a virtual page number associated with results.  # noqa: E501

        :return: The total_count of this SearchTransactionsResponse.
        :rtype: int
        """
        return self._total_count

    @total_count.setter
    def total_count(self, total_count: int):
        """Sets the total_count of this SearchTransactionsResponse.

        total_count is the number of results for a given search. Callers typically use this value to concurrently fetch results by offset or to display a virtual page number associated with results.  # noqa: E501

        :param total_count: The total_count of this SearchTransactionsResponse.
        :type total_count: int
        """
        if total_count is None:
            raise ValueError("Invalid value for `total_count`, must not be `None`")  # noqa: E501

        self._total_count = total_count

    @property
    def next_offset(self) -> int:
        """Gets the next_offset of this SearchTransactionsResponse.

        next_offset is the next offset to use when paginating through transaction results. If this field is not populated, there are no more transactions to query.  # noqa: E501

        :return: The next_offset of this SearchTransactionsResponse.
        :rtype: int
        """
        return self._next_offset

    @next_offset.setter
    def next_offset(self, next_offset: int):
        """Sets the next_offset of this SearchTransactionsResponse.

        next_offset is the next offset to use when paginating through transaction results. If this field is not populated, there are no more transactions to query.  # noqa: E501

        :param next_offset: The next_offset of this SearchTransactionsResponse.
        :type next_offset: int
        """

        self._next_offset = next_offset
