# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.block_identifier import BlockIdentifier  # noqa: F401,E501
from swagger_server.models.peer import Peer  # noqa: F401,E501
from swagger_server.models.sync_status import SyncStatus  # noqa: F401,E501
java.sql.Timestamp  # noqa: F401,E501
from swagger_server import util


class NetworkStatusResponse(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, current_block_identifier: BlockIdentifier=None, current_block_timestamp: Timestamp=None, genesis_block_identifier: BlockIdentifier=None, oldest_block_identifier: BlockIdentifier=None, sync_status: SyncStatus=None, peers: List[Peer]=None):  # noqa: E501
        """NetworkStatusResponse - a model defined in Swagger

        :param current_block_identifier: The current_block_identifier of this NetworkStatusResponse.  # noqa: E501
        :type current_block_identifier: BlockIdentifier
        :param current_block_timestamp: The current_block_timestamp of this NetworkStatusResponse.  # noqa: E501
        :type current_block_timestamp: Timestamp
        :param genesis_block_identifier: The genesis_block_identifier of this NetworkStatusResponse.  # noqa: E501
        :type genesis_block_identifier: BlockIdentifier
        :param oldest_block_identifier: The oldest_block_identifier of this NetworkStatusResponse.  # noqa: E501
        :type oldest_block_identifier: BlockIdentifier
        :param sync_status: The sync_status of this NetworkStatusResponse.  # noqa: E501
        :type sync_status: SyncStatus
        :param peers: The peers of this NetworkStatusResponse.  # noqa: E501
        :type peers: List[Peer]
        """
        self.swagger_types = {
            'current_block_identifier': BlockIdentifier,
            'current_block_timestamp': Timestamp,
            'genesis_block_identifier': BlockIdentifier,
            'oldest_block_identifier': BlockIdentifier,
            'sync_status': SyncStatus,
            'peers': List[Peer]
        }

        self.attribute_map = {
            'current_block_identifier': 'current_block_identifier',
            'current_block_timestamp': 'current_block_timestamp',
            'genesis_block_identifier': 'genesis_block_identifier',
            'oldest_block_identifier': 'oldest_block_identifier',
            'sync_status': 'sync_status',
            'peers': 'peers'
        }
        self._current_block_identifier = current_block_identifier
        self._current_block_timestamp = current_block_timestamp
        self._genesis_block_identifier = genesis_block_identifier
        self._oldest_block_identifier = oldest_block_identifier
        self._sync_status = sync_status
        self._peers = peers

    @classmethod
    def from_dict(cls, dikt) -> 'NetworkStatusResponse':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The NetworkStatusResponse of this NetworkStatusResponse.  # noqa: E501
        :rtype: NetworkStatusResponse
        """
        return util.deserialize_model(dikt, cls)

    @property
    def current_block_identifier(self) -> BlockIdentifier:
        """Gets the current_block_identifier of this NetworkStatusResponse.


        :return: The current_block_identifier of this NetworkStatusResponse.
        :rtype: BlockIdentifier
        """
        return self._current_block_identifier

    @current_block_identifier.setter
    def current_block_identifier(self, current_block_identifier: BlockIdentifier):
        """Sets the current_block_identifier of this NetworkStatusResponse.


        :param current_block_identifier: The current_block_identifier of this NetworkStatusResponse.
        :type current_block_identifier: BlockIdentifier
        """
        if current_block_identifier is None:
            raise ValueError("Invalid value for `current_block_identifier`, must not be `None`")  # noqa: E501

        self._current_block_identifier = current_block_identifier

    @property
    def current_block_timestamp(self) -> Timestamp:
        """Gets the current_block_timestamp of this NetworkStatusResponse.


        :return: The current_block_timestamp of this NetworkStatusResponse.
        :rtype: Timestamp
        """
        return self._current_block_timestamp

    @current_block_timestamp.setter
    def current_block_timestamp(self, current_block_timestamp: Timestamp):
        """Sets the current_block_timestamp of this NetworkStatusResponse.


        :param current_block_timestamp: The current_block_timestamp of this NetworkStatusResponse.
        :type current_block_timestamp: Timestamp
        """
        if current_block_timestamp is None:
            raise ValueError("Invalid value for `current_block_timestamp`, must not be `None`")  # noqa: E501

        self._current_block_timestamp = current_block_timestamp

    @property
    def genesis_block_identifier(self) -> BlockIdentifier:
        """Gets the genesis_block_identifier of this NetworkStatusResponse.


        :return: The genesis_block_identifier of this NetworkStatusResponse.
        :rtype: BlockIdentifier
        """
        return self._genesis_block_identifier

    @genesis_block_identifier.setter
    def genesis_block_identifier(self, genesis_block_identifier: BlockIdentifier):
        """Sets the genesis_block_identifier of this NetworkStatusResponse.


        :param genesis_block_identifier: The genesis_block_identifier of this NetworkStatusResponse.
        :type genesis_block_identifier: BlockIdentifier
        """
        if genesis_block_identifier is None:
            raise ValueError("Invalid value for `genesis_block_identifier`, must not be `None`")  # noqa: E501

        self._genesis_block_identifier = genesis_block_identifier

    @property
    def oldest_block_identifier(self) -> BlockIdentifier:
        """Gets the oldest_block_identifier of this NetworkStatusResponse.


        :return: The oldest_block_identifier of this NetworkStatusResponse.
        :rtype: BlockIdentifier
        """
        return self._oldest_block_identifier

    @oldest_block_identifier.setter
    def oldest_block_identifier(self, oldest_block_identifier: BlockIdentifier):
        """Sets the oldest_block_identifier of this NetworkStatusResponse.


        :param oldest_block_identifier: The oldest_block_identifier of this NetworkStatusResponse.
        :type oldest_block_identifier: BlockIdentifier
        """

        self._oldest_block_identifier = oldest_block_identifier

    @property
    def sync_status(self) -> SyncStatus:
        """Gets the sync_status of this NetworkStatusResponse.


        :return: The sync_status of this NetworkStatusResponse.
        :rtype: SyncStatus
        """
        return self._sync_status

    @sync_status.setter
    def sync_status(self, sync_status: SyncStatus):
        """Sets the sync_status of this NetworkStatusResponse.


        :param sync_status: The sync_status of this NetworkStatusResponse.
        :type sync_status: SyncStatus
        """

        self._sync_status = sync_status

    @property
    def peers(self) -> List[Peer]:
        """Gets the peers of this NetworkStatusResponse.


        :return: The peers of this NetworkStatusResponse.
        :rtype: List[Peer]
        """
        return self._peers

    @peers.setter
    def peers(self, peers: List[Peer]):
        """Sets the peers of this NetworkStatusResponse.


        :param peers: The peers of this NetworkStatusResponse.
        :type peers: List[Peer]
        """
        if peers is None:
            raise ValueError("Invalid value for `peers`, must not be `None`")  # noqa: E501

        self._peers = peers
