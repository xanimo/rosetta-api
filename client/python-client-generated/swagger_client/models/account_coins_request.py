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

class AccountCoinsRequest(object):
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
        'include_mempool': 'bool',
        'currencies': 'list[Currency]'
    }

    attribute_map = {
        'network_identifier': 'network_identifier',
        'account_identifier': 'account_identifier',
        'include_mempool': 'include_mempool',
        'currencies': 'currencies'
    }

    def __init__(self, network_identifier=None, account_identifier=None, include_mempool=None, currencies=None):  # noqa: E501
        """AccountCoinsRequest - a model defined in Swagger"""  # noqa: E501
        self._network_identifier = None
        self._account_identifier = None
        self._include_mempool = None
        self._currencies = None
        self.discriminator = None
        self.network_identifier = network_identifier
        self.account_identifier = account_identifier
        self.include_mempool = include_mempool
        if currencies is not None:
            self.currencies = currencies

    @property
    def network_identifier(self):
        """Gets the network_identifier of this AccountCoinsRequest.  # noqa: E501


        :return: The network_identifier of this AccountCoinsRequest.  # noqa: E501
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier):
        """Sets the network_identifier of this AccountCoinsRequest.


        :param network_identifier: The network_identifier of this AccountCoinsRequest.  # noqa: E501
        :type: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def account_identifier(self):
        """Gets the account_identifier of this AccountCoinsRequest.  # noqa: E501


        :return: The account_identifier of this AccountCoinsRequest.  # noqa: E501
        :rtype: AccountIdentifier
        """
        return self._account_identifier

    @account_identifier.setter
    def account_identifier(self, account_identifier):
        """Sets the account_identifier of this AccountCoinsRequest.


        :param account_identifier: The account_identifier of this AccountCoinsRequest.  # noqa: E501
        :type: AccountIdentifier
        """
        if account_identifier is None:
            raise ValueError("Invalid value for `account_identifier`, must not be `None`")  # noqa: E501

        self._account_identifier = account_identifier

    @property
    def include_mempool(self):
        """Gets the include_mempool of this AccountCoinsRequest.  # noqa: E501

        Include state from the mempool when looking up an account's unspent coins. Note, using this functionality breaks any guarantee of idempotency.  # noqa: E501

        :return: The include_mempool of this AccountCoinsRequest.  # noqa: E501
        :rtype: bool
        """
        return self._include_mempool

    @include_mempool.setter
    def include_mempool(self, include_mempool):
        """Sets the include_mempool of this AccountCoinsRequest.

        Include state from the mempool when looking up an account's unspent coins. Note, using this functionality breaks any guarantee of idempotency.  # noqa: E501

        :param include_mempool: The include_mempool of this AccountCoinsRequest.  # noqa: E501
        :type: bool
        """
        if include_mempool is None:
            raise ValueError("Invalid value for `include_mempool`, must not be `None`")  # noqa: E501

        self._include_mempool = include_mempool

    @property
    def currencies(self):
        """Gets the currencies of this AccountCoinsRequest.  # noqa: E501

        In some cases, the caller may not want to retrieve coins for all currencies for an AccountIdentifier. If the currencies field is populated, only coins for the specified currencies will be returned. If not populated, all unspent coins will be returned.  # noqa: E501

        :return: The currencies of this AccountCoinsRequest.  # noqa: E501
        :rtype: list[Currency]
        """
        return self._currencies

    @currencies.setter
    def currencies(self, currencies):
        """Sets the currencies of this AccountCoinsRequest.

        In some cases, the caller may not want to retrieve coins for all currencies for an AccountIdentifier. If the currencies field is populated, only coins for the specified currencies will be returned. If not populated, all unspent coins will be returned.  # noqa: E501

        :param currencies: The currencies of this AccountCoinsRequest.  # noqa: E501
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
        if issubclass(AccountCoinsRequest, dict):
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
        if not isinstance(other, AccountCoinsRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other