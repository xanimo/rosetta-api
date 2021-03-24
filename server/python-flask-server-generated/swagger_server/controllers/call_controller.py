import connexion
import six

from swagger_server.models.call_request import CallRequest  # noqa: E501
from swagger_server.models.call_response import CallResponse  # noqa: E501
from swagger_server.models.error import Error  # noqa: E501
from swagger_server import util


def call(body):  # noqa: E501
    """Make a Network-Specific Procedure Call

    Call invokes an arbitrary, network-specific procedure call with network-specific parameters. The guidance for what this endpoint should or could do is purposely left vague. In Ethereum, this could be used to invoke &#x60;eth_call&#x60; to implement an entire Rosetta API interface for some smart contract that is not parsed by the implementation creator (like a DEX). This endpoint could also be used to provide access to data that does not map to any Rosetta models instead of requiring an integrator to use some network-specific SDK and call some network-specific endpoint (like surfacing staking parameters). Call is NOT a replacement for implementing Rosetta API endpoints or mapping network-specific data to Rosetta models. Rather, it enables developers to build additional Rosetta API interfaces for things they care about without introducing complexity into a base-level Rosetta implementation. Simply put, imagine that the average integrator will use layered Rosetta API implementations that each surfaces unique data. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: CallResponse
    """
    if connexion.request.is_json:
        body = CallRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'
