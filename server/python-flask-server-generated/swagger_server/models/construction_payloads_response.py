# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server.models.signing_payload import SigningPayload  # noqa: F401,E501
from swagger_server import util


class ConstructionPayloadsResponse(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, unsigned_transaction: str=None, payloads: List[SigningPayload]=None):  # noqa: E501
        """ConstructionPayloadsResponse - a model defined in Swagger

        :param unsigned_transaction: The unsigned_transaction of this ConstructionPayloadsResponse.  # noqa: E501
        :type unsigned_transaction: str
        :param payloads: The payloads of this ConstructionPayloadsResponse.  # noqa: E501
        :type payloads: List[SigningPayload]
        """
        self.swagger_types = {
            'unsigned_transaction': str,
            'payloads': List[SigningPayload]
        }

        self.attribute_map = {
            'unsigned_transaction': 'unsigned_transaction',
            'payloads': 'payloads'
        }
        self._unsigned_transaction = unsigned_transaction
        self._payloads = payloads

    @classmethod
    def from_dict(cls, dikt) -> 'ConstructionPayloadsResponse':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ConstructionPayloadsResponse of this ConstructionPayloadsResponse.  # noqa: E501
        :rtype: ConstructionPayloadsResponse
        """
        return util.deserialize_model(dikt, cls)

    @property
    def unsigned_transaction(self) -> str:
        """Gets the unsigned_transaction of this ConstructionPayloadsResponse.


        :return: The unsigned_transaction of this ConstructionPayloadsResponse.
        :rtype: str
        """
        return self._unsigned_transaction

    @unsigned_transaction.setter
    def unsigned_transaction(self, unsigned_transaction: str):
        """Sets the unsigned_transaction of this ConstructionPayloadsResponse.


        :param unsigned_transaction: The unsigned_transaction of this ConstructionPayloadsResponse.
        :type unsigned_transaction: str
        """
        if unsigned_transaction is None:
            raise ValueError("Invalid value for `unsigned_transaction`, must not be `None`")  # noqa: E501

        self._unsigned_transaction = unsigned_transaction

    @property
    def payloads(self) -> List[SigningPayload]:
        """Gets the payloads of this ConstructionPayloadsResponse.


        :return: The payloads of this ConstructionPayloadsResponse.
        :rtype: List[SigningPayload]
        """
        return self._payloads

    @payloads.setter
    def payloads(self, payloads: List[SigningPayload]):
        """Sets the payloads of this ConstructionPayloadsResponse.


        :param payloads: The payloads of this ConstructionPayloadsResponse.
        :type payloads: List[SigningPayload]
        """
        if payloads is None:
            raise ValueError("Invalid value for `payloads`, must not be `None`")  # noqa: E501

        self._payloads = payloads
