# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.block_identifier import BlockIdentifier  # noqa: F401,E501
from swagger_server.models.transaction import Transaction  # noqa: F401,E501
java.sql.Timestamp  # noqa: F401,E501
from swagger_server import util


class Block(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, block_identifier: BlockIdentifier=None, parent_block_identifier: BlockIdentifier=None, timestamp: Timestamp=None, transactions: List[Transaction]=None, metadata: object=None):  # noqa: E501
        """Block - a model defined in Swagger

        :param block_identifier: The block_identifier of this Block.  # noqa: E501
        :type block_identifier: BlockIdentifier
        :param parent_block_identifier: The parent_block_identifier of this Block.  # noqa: E501
        :type parent_block_identifier: BlockIdentifier
        :param timestamp: The timestamp of this Block.  # noqa: E501
        :type timestamp: Timestamp
        :param transactions: The transactions of this Block.  # noqa: E501
        :type transactions: List[Transaction]
        :param metadata: The metadata of this Block.  # noqa: E501
        :type metadata: object
        """
        self.swagger_types = {
            'block_identifier': BlockIdentifier,
            'parent_block_identifier': BlockIdentifier,
            'timestamp': Timestamp,
            'transactions': List[Transaction],
            'metadata': object
        }

        self.attribute_map = {
            'block_identifier': 'block_identifier',
            'parent_block_identifier': 'parent_block_identifier',
            'timestamp': 'timestamp',
            'transactions': 'transactions',
            'metadata': 'metadata'
        }
        self._block_identifier = block_identifier
        self._parent_block_identifier = parent_block_identifier
        self._timestamp = timestamp
        self._transactions = transactions
        self._metadata = metadata

    @classmethod
    def from_dict(cls, dikt) -> 'Block':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The Block of this Block.  # noqa: E501
        :rtype: Block
        """
        return util.deserialize_model(dikt, cls)

    @property
    def block_identifier(self) -> BlockIdentifier:
        """Gets the block_identifier of this Block.


        :return: The block_identifier of this Block.
        :rtype: BlockIdentifier
        """
        return self._block_identifier

    @block_identifier.setter
    def block_identifier(self, block_identifier: BlockIdentifier):
        """Sets the block_identifier of this Block.


        :param block_identifier: The block_identifier of this Block.
        :type block_identifier: BlockIdentifier
        """
        if block_identifier is None:
            raise ValueError("Invalid value for `block_identifier`, must not be `None`")  # noqa: E501

        self._block_identifier = block_identifier

    @property
    def parent_block_identifier(self) -> BlockIdentifier:
        """Gets the parent_block_identifier of this Block.


        :return: The parent_block_identifier of this Block.
        :rtype: BlockIdentifier
        """
        return self._parent_block_identifier

    @parent_block_identifier.setter
    def parent_block_identifier(self, parent_block_identifier: BlockIdentifier):
        """Sets the parent_block_identifier of this Block.


        :param parent_block_identifier: The parent_block_identifier of this Block.
        :type parent_block_identifier: BlockIdentifier
        """
        if parent_block_identifier is None:
            raise ValueError("Invalid value for `parent_block_identifier`, must not be `None`")  # noqa: E501

        self._parent_block_identifier = parent_block_identifier

    @property
    def timestamp(self) -> Timestamp:
        """Gets the timestamp of this Block.


        :return: The timestamp of this Block.
        :rtype: Timestamp
        """
        return self._timestamp

    @timestamp.setter
    def timestamp(self, timestamp: Timestamp):
        """Sets the timestamp of this Block.


        :param timestamp: The timestamp of this Block.
        :type timestamp: Timestamp
        """
        if timestamp is None:
            raise ValueError("Invalid value for `timestamp`, must not be `None`")  # noqa: E501

        self._timestamp = timestamp

    @property
    def transactions(self) -> List[Transaction]:
        """Gets the transactions of this Block.


        :return: The transactions of this Block.
        :rtype: List[Transaction]
        """
        return self._transactions

    @transactions.setter
    def transactions(self, transactions: List[Transaction]):
        """Sets the transactions of this Block.


        :param transactions: The transactions of this Block.
        :type transactions: List[Transaction]
        """
        if transactions is None:
            raise ValueError("Invalid value for `transactions`, must not be `None`")  # noqa: E501

        self._transactions = transactions

    @property
    def metadata(self) -> object:
        """Gets the metadata of this Block.


        :return: The metadata of this Block.
        :rtype: object
        """
        return self._metadata

    @metadata.setter
    def metadata(self, metadata: object):
        """Sets the metadata of this Block.


        :param metadata: The metadata of this Block.
        :type metadata: object
        """

        self._metadata = metadata
