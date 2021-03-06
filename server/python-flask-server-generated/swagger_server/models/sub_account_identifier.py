# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class SubAccountIdentifier(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, address: str=None, metadata: object=None):  # noqa: E501
        """SubAccountIdentifier - a model defined in Swagger

        :param address: The address of this SubAccountIdentifier.  # noqa: E501
        :type address: str
        :param metadata: The metadata of this SubAccountIdentifier.  # noqa: E501
        :type metadata: object
        """
        self.swagger_types = {
            'address': str,
            'metadata': object
        }

        self.attribute_map = {
            'address': 'address',
            'metadata': 'metadata'
        }
        self._address = address
        self._metadata = metadata

    @classmethod
    def from_dict(cls, dikt) -> 'SubAccountIdentifier':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The SubAccountIdentifier of this SubAccountIdentifier.  # noqa: E501
        :rtype: SubAccountIdentifier
        """
        return util.deserialize_model(dikt, cls)

    @property
    def address(self) -> str:
        """Gets the address of this SubAccountIdentifier.

        The SubAccount address may be a cryptographic value or some other identifier (ex: bonded) that uniquely specifies a SubAccount.  # noqa: E501

        :return: The address of this SubAccountIdentifier.
        :rtype: str
        """
        return self._address

    @address.setter
    def address(self, address: str):
        """Sets the address of this SubAccountIdentifier.

        The SubAccount address may be a cryptographic value or some other identifier (ex: bonded) that uniquely specifies a SubAccount.  # noqa: E501

        :param address: The address of this SubAccountIdentifier.
        :type address: str
        """
        if address is None:
            raise ValueError("Invalid value for `address`, must not be `None`")  # noqa: E501

        self._address = address

    @property
    def metadata(self) -> object:
        """Gets the metadata of this SubAccountIdentifier.

        If the SubAccount address is not sufficient to uniquely specify a SubAccount, any other identifying information can be stored here. It is important to note that two SubAccounts with identical addresses but differing metadata will not be considered equal by clients.  # noqa: E501

        :return: The metadata of this SubAccountIdentifier.
        :rtype: object
        """
        return self._metadata

    @metadata.setter
    def metadata(self, metadata: object):
        """Sets the metadata of this SubAccountIdentifier.

        If the SubAccount address is not sufficient to uniquely specify a SubAccount, any other identifying information can be stored here. It is important to note that two SubAccounts with identical addresses but differing metadata will not be considered equal by clients.  # noqa: E501

        :param metadata: The metadata of this SubAccountIdentifier.
        :type metadata: object
        """

        self._metadata = metadata
