import connexion
import six

from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.search_transactions_request import SearchTransactionsRequest  # noqa: E501
from swagger_server.models.search_transactions_response import SearchTransactionsResponse  # noqa: E501
from swagger_server import util


def search_transactions(body):  # noqa: E501
    """[INDEXER] Search for Transactions

    &#x60;/search/transactions&#x60; allows the caller to search for transactions that meet certain conditions. Some conditions include matching a transaction hash, containing an operation with a certain status, or containing an operation that affects a certain account. &#x60;/search/transactions&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: SearchTransactionsResponse
    """
    if connexion.request.is_json:
        body = SearchTransactionsRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'
