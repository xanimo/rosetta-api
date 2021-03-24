import connexion
import six

from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.mempool_response import MempoolResponse  # noqa: E501
from swagger_server.models.mempool_transaction_request import MempoolTransactionRequest  # noqa: E501
from swagger_server.models.mempool_transaction_response import MempoolTransactionResponse  # noqa: E501
from swagger_server.models.network_request import NetworkRequest  # noqa: E501
from swagger_server import util


def mempool(body):  # noqa: E501
    """Get All Mempool Transactions

    Get all Transaction Identifiers in the mempool # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: MempoolResponse
    """
    if connexion.request.is_json:
        body = NetworkRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def mempool_transaction(body):  # noqa: E501
    """Get a Mempool Transaction

    Get a transaction in the mempool by its Transaction Identifier. This is a separate request than fetching a block transaction (/block/transaction) because some blockchain nodes need to know that a transaction query is for something in the mempool instead of a transaction in a block. Transactions may not be fully parsable until they are in a block (ex: may not be possible to determine the fee to pay before a transaction is executed). On this endpoint, it is ok that returned transactions are only estimates of what may actually be included in a block. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: MempoolTransactionResponse
    """
    if connexion.request.is_json:
        body = MempoolTransactionRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'
