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

class MempoolTransactionRequest(object):
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
        'network_identifier': 'NetworkIdentifier',
        'transaction_identifier': 'TransactionIdentifier'
    }

    attribute_map = {
        'network_identifier': 'network_identifier',
        'transaction_identifier': 'transaction_identifier'
    }

    def __init__(self, network_identifier=None, transaction_identifier=None):  # noqa: E501
        """MempoolTransactionRequest - a model defined in Swagger"""  # noqa: E501
        self._network_identifier = None
        self._transaction_identifier = None
        self.discriminator = None
        self.network_identifier = network_identifier
        self.transaction_identifier = transaction_identifier

    @property
    def network_identifier(self):
        """Gets the network_identifier of this MempoolTransactionRequest.  # noqa: E501


        :return: The network_identifier of this MempoolTransactionRequest.  # noqa: E501
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier):
        """Sets the network_identifier of this MempoolTransactionRequest.


        :param network_identifier: The network_identifier of this MempoolTransactionRequest.  # noqa: E501
        :type: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def transaction_identifier(self):
        """Gets the transaction_identifier of this MempoolTransactionRequest.  # noqa: E501


        :return: The transaction_identifier of this MempoolTransactionRequest.  # noqa: E501
        :rtype: TransactionIdentifier
        """
        return self._transaction_identifier

    @transaction_identifier.setter
    def transaction_identifier(self, transaction_identifier):
        """Sets the transaction_identifier of this MempoolTransactionRequest.


        :param transaction_identifier: The transaction_identifier of this MempoolTransactionRequest.  # noqa: E501
        :type: TransactionIdentifier
        """
        if transaction_identifier is None:
            raise ValueError("Invalid value for `transaction_identifier`, must not be `None`")  # noqa: E501

        self._transaction_identifier = transaction_identifier

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
        if issubclass(MempoolTransactionRequest, dict):
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
        if not isinstance(other, MempoolTransactionRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other