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

class ConstructionPayloadsResponse(object):
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
        'unsigned_transaction': 'str',
        'payloads': 'list[SigningPayload]'
    }

    attribute_map = {
        'unsigned_transaction': 'unsigned_transaction',
        'payloads': 'payloads'
    }

    def __init__(self, unsigned_transaction=None, payloads=None):  # noqa: E501
        """ConstructionPayloadsResponse - a model defined in Swagger"""  # noqa: E501
        self._unsigned_transaction = None
        self._payloads = None
        self.discriminator = None
        self.unsigned_transaction = unsigned_transaction
        self.payloads = payloads

    @property
    def unsigned_transaction(self):
        """Gets the unsigned_transaction of this ConstructionPayloadsResponse.  # noqa: E501


        :return: The unsigned_transaction of this ConstructionPayloadsResponse.  # noqa: E501
        :rtype: str
        """
        return self._unsigned_transaction

    @unsigned_transaction.setter
    def unsigned_transaction(self, unsigned_transaction):
        """Sets the unsigned_transaction of this ConstructionPayloadsResponse.


        :param unsigned_transaction: The unsigned_transaction of this ConstructionPayloadsResponse.  # noqa: E501
        :type: str
        """
        if unsigned_transaction is None:
            raise ValueError("Invalid value for `unsigned_transaction`, must not be `None`")  # noqa: E501

        self._unsigned_transaction = unsigned_transaction

    @property
    def payloads(self):
        """Gets the payloads of this ConstructionPayloadsResponse.  # noqa: E501


        :return: The payloads of this ConstructionPayloadsResponse.  # noqa: E501
        :rtype: list[SigningPayload]
        """
        return self._payloads

    @payloads.setter
    def payloads(self, payloads):
        """Sets the payloads of this ConstructionPayloadsResponse.


        :param payloads: The payloads of this ConstructionPayloadsResponse.  # noqa: E501
        :type: list[SigningPayload]
        """
        if payloads is None:
            raise ValueError("Invalid value for `payloads`, must not be `None`")  # noqa: E501

        self._payloads = payloads

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
        if issubclass(ConstructionPayloadsResponse, dict):
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
        if not isinstance(other, ConstructionPayloadsResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
