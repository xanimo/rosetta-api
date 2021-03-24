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

class Error(object):
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
        'code': 'int',
        'message': 'str',
        'description': 'str',
        'retriable': 'bool',
        'details': 'object'
    }

    attribute_map = {
        'code': 'code',
        'message': 'message',
        'description': 'description',
        'retriable': 'retriable',
        'details': 'details'
    }

    def __init__(self, code=None, message=None, description=None, retriable=None, details=None):  # noqa: E501
        """Error - a model defined in Swagger"""  # noqa: E501
        self._code = None
        self._message = None
        self._description = None
        self._retriable = None
        self._details = None
        self.discriminator = None
        self.code = code
        self.message = message
        if description is not None:
            self.description = description
        self.retriable = retriable
        if details is not None:
            self.details = details

    @property
    def code(self):
        """Gets the code of this Error.  # noqa: E501

        Code is a network-specific error code. If desired, this code can be equivalent to an HTTP status code.  # noqa: E501

        :return: The code of this Error.  # noqa: E501
        :rtype: int
        """
        return self._code

    @code.setter
    def code(self, code):
        """Sets the code of this Error.

        Code is a network-specific error code. If desired, this code can be equivalent to an HTTP status code.  # noqa: E501

        :param code: The code of this Error.  # noqa: E501
        :type: int
        """
        if code is None:
            raise ValueError("Invalid value for `code`, must not be `None`")  # noqa: E501

        self._code = code

    @property
    def message(self):
        """Gets the message of this Error.  # noqa: E501

        Message is a network-specific error message. The message MUST NOT change for a given code. In particular, this means that any contextual information should be included in the details field.  # noqa: E501

        :return: The message of this Error.  # noqa: E501
        :rtype: str
        """
        return self._message

    @message.setter
    def message(self, message):
        """Sets the message of this Error.

        Message is a network-specific error message. The message MUST NOT change for a given code. In particular, this means that any contextual information should be included in the details field.  # noqa: E501

        :param message: The message of this Error.  # noqa: E501
        :type: str
        """
        if message is None:
            raise ValueError("Invalid value for `message`, must not be `None`")  # noqa: E501

        self._message = message

    @property
    def description(self):
        """Gets the description of this Error.  # noqa: E501

        Description allows the implementer to optionally provide additional information about an error. In many cases, the content of this field will be a copy-and-paste from existing developer documentation. Description can ONLY be populated with generic information about a particular type of error. It MUST NOT be populated with information about a particular instantiation of an error (use `details` for this). Whereas the content of Error.Message should stay stable across releases, the content of Error.Description will likely change across releases (as implementers improve error documentation). For this reason, the content in this field is not part of any type assertion (unlike Error.Message).  # noqa: E501

        :return: The description of this Error.  # noqa: E501
        :rtype: str
        """
        return self._description

    @description.setter
    def description(self, description):
        """Sets the description of this Error.

        Description allows the implementer to optionally provide additional information about an error. In many cases, the content of this field will be a copy-and-paste from existing developer documentation. Description can ONLY be populated with generic information about a particular type of error. It MUST NOT be populated with information about a particular instantiation of an error (use `details` for this). Whereas the content of Error.Message should stay stable across releases, the content of Error.Description will likely change across releases (as implementers improve error documentation). For this reason, the content in this field is not part of any type assertion (unlike Error.Message).  # noqa: E501

        :param description: The description of this Error.  # noqa: E501
        :type: str
        """

        self._description = description

    @property
    def retriable(self):
        """Gets the retriable of this Error.  # noqa: E501

        An error is retriable if the same request may succeed if submitted again.  # noqa: E501

        :return: The retriable of this Error.  # noqa: E501
        :rtype: bool
        """
        return self._retriable

    @retriable.setter
    def retriable(self, retriable):
        """Sets the retriable of this Error.

        An error is retriable if the same request may succeed if submitted again.  # noqa: E501

        :param retriable: The retriable of this Error.  # noqa: E501
        :type: bool
        """
        if retriable is None:
            raise ValueError("Invalid value for `retriable`, must not be `None`")  # noqa: E501

        self._retriable = retriable

    @property
    def details(self):
        """Gets the details of this Error.  # noqa: E501

        Often times it is useful to return context specific to the request that caused the error (i.e. a sample of the stack trace or impacted account) in addition to the standard error message.  # noqa: E501

        :return: The details of this Error.  # noqa: E501
        :rtype: object
        """
        return self._details

    @details.setter
    def details(self, details):
        """Sets the details of this Error.

        Often times it is useful to return context specific to the request that caused the error (i.e. a sample of the stack trace or impacted account) in addition to the standard error message.  # noqa: E501

        :param details: The details of this Error.  # noqa: E501
        :type: object
        """

        self._details = details

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
        if issubclass(Error, dict):
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
        if not isinstance(other, Error):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
