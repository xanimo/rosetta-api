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

class ConstructionMetadataRequest(object):
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
        'options': 'object',
        'public_keys': 'list[PublicKey]'
    }

    attribute_map = {
        'network_identifier': 'network_identifier',
        'options': 'options',
        'public_keys': 'public_keys'
    }

    def __init__(self, network_identifier=None, options=None, public_keys=None):  # noqa: E501
        """ConstructionMetadataRequest - a model defined in Swagger"""  # noqa: E501
        self._network_identifier = None
        self._options = None
        self._public_keys = None
        self.discriminator = None
        self.network_identifier = network_identifier
        if options is not None:
            self.options = options
        if public_keys is not None:
            self.public_keys = public_keys

    @property
    def network_identifier(self):
        """Gets the network_identifier of this ConstructionMetadataRequest.  # noqa: E501


        :return: The network_identifier of this ConstructionMetadataRequest.  # noqa: E501
        :rtype: NetworkIdentifier
        """
        return self._network_identifier

    @network_identifier.setter
    def network_identifier(self, network_identifier):
        """Sets the network_identifier of this ConstructionMetadataRequest.


        :param network_identifier: The network_identifier of this ConstructionMetadataRequest.  # noqa: E501
        :type: NetworkIdentifier
        """
        if network_identifier is None:
            raise ValueError("Invalid value for `network_identifier`, must not be `None`")  # noqa: E501

        self._network_identifier = network_identifier

    @property
    def options(self):
        """Gets the options of this ConstructionMetadataRequest.  # noqa: E501

        Some blockchains require different metadata for different types of transaction construction (ex: delegation versus a transfer). Instead of requiring a blockchain node to return all possible types of metadata for construction (which may require multiple node fetches), the client can populate an options object to limit the metadata returned to only the subset required.  # noqa: E501

        :return: The options of this ConstructionMetadataRequest.  # noqa: E501
        :rtype: object
        """
        return self._options

    @options.setter
    def options(self, options):
        """Sets the options of this ConstructionMetadataRequest.

        Some blockchains require different metadata for different types of transaction construction (ex: delegation versus a transfer). Instead of requiring a blockchain node to return all possible types of metadata for construction (which may require multiple node fetches), the client can populate an options object to limit the metadata returned to only the subset required.  # noqa: E501

        :param options: The options of this ConstructionMetadataRequest.  # noqa: E501
        :type: object
        """

        self._options = options

    @property
    def public_keys(self):
        """Gets the public_keys of this ConstructionMetadataRequest.  # noqa: E501


        :return: The public_keys of this ConstructionMetadataRequest.  # noqa: E501
        :rtype: list[PublicKey]
        """
        return self._public_keys

    @public_keys.setter
    def public_keys(self, public_keys):
        """Sets the public_keys of this ConstructionMetadataRequest.


        :param public_keys: The public_keys of this ConstructionMetadataRequest.  # noqa: E501
        :type: list[PublicKey]
        """

        self._public_keys = public_keys

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
        if issubclass(ConstructionMetadataRequest, dict):
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
        if not isinstance(other, ConstructionMetadataRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
