import connexion
import six

from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.metadata_request import MetadataRequest  # noqa: E501
from swagger_server.models.network_list_response import NetworkListResponse  # noqa: E501
from swagger_server.models.network_options_response import NetworkOptionsResponse  # noqa: E501
from swagger_server.models.network_request import NetworkRequest  # noqa: E501
from swagger_server.models.network_status_response import NetworkStatusResponse  # noqa: E501
from swagger_server import util


def network_list(body):  # noqa: E501
    """Get List of Available Networks

    This endpoint returns a list of NetworkIdentifiers that the Rosetta server supports. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: NetworkListResponse
    """
    if connexion.request.is_json:
        body = MetadataRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def network_options(body):  # noqa: E501
    """Get Network Options

    This endpoint returns the version information and allowed network-specific types for a NetworkIdentifier. Any NetworkIdentifier returned by /network/list should be accessible here. Because options are retrievable in the context of a NetworkIdentifier, it is possible to define unique options for each network. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: NetworkOptionsResponse
    """
    if connexion.request.is_json:
        body = NetworkRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def network_status(body):  # noqa: E501
    """Get Network Status

    This endpoint returns the current status of the network requested. Any NetworkIdentifier returned by /network/list should be accessible here. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: NetworkStatusResponse
    """
    if connexion.request.is_json:
        body = NetworkRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'
