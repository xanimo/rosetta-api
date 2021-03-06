# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class SyncStatus(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, current_index: int=None, target_index: int=None, stage: str=None, synced: bool=None):  # noqa: E501
        """SyncStatus - a model defined in Swagger

        :param current_index: The current_index of this SyncStatus.  # noqa: E501
        :type current_index: int
        :param target_index: The target_index of this SyncStatus.  # noqa: E501
        :type target_index: int
        :param stage: The stage of this SyncStatus.  # noqa: E501
        :type stage: str
        :param synced: The synced of this SyncStatus.  # noqa: E501
        :type synced: bool
        """
        self.swagger_types = {
            'current_index': int,
            'target_index': int,
            'stage': str,
            'synced': bool
        }

        self.attribute_map = {
            'current_index': 'current_index',
            'target_index': 'target_index',
            'stage': 'stage',
            'synced': 'synced'
        }
        self._current_index = current_index
        self._target_index = target_index
        self._stage = stage
        self._synced = synced

    @classmethod
    def from_dict(cls, dikt) -> 'SyncStatus':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The SyncStatus of this SyncStatus.  # noqa: E501
        :rtype: SyncStatus
        """
        return util.deserialize_model(dikt, cls)

    @property
    def current_index(self) -> int:
        """Gets the current_index of this SyncStatus.

        CurrentIndex is the index of the last synced block in the current stage. This is a separate field from current_block_identifier in NetworkStatusResponse because blocks with indices up to and including the current_index may not yet be queryable by the caller. To reiterate, all indices up to and including current_block_identifier in NetworkStatusResponse must be queryable via the /block endpoint (excluding indices less than oldest_block_identifier).  # noqa: E501

        :return: The current_index of this SyncStatus.
        :rtype: int
        """
        return self._current_index

    @current_index.setter
    def current_index(self, current_index: int):
        """Sets the current_index of this SyncStatus.

        CurrentIndex is the index of the last synced block in the current stage. This is a separate field from current_block_identifier in NetworkStatusResponse because blocks with indices up to and including the current_index may not yet be queryable by the caller. To reiterate, all indices up to and including current_block_identifier in NetworkStatusResponse must be queryable via the /block endpoint (excluding indices less than oldest_block_identifier).  # noqa: E501

        :param current_index: The current_index of this SyncStatus.
        :type current_index: int
        """

        self._current_index = current_index

    @property
    def target_index(self) -> int:
        """Gets the target_index of this SyncStatus.

        TargetIndex is the index of the block that the implementation is attempting to sync to in the current stage.  # noqa: E501

        :return: The target_index of this SyncStatus.
        :rtype: int
        """
        return self._target_index

    @target_index.setter
    def target_index(self, target_index: int):
        """Sets the target_index of this SyncStatus.

        TargetIndex is the index of the block that the implementation is attempting to sync to in the current stage.  # noqa: E501

        :param target_index: The target_index of this SyncStatus.
        :type target_index: int
        """

        self._target_index = target_index

    @property
    def stage(self) -> str:
        """Gets the stage of this SyncStatus.

        Stage is the phase of the sync process.  # noqa: E501

        :return: The stage of this SyncStatus.
        :rtype: str
        """
        return self._stage

    @stage.setter
    def stage(self, stage: str):
        """Sets the stage of this SyncStatus.

        Stage is the phase of the sync process.  # noqa: E501

        :param stage: The stage of this SyncStatus.
        :type stage: str
        """

        self._stage = stage

    @property
    def synced(self) -> bool:
        """Gets the synced of this SyncStatus.

        sycned is a boolean that indicates if an implementation has synced up to the most recent block. If this field is not populated, the caller should rely on a traditional tip timestamp comparison to determine if an implementation is synced. This field is particularly useful for quiescent blockchains (blocks only produced when there are pending transactions). In these blockchains, the most recent block could have a timestamp far behind the current time but the node could be healthy and at tip.  # noqa: E501

        :return: The synced of this SyncStatus.
        :rtype: bool
        """
        return self._synced

    @synced.setter
    def synced(self, synced: bool):
        """Sets the synced of this SyncStatus.

        sycned is a boolean that indicates if an implementation has synced up to the most recent block. If this field is not populated, the caller should rely on a traditional tip timestamp comparison to determine if an implementation is synced. This field is particularly useful for quiescent blockchains (blocks only produced when there are pending transactions). In these blockchains, the most recent block could have a timestamp far behind the current time but the node could be healthy and at tip.  # noqa: E501

        :param synced: The synced of this SyncStatus.
        :type synced: bool
        """

        self._synced = synced
