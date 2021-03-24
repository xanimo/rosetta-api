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

class AccountBalanceRequest(object):
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
        'account_identifier': 'AccountIdentifier',
        'block_identifier': 'PartialBlockIdentifier',
        'currencies': 'list[Currency]'
    }

    attribute_map = {
        'network_identifier': 'network_identifier',
        'account_identifier': 'account_identifier',
        'block_identifier': 'block_identifier',
        'currencies': 'currencies'
    }

    def __init__(self, network_identifier=None, account_identifier=None, block_identifier=None, currencies=None):  # noqa: E501
        """AccountBalanceRequest - a model defined in Swagger"""  # noqa: E501
        self._network_identifier = None
        self._account_identifier = None
        self._block_identifier = None
        self._currencies = None
        self.discriminator = None
        self.network_identifier = network_identifier
        self.account_identifier = account_identifier
        if block_identifier is not None:
            self.block_identifier = block_identifier
        if currencies is not None:
            self.currencies = currencies

    @property
    def network_identifier(self):
        """Gets the network_identifier of this AccountBalanceRequest.  # noqa: E501


        :return: The network_identifier of this AccountBalanceRequest.  # noqa: E501
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier):
        """Sets the network_identifier of this AccountBalanceRequest.


        :param network_identifier: The network_identifier of this AccountBalanceRequest.  # noqa: E501
        :type: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def account_identifier(self):
        """Gets the account_identifier of this AccountBalanceRequest.  # noqa: E501


        :return: The account_identifier of this AccountBalanceRequest.  # noqa: E501
        :rtype: AccountIdentifier
        """
        return self._account_identifier

    @account_identifier.setter
    def account_identifier(self, account_identifier):
        """Sets the account_identifier of this AccountBalanceRequest.


        :param account_identifier: The account_identifier of this AccountBalanceRequest.  # noqa: E501
        :type: AccountIdentifier
        """
        if account_identifier is None:
            raise ValueError("Invalid value for `account_identifier`, must not be `None`")  # noqa: E501

        self._account_identifier = account_identifier

    @property
    def block_identifier(self):
        """Gets the block_identifier of this AccountBalanceRequest.  # noqa: E501


        :return: The block_identifier of this AccountBalanceRequest.  # noqa: E501
        :rtype: PartialBlockIdentifier
        """
        return self._block_identifier

    @block_identifier.setter
    def block_identifier(self, block_identifier):
        """Sets the block_identifier of this AccountBalanceRequest.


        :param block_identifier: The block_identifier of this AccountBalanceRequest.  # noqa: E501
        :type: PartialBlockIdentifier
        """

        self._block_identifier = block_identifier

    @property
    def currencies(self):
        """Gets the currencies of this AccountBalanceRequest.  # noqa: E501

        In some cases, the caller may not want to retrieve all available balances for an AccountIdentifier. If the currencies field is populated, only balances for the specified currencies will be returned. If not populated, all available balances will be returned.  # noqa: E501

        :return: The currencies of this AccountBalanceRequest.  # noqa: E501
        :rtype: list[Currency]
        """
        return self._currencies

    @currencies.setter
    def currencies(self, currencies):
        """Sets the currencies of this AccountBalanceRequest.

        In some cases, the caller may not want to retrieve all available balances for an AccountIdentifier. If the currencies field is populated, only balances for the specified currencies will be returned. If not populated, all available balances will be returned.  # noqa: E501

        :param currencies: The currencies of this AccountBalanceRequest.  # noqa: E501
        :type: list[Currency]
        """

        self._currencies = currencies

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
        if issubclass(AccountBalanceRequest, dict):
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
        if not isinstance(other, AccountBalanceRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
