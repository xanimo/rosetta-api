import connexion
import six

from swagger_server.models.account_balance_request import AccountBalanceRequest  # noqa: E501
from swagger_server.models.account_balance_response import AccountBalanceResponse  # noqa: E501
from swagger_server.models.account_coins_request import AccountCoinsRequest  # noqa: E501
from swagger_server.models.account_coins_response import AccountCoinsResponse  # noqa: E501
from swagger_server.models.error import Error  # noqa: E501
from swagger_server import util


def account_balance(body):  # noqa: E501
    """Get an Account&#x27;s Balance

    Get an array of all AccountBalances for an AccountIdentifier and the BlockIdentifier at which the balance lookup was performed. The BlockIdentifier must always be returned because some consumers of account balance data need to know specifically at which block the balance was calculated to compare balances they compute from operations with the balance returned by the node. It is important to note that making a balance request for an account without populating the SubAccountIdentifier should not result in the balance of all possible SubAccountIdentifiers being returned. Rather, it should result in the balance pertaining to no SubAccountIdentifiers being returned (sometimes called the liquid balance). To get all balances associated with an account, it may be necessary to perform multiple balance requests with unique AccountIdentifiers. It is also possible to perform a historical balance lookup (if the server supports it) by passing in an optional BlockIdentifier. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: AccountBalanceResponse
    """
    if connexion.request.is_json:
        body = AccountBalanceRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def account_coins(body):  # noqa: E501
    """Get an Account&#x27;s Unspent Coins

    Get an array of all unspent coins for an AccountIdentifier and the BlockIdentifier at which the lookup was performed. If your implementation does not support coins (i.e. it is for an account-based blockchain), you do not need to implement this endpoint. If you implementation does support coins (i.e. it is fro a UTXO-based blockchain), you MUST also complete the &#x60;/account/balance&#x60; endpoint. It is important to note that making a coins request for an account without populating the SubAccountIdentifier should not result in the coins of all possible SubAccountIdentifiers being returned. Rather, it should result in the coins pertaining to no SubAccountIdentifiers being returned. To get all coins associated with an account, it may be necessary to perform multiple coin requests with unique AccountIdentifiers. Optionally, an implementation may choose to support updating an AccountIdentifier&#x27;s unspent coins based on the contents of the mempool. Note, using this functionality breaks any guarantee of idempotency. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: AccountCoinsResponse
    """
    if connexion.request.is_json:
        body = AccountCoinsRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'
