import connexion
import six

from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.events_blocks_request import EventsBlocksRequest  # noqa: E501
from swagger_server.models.events_blocks_response import EventsBlocksResponse  # noqa: E501
from swagger_server import util


def events_blocks(body):  # noqa: E501
    """[INDEXER] Get a range of BlockEvents

    &#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: EventsBlocksResponse
    """
    if connexion.request.is_json:
        body = EventsBlocksRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'
