# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class ConstructionCombineResponse(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, signed_transaction: str=None):  # noqa: E501
        """ConstructionCombineResponse - a model defined in Swagger

        :param signed_transaction: The signed_transaction of this ConstructionCombineResponse.  # noqa: E501
        :type signed_transaction: str
        """
        self.swagger_types = {
            'signed_transaction': str
        }

        self.attribute_map = {
            'signed_transaction': 'signed_transaction'
        }
        self._signed_transaction = signed_transaction

    @classmethod
    def from_dict(cls, dikt) -> 'ConstructionCombineResponse':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ConstructionCombineResponse of this ConstructionCombineResponse.  # noqa: E501
        :rtype: ConstructionCombineResponse
        """
        return util.deserialize_model(dikt, cls)

    @property
    def signed_transaction(self) -> str:
        """Gets the signed_transaction of this ConstructionCombineResponse.


        :return: The signed_transaction of this ConstructionCombineResponse.
        :rtype: str
        """
        return self._signed_transaction

    @signed_transaction.setter
    def signed_transaction(self, signed_transaction: str):
        """Sets the signed_transaction of this ConstructionCombineResponse.


        :param signed_transaction: The signed_transaction of this ConstructionCombineResponse.
        :type signed_transaction: str
        """
        if signed_transaction is None:
            raise ValueError("Invalid value for `signed_transaction`, must not be `None`")  # noqa: E501

        self._signed_transaction = signed_transaction
