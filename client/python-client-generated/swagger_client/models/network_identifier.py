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

class NetworkIdentifier(object):
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
        'blockchain': 'str',
        'network': 'str',
        'sub_network_identifier': 'SubNetworkIdentifier'
    }

    attribute_map = {
        'blockchain': 'blockchain',
        'network': 'network',
        'sub_network_identifier': 'sub_network_identifier'
    }

    def __init__(self, blockchain=None, network=None, sub_network_identifier=None):  # noqa: E501
        """NetworkIdentifier - a model defined in Swagger"""  # noqa: E501
        self._blockchain = None
        self._network = None
        self._sub_network_identifier = None
        self.discriminator = None
        self.blockchain = blockchain
        self.network = network
        if sub_network_identifier is not None:
            self.sub_network_identifier = sub_network_identifier

    @property
    def blockchain(self):
        """Gets the blockchain of this NetworkIdentifier.  # noqa: E501


        :return: The blockchain of this NetworkIdentifier.  # noqa: E501
        :rtype: str
        """
        return self._blockchain

    @blockchain.setter
    def blockchain(self, blockchain):
        """Sets the blockchain of this NetworkIdentifier.


        :param blockchain: The blockchain of this NetworkIdentifier.  # noqa: E501
        :type: str
        """
        if blockchain is None:
            raise ValueError("Invalid value for `blockchain`, must not be `None`")  # noqa: E501

        self._blockchain = blockchain

    @property
    def network(self):
        """Gets the network of this NetworkIdentifier.  # noqa: E501

        If a blockchain has a specific chain-id or network identifier, it should go in this field. It is up to the client to determine which network-specific identifier is mainnet or testnet.  # noqa: E501

        :return: The network of this NetworkIdentifier.  # noqa: E501
        :rtype: str
        """
        return self._network

    @network.setter
    def network(self, network):
        """Sets the network of this NetworkIdentifier.

        If a blockchain has a specific chain-id or network identifier, it should go in this field. It is up to the client to determine which network-specific identifier is mainnet or testnet.  # noqa: E501

        :param network: The network of this NetworkIdentifier.  # noqa: E501
        :type: str
        """
        if network is None:
            raise ValueError("Invalid value for `network`, must not be `None`")  # noqa: E501

        self._network = network

    @property
    def sub_network_identifier(self):
        """Gets the sub_network_identifier of this NetworkIdentifier.  # noqa: E501


        :return: The sub_network_identifier of this NetworkIdentifier.  # noqa: E501
        :rtype: SubNetworkIdentifier
        """
        return self._sub_network_identifier

    @sub_network_identifier.setter
    def sub_network_identifier(self, sub_network_identifier):
        """Sets the sub_network_identifier of this NetworkIdentifier.


        :param sub_network_identifier: The sub_network_identifier of this NetworkIdentifier.  # noqa: E501
        :type: SubNetworkIdentifier
        """

        self._sub_network_identifier = sub_network_identifier

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
        if issubclass(NetworkIdentifier, dict):
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
        if not isinstance(other, NetworkIdentifier):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
