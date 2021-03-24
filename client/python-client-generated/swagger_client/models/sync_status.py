# coding: utf-8

"""
    Rosetta

    Build Once. Integrate Your Blockchain Everywhere.  # noqa: E501

    OpenAPI spec version: 1.4.10
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class SyncStatus(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'current_index': 'int',
        'target_index': 'int',
        'stage': 'str',
        'synced': 'bool'
    }

    attribute_map = {
        'current_index': 'current_index',
        'target_index': 'target_index',
        'stage': 'stage',
        'synced': 'synced'
    }

    def __init__(self, current_index=None, target_index=None, stage=None, synced=None):  # noqa: E501
        """SyncStatus - a model defined in Swagger"""  # noqa: E501
        self._current_index = None
        self._target_index = None
        self._stage = None
        self._synced = None
        self.discriminator = None
        if current_index is not None:
            self.current_index = current_index
        if target_index is not None:
            self.target_index = target_index
        if stage is not None:
            self.stage = stage
        if synced is not None:
            self.synced = synced

    @property
    def current_index(self):
        """Gets the current_index of this SyncStatus.  # noqa: E501

        CurrentIndex is the index of the last synced block in the current stage. This is a separate field from current_block_identifier in NetworkStatusResponse because blocks with indices up to and including the current_index may not yet be queryable by the caller. To reiterate, all indices up to and including current_block_identifier in NetworkStatusResponse must be queryable via the /block endpoint (excluding indices less than oldest_block_identifier).  # noqa: E501

        :return: The current_index of this SyncStatus.  # noqa: E501
        :rtype: int
        """
        return self._current_index

    @current_index.setter
    def current_index(self, current_index):
        """Sets the current_index of this SyncStatus.

        CurrentIndex is the index of the last synced block in the current stage. This is a separate field from current_block_identifier in NetworkStatusResponse because blocks with indices up to and including the current_index may not yet be queryable by the caller. To reiterate, all indices up to and including current_block_identifier in NetworkStatusResponse must be queryable via the /block endpoint (excluding indices less than oldest_block_identifier).  # noqa: E501

        :param current_index: The current_index of this SyncStatus.  # noqa: E501
        :type: int
        """

        self._current_index = current_index

    @property
    def target_index(self):
        """Gets the target_index of this SyncStatus.  # noqa: E501

        TargetIndex is the index of the block that the implementation is attempting to sync to in the current stage.  # noqa: E501

        :return: The target_index of this SyncStatus.  # noqa: E501
        :rtype: int
        """
        return self._target_index

    @target_index.setter
    def target_index(self, target_index):
        """Sets the target_index of this SyncStatus.

        TargetIndex is the index of the block that the implementation is attempting to sync to in the current stage.  # noqa: E501

        :param target_index: The target_index of this SyncStatus.  # noqa: E501
        :type: int
        """

        self._target_index = target_index

    @property
    def stage(self):
        """Gets the stage of this SyncStatus.  # noqa: E501

        Stage is the phase of the sync process.  # noqa: E501

        :return: The stage of this SyncStatus.  # noqa: E501
        :rtype: str
        """
        return self._stage

    @stage.setter
    def stage(self, stage):
        """Sets the stage of this SyncStatus.

        Stage is the phase of the sync process.  # noqa: E501

        :param stage: The stage of this SyncStatus.  # noqa: E501
        :type: str
        """

        self._stage = stage

    @property
    def synced(self):
        """Gets the synced of this SyncStatus.  # noqa: E501

        sycned is a boolean that indicates if an implementation has synced up to the most recent block. If this field is not populated, the caller should rely on a traditional tip timestamp comparison to determine if an implementation is synced. This field is particularly useful for quiescent blockchains (blocks only produced when there are pending transactions). In these blockchains, the most recent block could have a timestamp far behind the current time but the node could be healthy and at tip.  # noqa: E501

        :return: The synced of this SyncStatus.  # noqa: E501
        :rtype: bool
        """
        return self._synced

    @synced.setter
    def synced(self, synced):
        """Sets the synced of this SyncStatus.

        sycned is a boolean that indicates if an implementation has synced up to the most recent block. If this field is not populated, the caller should rely on a traditional tip timestamp comparison to determine if an implementation is synced. This field is particularly useful for quiescent blockchains (blocks only produced when there are pending transactions). In these blockchains, the most recent block could have a timestamp far behind the current time but the node could be healthy and at tip.  # noqa: E501

        :param synced: The synced of this SyncStatus.  # noqa: E501
        :type: bool
        """

        self._synced = synced

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(SyncStatus, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, SyncStatus):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other