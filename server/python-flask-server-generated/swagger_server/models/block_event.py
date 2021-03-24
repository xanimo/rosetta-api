# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.block_event_type import BlockEventType  # noqa: F401,E501
from swagger_server.models.block_identifier import BlockIdentifier  # noqa: F401,E501
from swagger_server import util


class BlockEvent(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, sequence: int=None, block_identifier: BlockIdentifier=None, type: BlockEventType=None):  # noqa: E501
        """BlockEvent - a model defined in Swagger

        :param sequence: The sequence of this BlockEvent.  # noqa: E501
        :type sequence: int
        :param block_identifier: The block_identifier of this BlockEvent.  # noqa: E501
        :type block_identifier: BlockIdentifier
        :param type: The type of this BlockEvent.  # noqa: E501
        :type type: BlockEventType
        """
        self.swagger_types = {
            'sequence': int,
            'block_identifier': BlockIdentifier,
            'type': BlockEventType
        }

        self.attribute_map = {
            'sequence': 'sequence',
            'block_identifier': 'block_identifier',
            'type': 'type'
        }
        self._sequence = sequence
        self._block_identifier = block_identifier
        self._type = type

    @classmethod
    def from_dict(cls, dikt) -> 'BlockEvent':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The BlockEvent of this BlockEvent.  # noqa: E501
        :rtype: BlockEvent
        """
        return util.deserialize_model(dikt, cls)

    @property
    def sequence(self) -> int:
        """Gets the sequence of this BlockEvent.

        sequence is the unique identifier of a BlockEvent within the context of a NetworkIdentifier.  # noqa: E501

        :return: The sequence of this BlockEvent.
        :rtype: int
        """
        return self._sequence

    @sequence.setter
    def sequence(self, sequence: int):
        """Sets the sequence of this BlockEvent.

        sequence is the unique identifier of a BlockEvent within the context of a NetworkIdentifier.  # noqa: E501

        :param sequence: The sequence of this BlockEvent.
        :type sequence: int
        """
        if sequence is None:
            raise ValueError("Invalid value for `sequence`, must not be `None`")  # noqa: E501

        self._sequence = sequence

    @property
    def block_identifier(self) -> BlockIdentifier:
        """Gets the block_identifier of this BlockEvent.


        :return: The block_identifier of this BlockEvent.
        :rtype: BlockIdentifier
        """
        return self._block_identifier

    @block_identifier.setter
    def block_identifier(self, block_identifier: BlockIdentifier):
        """Sets the block_identifier of this BlockEvent.


        :param block_identifier: The block_identifier of this BlockEvent.
        :type block_identifier: BlockIdentifier
        """
        if block_identifier is None:
            raise ValueError("Invalid value for `block_identifier`, must not be `None`")  # noqa: E501

        self._block_identifier = block_identifier

    @property
    def type(self) -> BlockEventType:
        """Gets the type of this BlockEvent.


        :return: The type of this BlockEvent.
        :rtype: BlockEventType
        """
        return self._type

    @type.setter
    def type(self, type: BlockEventType):
        """Sets the type of this BlockEvent.


        :param type: The type of this BlockEvent.
        :type type: BlockEventType
        """
        if type is None:
            raise ValueError("Invalid value for `type`, must not be `None`")  # noqa: E501

        self._type = type