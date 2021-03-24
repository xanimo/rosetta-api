# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.block import Block  # noqa: F401,E501
from swagger_server.models.transaction_identifier import TransactionIdentifier  # noqa: F401,E501
from swagger_server import util


class BlockResponse(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, block: Block=None, other_transactions: List[TransactionIdentifier]=None):  # noqa: E501
        """BlockResponse - a model defined in Swagger

        :param block: The block of this BlockResponse.  # noqa: E501
        :type block: Block
        :param other_transactions: The other_transactions of this BlockResponse.  # noqa: E501
        :type other_transactions: List[TransactionIdentifier]
        """
        self.swagger_types = {
            'block': Block,
            'other_transactions': List[TransactionIdentifier]
        }

        self.attribute_map = {
            'block': 'block',
            'other_transactions': 'other_transactions'
        }
        self._block = block
        self._other_transactions = other_transactions

    @classmethod
    def from_dict(cls, dikt) -> 'BlockResponse':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The BlockResponse of this BlockResponse.  # noqa: E501
        :rtype: BlockResponse
        """
        return util.deserialize_model(dikt, cls)

    @property
    def block(self) -> Block:
        """Gets the block of this BlockResponse.


        :return: The block of this BlockResponse.
        :rtype: Block
        """
        return self._block

    @block.setter
    def block(self, block: Block):
        """Sets the block of this BlockResponse.


        :param block: The block of this BlockResponse.
        :type block: Block
        """

        self._block = block

    @property
    def other_transactions(self) -> List[TransactionIdentifier]:
        """Gets the other_transactions of this BlockResponse.

        Some blockchains may require additional transactions to be fetched that weren't returned in the block response (ex: block only returns transaction hashes). For blockchains with a lot of transactions in each block, this can be very useful as consumers can concurrently fetch all transactions returned.  # noqa: E501

        :return: The other_transactions of this BlockResponse.
        :rtype: List[TransactionIdentifier]
        """
        return self._other_transactions

    @other_transactions.setter
    def other_transactions(self, other_transactions: List[TransactionIdentifier]):
        """Sets the other_transactions of this BlockResponse.

        Some blockchains may require additional transactions to be fetched that weren't returned in the block response (ex: block only returns transaction hashes). For blockchains with a lot of transactions in each block, this can be very useful as consumers can concurrently fetch all transactions returned.  # noqa: E501

        :param other_transactions: The other_transactions of this BlockResponse.
        :type other_transactions: List[TransactionIdentifier]
        """

        self._other_transactions = other_transactions