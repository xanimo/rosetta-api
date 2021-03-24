import connexion
import six

from swagger_server.models.construction_combine_request import ConstructionCombineRequest  # noqa: E501
from swagger_server.models.construction_combine_response import ConstructionCombineResponse  # noqa: E501
from swagger_server.models.construction_derive_request import ConstructionDeriveRequest  # noqa: E501
from swagger_server.models.construction_derive_response import ConstructionDeriveResponse  # noqa: E501
from swagger_server.models.construction_hash_request import ConstructionHashRequest  # noqa: E501
from swagger_server.models.construction_metadata_request import ConstructionMetadataRequest  # noqa: E501
from swagger_server.models.construction_metadata_response import ConstructionMetadataResponse  # noqa: E501
from swagger_server.models.construction_parse_request import ConstructionParseRequest  # noqa: E501
from swagger_server.models.construction_parse_response import ConstructionParseResponse  # noqa: E501
from swagger_server.models.construction_payloads_request import ConstructionPayloadsRequest  # noqa: E501
from swagger_server.models.construction_payloads_response import ConstructionPayloadsResponse  # noqa: E501
from swagger_server.models.construction_preprocess_request import ConstructionPreprocessRequest  # noqa: E501
from swagger_server.models.construction_preprocess_response import ConstructionPreprocessResponse  # noqa: E501
from swagger_server.models.construction_submit_request import ConstructionSubmitRequest  # noqa: E501
from swagger_server.models.error import Error  # noqa: E501
from swagger_server.models.transaction_identifier_response import TransactionIdentifierResponse  # noqa: E501
from swagger_server import util


def construction_combine(body):  # noqa: E501
    """Create Network Transaction from Signatures

    Combine creates a network-specific transaction from an unsigned transaction and an array of provided signatures. The signed transaction returned from this method will be sent to the &#x60;/construction/submit&#x60; endpoint by the caller. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: ConstructionCombineResponse
    """
    if connexion.request.is_json:
        body = ConstructionCombineRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def construction_derive(body):  # noqa: E501
    """Derive an AccountIdentifier from a PublicKey

    Derive returns the AccountIdentifier associated with a public key. Blockchains that require an on-chain action to create an account should not implement this method. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: ConstructionDeriveResponse
    """
    if connexion.request.is_json:
        body = ConstructionDeriveRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def construction_hash(body):  # noqa: E501
    """Get the Hash of a Signed Transaction

    TransactionHash returns the network-specific transaction hash for a signed transaction. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: TransactionIdentifierResponse
    """
    if connexion.request.is_json:
        body = ConstructionHashRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def construction_metadata(body):  # noqa: E501
    """Get Metadata for Transaction Construction

    Get any information required to construct a transaction for a specific network. Metadata returned here could be a recent hash to use, an account sequence number, or even arbitrary chain state. The request used when calling this endpoint is created by calling &#x60;/construction/preprocess&#x60; in an offline environment. You should NEVER assume that the request sent to this endpoint will be created by the caller or populated with any custom parameters. This must occur in &#x60;/construction/preprocess&#x60;. It is important to clarify that this endpoint should not pre-construct any transactions for the client (this should happen in &#x60;/construction/payloads&#x60;). This endpoint is left purposely unstructured because of the wide scope of metadata that could be required. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: ConstructionMetadataResponse
    """
    if connexion.request.is_json:
        body = ConstructionMetadataRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def construction_parse(body):  # noqa: E501
    """Parse a Transaction

    Parse is called on both unsigned and signed transactions to understand the intent of the formulated transaction. This is run as a sanity check before signing (after &#x60;/construction/payloads&#x60;) and before broadcast (after &#x60;/construction/combine&#x60;).  # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: ConstructionParseResponse
    """
    if connexion.request.is_json:
        body = ConstructionParseRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def construction_payloads(body):  # noqa: E501
    """Generate an Unsigned Transaction and Signing Payloads

    Payloads is called with an array of operations and the response from &#x60;/construction/metadata&#x60;. It returns an unsigned transaction blob and a collection of payloads that must be signed by particular AccountIdentifiers using a certain SignatureType. The array of operations provided in transaction construction often times can not specify all \&quot;effects\&quot; of a transaction (consider invoked transactions in Ethereum). However, they can deterministically specify the \&quot;intent\&quot; of the transaction, which is sufficient for construction. For this reason, parsing the corresponding transaction in the Data API (when it lands on chain) will contain a superset of whatever operations were provided during construction. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: ConstructionPayloadsResponse
    """
    if connexion.request.is_json:
        body = ConstructionPayloadsRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def construction_preprocess(body):  # noqa: E501
    """Create a Request to Fetch Metadata

    Preprocess is called prior to &#x60;/construction/payloads&#x60; to construct a request for any metadata that is needed for transaction construction given (i.e. account nonce). The &#x60;options&#x60; object returned from this endpoint will be sent to the &#x60;/construction/metadata&#x60; endpoint UNMODIFIED by the caller (in an offline execution environment). If your Construction API implementation has configuration options, they MUST be specified in the &#x60;/construction/preprocess&#x60; request (in the &#x60;metadata&#x60; field). # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: ConstructionPreprocessResponse
    """
    if connexion.request.is_json:
        body = ConstructionPreprocessRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def construction_submit(body):  # noqa: E501
    """Submit a Signed Transaction

    Submit a pre-signed transaction to the node. This call should not block on the transaction being included in a block. Rather, it should return immediately with an indication of whether or not the transaction was included in the mempool. The transaction submission response should only return a 200 status if the submitted transaction could be included in the mempool. Otherwise, it should return an error. # noqa: E501

    :param body: 
    :type body: dict | bytes

    :rtype: TransactionIdentifierResponse
    """
    if connexion.request.is_json:
        body = ConstructionSubmitRequest.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'
