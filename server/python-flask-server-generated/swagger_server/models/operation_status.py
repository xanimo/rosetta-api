# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class OperationStatus(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, status: str=None, successful: bool=None):  # noqa: E501
        """OperationStatus - a model defined in Swagger

        :param status: The status of this OperationStatus.  # noqa: E501
        :type status: str
        :param successful: The successful of this OperationStatus.  # noqa: E501
        :type successful: bool
        """
        self.swagger_types = {
            'status': str,
            'successful': bool
        }

        self.attribute_map = {
            'status': 'status',
            'successful': 'successful'
        }
        self._status = status
        self._successful = successful

    @classmethod
    def from_dict(cls, dikt) -> 'OperationStatus':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The OperationStatus of this OperationStatus.  # noqa: E501
        :rtype: OperationStatus
        """
        return util.deserialize_model(dikt, cls)

    @property
    def status(self) -> str:
        """Gets the status of this OperationStatus.

        The status is the network-specific status of the operation.  # noqa: E501

        :return: The status of this OperationStatus.
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status: str):
        """Sets the status of this OperationStatus.

        The status is the network-specific status of the operation.  # noqa: E501

        :param status: The status of this OperationStatus.
        :type status: str
        """
        if status is None:
            raise ValueError("Invalid value for `status`, must not be `None`")  # noqa: E501

        self._status = status

    @property
    def successful(self) -> bool:
        """Gets the successful of this OperationStatus.

        An Operation is considered successful if the Operation.Amount should affect the Operation.Account. Some blockchains (like Bitcoin) only include successful operations in blocks but other blockchains (like Ethereum) include unsuccessful operations that incur a fee. To reconcile the computed balance from the stream of Operations, it is critical to understand which Operation.Status indicate an Operation is successful and should affect an Account.  # noqa: E501

        :return: The successful of this OperationStatus.
        :rtype: bool
        """
        return self._successful

    @successful.setter
    def successful(self, successful: bool):
        """Sets the successful of this OperationStatus.

        An Operation is considered successful if the Operation.Amount should affect the Operation.Account. Some blockchains (like Bitcoin) only include successful operations in blocks but other blockchains (like Ethereum) include unsuccessful operations that incur a fee. To reconcile the computed balance from the stream of Operations, it is critical to understand which Operation.Status indicate an Operation is successful and should affect an Account.  # noqa: E501

        :param successful: The successful of this OperationStatus.
        :type successful: bool
        """
        if successful is None:
            raise ValueError("Invalid value for `successful`, must not be `None`")  # noqa: E501

        self._successful = successful
