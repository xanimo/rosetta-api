# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class TransactionIdentifier(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, hash: str=None):  # noqa: E501
        """TransactionIdentifier - a model defined in Swagger

        :param hash: The hash of this TransactionIdentifier.  # noqa: E501
        :type hash: str
        """
        self.swagger_types = {
            'hash': str
        }

        self.attribute_map = {
            'hash': 'hash'
        }
        self._hash = hash

    @classmethod
    def from_dict(cls, dikt) -> 'TransactionIdentifier':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The TransactionIdentifier of this TransactionIdentifier.  # noqa: E501
        :rtype: TransactionIdentifier
        """
        return util.deserialize_model(dikt, cls)

    @property
    def hash(self) -> str:
        """Gets the hash of this TransactionIdentifier.

        Any transactions that are attributable only to a block (ex: a block event) should use the hash of the block as the identifier.  # noqa: E501

        :return: The hash of this TransactionIdentifier.
        :rtype: str
        """
        return self._hash

    @hash.setter
    def hash(self, hash: str):
        """Sets the hash of this TransactionIdentifier.

        Any transactions that are attributable only to a block (ex: a block event) should use the hash of the block as the identifier.  # noqa: E501

        :param hash: The hash of this TransactionIdentifier.
        :type hash: str
        """
        if hash is None:
            raise ValueError("Invalid value for `hash`, must not be `None`")  # noqa: E501

        self._hash = hash