# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class SignatureType(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    allowed enum values
    """
    ECDSA = "ecdsa"
    ECDSA_RECOVERY = "ecdsa_recovery"
    ED25519 = "ed25519"
    SCHNORR_1 = "schnorr_1"
    SCHNORR_POSEIDON = "schnorr_poseidon"
    def __init__(self):  # noqa: E501
        """SignatureType - a model defined in Swagger

        """
        self.swagger_types = {
        }

        self.attribute_map = {
        }

    @classmethod
    def from_dict(cls, dikt) -> 'SignatureType':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The SignatureType of this SignatureType.  # noqa: E501
        :rtype: SignatureType
        """
        return util.deserialize_model(dikt, cls)