# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.network_identifier import NetworkIdentifier  # noqa: F401,E501
from swagger_server import util


class EventsBlocksRequest(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, network_identifier: NetworkIdentifier=None, offset: int=None, limit: int=None):  # noqa: E501
        """EventsBlocksRequest - a model defined in Swagger

        :param network_identifier: The network_identifier of this EventsBlocksRequest.  # noqa: E501
        :type network_identifier: NetworkIdentifier
        :param offset: The offset of this EventsBlocksRequest.  # noqa: E501
        :type offset: int
        :param limit: The limit of this EventsBlocksRequest.  # noqa: E501
        :type limit: int
        """
        self.swagger_types = {
            'network_identifier': NetworkIdentifier,
            'offset': int,
            'limit': int
        }

        self.attribute_map = {
            'network_identifier': 'network_identifier',
            'offset': 'offset',
            'limit': 'limit'
        }
        self._network_identifier = network_identifier
        self._offset = offset
        self._limit = limit

    @classmethod
    def from_dict(cls, dikt) -> 'EventsBlocksRequest':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The EventsBlocksRequest of this EventsBlocksRequest.  # noqa: E501
        :rtype: EventsBlocksRequest
        """
        return util.deserialize_model(dikt, cls)

    @property
    def network_identifier(self) -> NetworkIdentifier:
        """Gets the network_identifier of this EventsBlocksRequest.


        :return: The network_identifier of this EventsBlocksRequest.
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier: NetworkIdentifier):
        """Sets the network_identifier of this EventsBlocksRequest.


        :param network_identifier: The network_identifier of this EventsBlocksRequest.
        :type network_identifier: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def offset(self) -> int:
        """Gets the offset of this EventsBlocksRequest.

        offset is the offset into the event stream to sync events from. If this field is not populated, we return the limit events backwards from tip. If this is set to 0, we start from the beginning.  # noqa: E501

        :return: The offset of this EventsBlocksRequest.
        :rtype: int
        """
        return self._offset

    @offset.setter
    def offset(self, offset: int):
        """Sets the offset of this EventsBlocksRequest.

        offset is the offset into the event stream to sync events from. If this field is not populated, we return the limit events backwards from tip. If this is set to 0, we start from the beginning.  # noqa: E501

        :param offset: The offset of this EventsBlocksRequest.
        :type offset: int
        """

        self._offset = offset

    @property
    def limit(self) -> int:
        """Gets the limit of this EventsBlocksRequest.

        limit is the maximum number of events to fetch in one call. The implementation may return <= limit events.  # noqa: E501

        :return: The limit of this EventsBlocksRequest.
        :rtype: int
        """
        return self._limit

    @limit.setter
    def limit(self, limit: int):
        """Sets the limit of this EventsBlocksRequest.

        limit is the maximum number of events to fetch in one call. The implementation may return <= limit events.  # noqa: E501

        :param limit: The limit of this EventsBlocksRequest.
        :type limit: int
        """

        self._limit = limit