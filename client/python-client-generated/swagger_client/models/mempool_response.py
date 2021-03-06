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

class MempoolResponse(object):
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
        'transaction_identifiers': 'list[TransactionIdentifier]'
    }

    attribute_map = {
        'transaction_identifiers': 'transaction_identifiers'
    }

    def __init__(self, transaction_identifiers=None):  # noqa: E501
        """MempoolResponse - a model defined in Swagger"""  # noqa: E501
        self._transaction_identifiers = None
        self.discriminator = None
        self.transaction_identifiers = transaction_identifiers

    @property
    def transaction_identifiers(self):
        """Gets the transaction_identifiers of this MempoolResponse.  # noqa: E501


        :return: The transaction_identifiers of this MempoolResponse.  # noqa: E501
        :rtype: list[TransactionIdentifier]
        """
        return self._transaction_identifiers

    @transaction_identifiers.setter
    def transaction_identifiers(self, transaction_identifiers):
        """Sets the transaction_identifiers of this MempoolResponse.


        :param transaction_identifiers: The transaction_identifiers of this MempoolResponse.  # noqa: E501
        :type: list[TransactionIdentifier]
        """
        if transaction_identifiers is None:
            raise ValueError("Invalid value for `transaction_identifiers`, must not be `None`")  # noqa: E501

        self._transaction_identifiers = transaction_identifiers

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
        if issubclass(MempoolResponse, dict):
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
        if not isinstance(other, MempoolResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
