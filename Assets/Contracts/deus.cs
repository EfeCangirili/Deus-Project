#pragma warning disable warning-list
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace DEUS
{


    public class DEUSConsole
    {
        public static async Task Main()
        {
            var url = "http://testchain.nethereum.com:8545";
            //var url = "https://mainnet.infura.io";
            var privateKey = "0x7580e7fb49df1c861f0050fae31c2224c6aba908e116b8da44ee8cd927b990b0";
            var account = new Nethereum.Web3.Accounts.Account(privateKey);
            var web3 = new Web3(account, url);
            
             /* Deployment 
            var dEUSDeployment = new DEUSDeployment();

            var transactionReceiptDeployment = await web3.Eth.GetContractDeploymentHandler<DEUSDeployment>().SendRequestAndWaitForReceiptAsync(dEUSDeployment);
            var contractAddress = transactionReceiptDeployment.ContractAddress;
             */ 
            var contractAddress = "0xe6f18761A1f601ff9dc705A3486bD1b34cdcb6C6";
            var contractHandler = web3.Eth.GetContractHandler(contractAddress);

            /** Function: BASICPLAYER_BLACK**/
            /*
            var bASICPLAYER_BLACKFunctionReturn = await contractHandler.QueryAsync<BASICPLAYER_BLACKFunction, BigInteger>();
            */


            /** Function: BASICPLAYER_BLUE**/
            /*
            var bASICPLAYER_BLUEFunctionReturn = await contractHandler.QueryAsync<BASICPLAYER_BLUEFunction, BigInteger>();
            */


            /** Function: BASICPLAYER_ORANGE**/
            /*
            var bASICPLAYER_ORANGEFunctionReturn = await contractHandler.QueryAsync<BASICPLAYER_ORANGEFunction, BigInteger>();
            */


            /** Function: BASICPLAYER_RED**/
            /*
            var bASICPLAYER_REDFunctionReturn = await contractHandler.QueryAsync<BASICPLAYER_REDFunction, BigInteger>();
            */


            /** Function: DEUS_ADDRESS**/
            /*
            var dEUS_ADDRESSFunctionReturn = await contractHandler.QueryAsync<DEUS_ADDRESSFunction, string>();
            */


            /** Function: IS_SALE_ACTIVE**/
            /*
            var iS_SALE_ACTIVEFunctionReturn = await contractHandler.QueryAsync<IS_SALE_ACTIVEFunction, bool>();
            */


            /** Function: balanceOf**/
            /*
            var balanceOfFunction = new BalanceOfFunction();
            balanceOfFunction.Account = account;
            balanceOfFunction.Id = id;
            var balanceOfFunctionReturn = await contractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction);
            */


            /** Function: balanceOfBatch**/
            /*
            var balanceOfBatchFunction = new BalanceOfBatchFunction();
            balanceOfBatchFunction.Accounts = accounts;
            balanceOfBatchFunction.Ids = ids;
            var balanceOfBatchFunctionReturn = await contractHandler.QueryAsync<BalanceOfBatchFunction, List<BigInteger>>(balanceOfBatchFunction);
            */


            /** Function: isApprovedForAll**/
            /*
            var isApprovedForAllFunction = new IsApprovedForAllFunction();
            isApprovedForAllFunction.Account = account;
            isApprovedForAllFunction.Operator = operator;
            var isApprovedForAllFunctionReturn = await contractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction);
            */


            /** Function: owner**/
            /*
            var ownerFunctionReturn = await contractHandler.QueryAsync<OwnerFunction, string>();
            */


            /** Function: renounceOwnership**/
            /*
            var renounceOwnershipFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>();
            */


            /** Function: safeBatchTransferFrom**/
            /*
            var safeBatchTransferFromFunction = new SafeBatchTransferFromFunction();
            safeBatchTransferFromFunction.From = from;
            safeBatchTransferFromFunction.To = to;
            safeBatchTransferFromFunction.Ids = ids;
            safeBatchTransferFromFunction.Amounts = amounts;
            safeBatchTransferFromFunction.Data = data;
            var safeBatchTransferFromFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(safeBatchTransferFromFunction);
            */


            /** Function: safeMint**/
            /*
            var safeMintFunction = new SafeMintFunction();
            safeMintFunction.TokenId = tokenId;
            safeMintFunction.Amount = amount;
            var safeMintFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(safeMintFunction);
            */


            /** Function: safeTransferFrom**/
            /*
            var safeTransferFromFunction = new SafeTransferFromFunction();
            safeTransferFromFunction.From = from;
            safeTransferFromFunction.To = to;
            safeTransferFromFunction.Id = id;
            safeTransferFromFunction.Amount = amount;
            safeTransferFromFunction.Data = data;
            var safeTransferFromFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction);
            */


            /** Function: setApprovalForAll**/
            /*
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
            setApprovalForAllFunction.Operator = operator;
            setApprovalForAllFunction.Approved = approved;
            var setApprovalForAllFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction);
            */


            /** Function: supportsInterface**/
            /*
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
            supportsInterfaceFunction.InterfaceId = interfaceId;
            var supportsInterfaceFunctionReturn = await contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction);
            */


            /** Function: togglePublicSale**/
            /*
            var togglePublicSaleFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<TogglePublicSaleFunction>();
            */


            /** Function: transferOwnership**/
            /*
            var transferOwnershipFunction = new TransferOwnershipFunction();
            transferOwnershipFunction.NewOwner = newOwner;
            var transferOwnershipFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction);
            */


            /** Function: uri**/
            /*
            var uriFunction = new UriFunction();
            uriFunction.Id = id;
            var uriFunctionReturn = await contractHandler.QueryAsync<UriFunction, string>(uriFunction);
            */


            /** Function: withdrawAll**/
            /*
            var withdrawAllFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<WithdrawAllFunction>();
            */
        }

    }

    public partial class DEUSDeployment : DEUSDeploymentBase
    {
        public DEUSDeployment() : base(BYTECODE) { }
        public DEUSDeployment(string byteCode) : base(byteCode) { }
    }

    public class DEUSDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60806040526005805460ff191690553480156200001b57600080fd5b5060405180606001604052806037815260200162001de060379139620000418162000053565b506200004d336200006c565b620001a1565b805162000068906002906020840190620000be565b5050565b600380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b828054620000cc9062000164565b90600052602060002090601f016020900481019282620000f057600085556200013b565b82601f106200010b57805160ff19168380011785556200013b565b828001600101855582156200013b579182015b828111156200013b5782518255916020019190600101906200011e565b50620001499291506200014d565b5090565b5b808211156200014957600081556001016200014e565b600181811c908216806200017957607f821691505b602082108114156200019b57634e487b7160e01b600052602260045260246000fd5b50919050565b611c2f80620001b16000396000f3fe60806040526004361061011e5760003560e01c8063853828b6116100a0578063c7421b4f11610064578063c7421b4f14610316578063e222c7f91461032b578063e985e9c514610340578063f242432a14610389578063f2fde38b146103a957600080fd5b8063853828b61461029957806389eeab0e146102ae5780638da5cb5b146102c3578063a22cb465146102e1578063b6cbc8661461030157600080fd5b80632eb2c2d6116100e75780632eb2c2d6146101dd5780634ae281c3146101fd5780634e1273f41461023d578063715018a61461026a57806376d02b711461027f57600080fd5b8062fdd58e1461012357806301ffc9a7146101565780630414ab2b146101865780630e89341c1461019b5780631439f1f9146101c8575b600080fd5b34801561012f57600080fd5b5061014361013e3660046113a3565b6103c9565b6040519081526020015b60405180910390f35b34801561016257600080fd5b506101766101713660046113e3565b610460565b604051901515815260200161014d565b610199610194366004611407565b6104b2565b005b3480156101a757600080fd5b506101bb6101b6366004611429565b610711565b60405161014d919061148f565b3480156101d457600080fd5b50610143600381565b3480156101e957600080fd5b506101996101f83660046115ee565b6107b3565b34801561020957600080fd5b50610225732b7620dc9942d8d5064db021348224d418994bcc81565b6040516001600160a01b03909116815260200161014d565b34801561024957600080fd5b5061025d610258366004611698565b61084a565b60405161014d919061179e565b34801561027657600080fd5b50610199610974565b34801561028b57600080fd5b506005546101769060ff1681565b3480156102a557600080fd5b506101996109aa565b3480156102ba57600080fd5b50610143600081565b3480156102cf57600080fd5b506003546001600160a01b0316610225565b3480156102ed57600080fd5b506101996102fc3660046117b1565b610a00565b34801561030d57600080fd5b50610143600181565b34801561032257600080fd5b50610143600281565b34801561033757600080fd5b50610199610ad7565b34801561034c57600080fd5b5061017661035b3660046117ed565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205460ff1690565b34801561039557600080fd5b506101996103a4366004611820565b610b15565b3480156103b557600080fd5b506101996103c4366004611885565b610b9c565b60006001600160a01b03831661043a5760405162461bcd60e51b815260206004820152602b60248201527f455243313135353a2062616c616e636520717565727920666f7220746865207a60448201526a65726f206164647265737360a81b60648201526084015b60405180910390fd5b506000908152602081815260408083206001600160a01b03949094168352929052205490565b60006001600160e01b03198216636cdb3d1360e11b148061049157506001600160e01b031982166303a24d0760e21b145b806104ac57506301ffc9a760e01b6001600160e01b03198316145b92915050565b3332146104f65760405162461bcd60e51b81526020600482015260126024820152712737ba1030b63637bbb2b21037b934b3b4b760711b6044820152606401610431565b60055460ff1661053b5760405162461bcd60e51b815260206004820152601060248201526f14d85b19481b9bdd081cdd185c9d195960821b6044820152606401610431565b61054d6701118f178fb48000826118b6565b34101561059c5760405162461bcd60e51b815260206004820152601860248201527f4e6f7420656e6f7567682065746865722062616c616e636500000000000000006044820152606401610431565b600a8111156105e25760405162461bcd60e51b8152602060048201526012602482015271151bdbc81b585b9e481c995c5d595cdd195960721b6044820152606401610431565b60006105ed60045490565b90506122b86105fc83836118d5565b106106405760405162461bcd60e51b81526020600482015260146024820152734578636565647320746f74616c20737570706c7960601b6044820152606401610431565b33600090815260076020526040902054600a9061065e9084906118d5565b11156106a05760405162461bcd60e51b81526020600482015260116024820152704578636565647320616c6c6f77616e636560781b6044820152606401610431565b33600090815260076020526040812080548492906106bf9084906118d5565b90915550600090505b8281101561070b576106de600480546001019055565b6106f933858560405180602001604052806000815250610c34565b80610703816118ed565b9150506106c8565b50505050565b600081815260066020526040902080546060919061072e90611908565b80601f016020809104026020016040519081016040528092919081815260200182805461075a90611908565b80156107a75780601f1061077c576101008083540402835291602001916107a7565b820191906000526020600020905b81548152906001019060200180831161078a57829003601f168201915b50505050509050919050565b6001600160a01b0385163314806107cf57506107cf853361035b565b6108365760405162461bcd60e51b815260206004820152603260248201527f455243313135353a207472616e736665722063616c6c6572206973206e6f74206044820152711bdddb995c881b9bdc88185c1c1c9bdd995960721b6064820152608401610431565b6108438585858585610d3e565b5050505050565b606081518351146108af5760405162461bcd60e51b815260206004820152602960248201527f455243313135353a206163636f756e747320616e6420696473206c656e677468604482015268040dad2e6dac2e8c6d60bb1b6064820152608401610431565b6000835167ffffffffffffffff8111156108cb576108cb6114a2565b6040519080825280602002602001820160405280156108f4578160200160208202803683370190505b50905060005b845181101561096c5761093f85828151811061091857610918611943565b602002602001015185838151811061093257610932611943565b60200260200101516103c9565b82828151811061095157610951611943565b6020908102919091010152610965816118ed565b90506108fa565b509392505050565b6003546001600160a01b0316331461099e5760405162461bcd60e51b815260040161043190611959565b6109a86000610f1b565b565b6003546001600160a01b031633146109d45760405162461bcd60e51b815260040161043190611959565b47806109df57600080fd5b6109fd732b7620dc9942d8d5064db021348224d418994bcc82610f6d565b50565b336001600160a01b0383161415610a6b5760405162461bcd60e51b815260206004820152602960248201527f455243313135353a2073657474696e6720617070726f76616c20737461747573604482015268103337b91039b2b63360b91b6064820152608401610431565b3360008181526001602090815260408083206001600160a01b03871680855290835292819020805460ff191686151590811790915590519081529192917f17307eab39ab6107e8899845ad3d59bd9653f200f220920489ca2b5937696c31910160405180910390a35050565b6003546001600160a01b03163314610b015760405162461bcd60e51b815260040161043190611959565b6005805460ff19811660ff90911615179055565b6001600160a01b038516331480610b315750610b31853361035b565b610b8f5760405162461bcd60e51b815260206004820152602960248201527f455243313135353a2063616c6c6572206973206e6f74206f776e6572206e6f7260448201526808185c1c1c9bdd995960ba1b6064820152608401610431565b6108438585858585611008565b6003546001600160a01b03163314610bc65760405162461bcd60e51b815260040161043190611959565b6001600160a01b038116610c2b5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610431565b6109fd81610f1b565b6001600160a01b038416610c945760405162461bcd60e51b815260206004820152602160248201527f455243313135353a206d696e7420746f20746865207a65726f206164647265736044820152607360f81b6064820152608401610431565b33610cae81600087610ca588611125565b61084388611125565b6000848152602081815260408083206001600160a01b038916845290915281208054859290610cde9084906118d5565b909155505060408051858152602081018590526001600160a01b0380881692600092918516917fc3d58168c5ae7397731d063d5bbf3d657854427343f4c083240f7aacaa2d0f62910160405180910390a461084381600087878787611170565b8151835114610da05760405162461bcd60e51b815260206004820152602860248201527f455243313135353a2069647320616e6420616d6f756e7473206c656e677468206044820152670dad2e6dac2e8c6d60c31b6064820152608401610431565b6001600160a01b038416610dc65760405162461bcd60e51b81526004016104319061198e565b3360005b8451811015610ead576000858281518110610de757610de7611943565b602002602001015190506000858381518110610e0557610e05611943565b602090810291909101810151600084815280835260408082206001600160a01b038e168352909352919091205490915081811015610e555760405162461bcd60e51b8152600401610431906119d3565b6000838152602081815260408083206001600160a01b038e8116855292528083208585039055908b16825281208054849290610e929084906118d5565b9250508190555050505080610ea6906118ed565b9050610dca565b50846001600160a01b0316866001600160a01b0316826001600160a01b03167f4a39dc06d4c0dbc64b70af90fd698a233a518aa5d07e595d983b8c0526c8f7fb8787604051610efd929190611a1d565b60405180910390a4610f138187878787876112cc565b505050505050565b600380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6000826001600160a01b03168260405160006040518083038185875af1925050503d8060008114610fba576040519150601f19603f3d011682016040523d82523d6000602084013e610fbf565b606091505b50509050806110035760405162461bcd60e51b815260206004820152601060248201526f2a3930b739b332b9103330b4b632b21760811b6044820152606401610431565b505050565b6001600160a01b03841661102e5760405162461bcd60e51b81526004016104319061198e565b3361103e818787610ca588611125565b6000848152602081815260408083206001600160a01b038a1684529091529020548381101561107f5760405162461bcd60e51b8152600401610431906119d3565b6000858152602081815260408083206001600160a01b038b81168552925280832087850390559088168252812080548692906110bc9084906118d5565b909155505060408051868152602081018690526001600160a01b03808916928a821692918616917fc3d58168c5ae7397731d063d5bbf3d657854427343f4c083240f7aacaa2d0f62910160405180910390a461111c828888888888611170565b50505050505050565b6040805160018082528183019092526060916000919060208083019080368337019050509050828160008151811061115f5761115f611943565b602090810291909101015292915050565b6001600160a01b0384163b15610f135760405163f23a6e6160e01b81526001600160a01b0385169063f23a6e61906111b49089908990889088908890600401611a4b565b6020604051808303816000875af19250505080156111ef575060408051601f3d908101601f191682019092526111ec91810190611a90565b60015b61129c576111fb611aad565b806308c379a014156112355750611210611ac9565b8061121b5750611237565b8060405162461bcd60e51b8152600401610431919061148f565b505b60405162461bcd60e51b815260206004820152603460248201527f455243313135353a207472616e7366657220746f206e6f6e20455243313135356044820152732932b1b2b4bb32b91034b6b83632b6b2b73a32b960611b6064820152608401610431565b6001600160e01b0319811663f23a6e6160e01b1461111c5760405162461bcd60e51b815260040161043190611b53565b6001600160a01b0384163b15610f135760405163bc197c8160e01b81526001600160a01b0385169063bc197c81906113109089908990889088908890600401611b9b565b6020604051808303816000875af192505050801561134b575060408051601f3d908101601f1916820190925261134891810190611a90565b60015b611357576111fb611aad565b6001600160e01b0319811663bc197c8160e01b1461111c5760405162461bcd60e51b815260040161043190611b53565b80356001600160a01b038116811461139e57600080fd5b919050565b600080604083850312156113b657600080fd5b6113bf83611387565b946020939093013593505050565b6001600160e01b0319811681146109fd57600080fd5b6000602082840312156113f557600080fd5b8135611400816113cd565b9392505050565b6000806040838503121561141a57600080fd5b50508035926020909101359150565b60006020828403121561143b57600080fd5b5035919050565b6000815180845260005b818110156114685760208185018101518683018201520161144c565b8181111561147a576000602083870101525b50601f01601f19169290920160200192915050565b6020815260006114006020830184611442565b634e487b7160e01b600052604160045260246000fd5b601f8201601f1916810167ffffffffffffffff811182821017156114de576114de6114a2565b6040525050565b600067ffffffffffffffff8211156114ff576114ff6114a2565b5060051b60200190565b600082601f83011261151a57600080fd5b81356020611527826114e5565b60405161153482826114b8565b83815260059390931b850182019282810191508684111561155457600080fd5b8286015b8481101561156f5780358352918301918301611558565b509695505050505050565b600082601f83011261158b57600080fd5b813567ffffffffffffffff8111156115a5576115a56114a2565b6040516115bc601f8301601f1916602001826114b8565b8181528460208386010111156115d157600080fd5b816020850160208301376000918101602001919091529392505050565b600080600080600060a0868803121561160657600080fd5b61160f86611387565b945061161d60208701611387565b9350604086013567ffffffffffffffff8082111561163a57600080fd5b61164689838a01611509565b9450606088013591508082111561165c57600080fd5b61166889838a01611509565b9350608088013591508082111561167e57600080fd5b5061168b8882890161157a565b9150509295509295909350565b600080604083850312156116ab57600080fd5b823567ffffffffffffffff808211156116c357600080fd5b818501915085601f8301126116d757600080fd5b813560206116e4826114e5565b6040516116f182826114b8565b83815260059390931b850182019282810191508984111561171157600080fd5b948201945b838610156117365761172786611387565b82529482019490820190611716565b9650508601359250508082111561174c57600080fd5b5061175985828601611509565b9150509250929050565b600081518084526020808501945080840160005b8381101561179357815187529582019590820190600101611777565b509495945050505050565b6020815260006114006020830184611763565b600080604083850312156117c457600080fd5b6117cd83611387565b9150602083013580151581146117e257600080fd5b809150509250929050565b6000806040838503121561180057600080fd5b61180983611387565b915061181760208401611387565b90509250929050565b600080600080600060a0868803121561183857600080fd5b61184186611387565b945061184f60208701611387565b93506040860135925060608601359150608086013567ffffffffffffffff81111561187957600080fd5b61168b8882890161157a565b60006020828403121561189757600080fd5b61140082611387565b634e487b7160e01b600052601160045260246000fd5b60008160001904831182151516156118d0576118d06118a0565b500290565b600082198211156118e8576118e86118a0565b500190565b6000600019821415611901576119016118a0565b5060010190565b600181811c9082168061191c57607f821691505b6020821081141561193d57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052603260045260246000fd5b6020808252818101527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604082015260600190565b60208082526025908201527f455243313135353a207472616e7366657220746f20746865207a65726f206164604082015264647265737360d81b606082015260800190565b6020808252602a908201527f455243313135353a20696e73756666696369656e742062616c616e636520666f60408201526939103a3930b739b332b960b11b606082015260800190565b604081526000611a306040830185611763565b8281036020840152611a428185611763565b95945050505050565b6001600160a01b03868116825285166020820152604081018490526060810183905260a060808201819052600090611a8590830184611442565b979650505050505050565b600060208284031215611aa257600080fd5b8151611400816113cd565b600060033d1115611ac65760046000803e5060005160e01c5b90565b600060443d1015611ad75790565b6040516003193d81016004833e81513d67ffffffffffffffff8160248401118184111715611b0757505050505090565b8285019150815181811115611b1f5750505050505090565b843d8701016020828501011115611b395750505050505090565b611b48602082860101876114b8565b509095945050505050565b60208082526028908201527f455243313135353a204552433131353552656365697665722072656a656374656040820152676420746f6b656e7360c01b606082015260800190565b6001600160a01b0386811682528516602082015260a060408201819052600090611bc790830186611763565b8281036060840152611bd98186611763565b90508281036080840152611bed8185611442565b9897505050505050505056fea2646970667358221220e8b5f12dd89bcd316120eabd49ea388a6f9a20809dd421a1fa51bcd9de4c54f964736f6c634300080a003368747470733a2f2f6b617069646f6f2e6769746875622e696f2f313135352f6d657461646174612f312e302e302f7b69647d2e6a736f6e";
        public DEUSDeploymentBase() : base(BYTECODE) { }
        public DEUSDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class BASICPLAYER_BLACKFunction : BASICPLAYER_BLACKFunctionBase { }

    [Function("BASICPLAYER_BLACK", "uint256")]
    public class BASICPLAYER_BLACKFunctionBase : FunctionMessage
    {

    }

    public partial class BASICPLAYER_BLUEFunction : BASICPLAYER_BLUEFunctionBase { }

    [Function("BASICPLAYER_BLUE", "uint256")]
    public class BASICPLAYER_BLUEFunctionBase : FunctionMessage
    {

    }

    public partial class BASICPLAYER_ORANGEFunction : BASICPLAYER_ORANGEFunctionBase { }

    [Function("BASICPLAYER_ORANGE", "uint256")]
    public class BASICPLAYER_ORANGEFunctionBase : FunctionMessage
    {

    }

    public partial class BASICPLAYER_REDFunction : BASICPLAYER_REDFunctionBase { }

    [Function("BASICPLAYER_RED", "uint256")]
    public class BASICPLAYER_REDFunctionBase : FunctionMessage
    {

    }

    public partial class DEUS_ADDRESSFunction : DEUS_ADDRESSFunctionBase { }

    [Function("DEUS_ADDRESS", "address")]
    public class DEUS_ADDRESSFunctionBase : FunctionMessage
    {

    }

    public partial class IS_SALE_ACTIVEFunction : IS_SALE_ACTIVEFunctionBase { }

    [Function("IS_SALE_ACTIVE", "bool")]
    public class IS_SALE_ACTIVEFunctionBase : FunctionMessage
    {

    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "id", 2)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class BalanceOfBatchFunction : BalanceOfBatchFunctionBase { }

    [Function("balanceOfBatch", "uint256[]")]
    public class BalanceOfBatchFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "accounts", 1)]
        public virtual List<string> Accounts { get; set; }
        [Parameter("uint256[]", "ids", 2)]
        public virtual List<BigInteger> Ids { get; set; }
    }

    public partial class IsApprovedForAllFunction : IsApprovedForAllFunctionBase { }

    [Function("isApprovedForAll", "bool")]
    public class IsApprovedForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "operator", 2)]
        public virtual string Operator { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SafeBatchTransferFromFunction : SafeBatchTransferFromFunctionBase { }

    [Function("safeBatchTransferFrom")]
    public class SafeBatchTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256[]", "ids", 3)]
        public virtual List<BigInteger> Ids { get; set; }
        [Parameter("uint256[]", "amounts", 4)]
        public virtual List<BigInteger> Amounts { get; set; }
        [Parameter("bytes", "data", 5)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SafeMintFunction : SafeMintFunctionBase { }

    [Function("safeMint")]
    public class SafeMintFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "_amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class SafeTransferFromFunction : SafeTransferFromFunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "id", 3)]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "data", 5)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SetApprovalForAllFunction : SetApprovalForAllFunctionBase { }

    [Function("setApprovalForAll")]
    public class SetApprovalForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 2)]
        public virtual bool Approved { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class TogglePublicSaleFunction : TogglePublicSaleFunctionBase { }

    [Function("togglePublicSale")]
    public class TogglePublicSaleFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UriFunction : UriFunctionBase { }

    [Function("uri", "string")]
    public class UriFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class WithdrawAllFunction : WithdrawAllFunctionBase { }

    [Function("withdrawAll")]
    public class WithdrawAllFunctionBase : FunctionMessage
    {

    }

    public partial class ApprovalForAllEventDTO : ApprovalForAllEventDTOBase { }

    [Event("ApprovalForAll")]
    public class ApprovalForAllEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "operator", 2, true )]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 3, false )]
        public virtual bool Approved { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class TransferBatchEventDTO : TransferBatchEventDTOBase { }

    [Event("TransferBatch")]
    public class TransferBatchEventDTOBase : IEventDTO
    {
        [Parameter("address", "operator", 1, true )]
        public virtual string Operator { get; set; }
        [Parameter("address", "from", 2, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 3, true )]
        public virtual string To { get; set; }
        [Parameter("uint256[]", "ids", 4, false )]
        public virtual List<BigInteger> Ids { get; set; }
        [Parameter("uint256[]", "values", 5, false )]
        public virtual List<BigInteger> Values { get; set; }
    }

    public partial class TransferSingleEventDTO : TransferSingleEventDTOBase { }

    [Event("TransferSingle")]
    public class TransferSingleEventDTOBase : IEventDTO
    {
        [Parameter("address", "operator", 1, true )]
        public virtual string Operator { get; set; }
        [Parameter("address", "from", 2, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 3, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "id", 4, false )]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "value", 5, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class URIEventDTO : URIEventDTOBase { }

    [Event("URI")]
    public class URIEventDTOBase : IEventDTO
    {
        [Parameter("string", "value", 1, false )]
        public virtual string Value { get; set; }
        [Parameter("uint256", "id", 2, true )]
        public virtual BigInteger Id { get; set; }
    }

    public partial class BASICPLAYER_BLACKOutputDTO : BASICPLAYER_BLACKOutputDTOBase { }

    [FunctionOutput]
    public class BASICPLAYER_BLACKOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BASICPLAYER_BLUEOutputDTO : BASICPLAYER_BLUEOutputDTOBase { }

    [FunctionOutput]
    public class BASICPLAYER_BLUEOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BASICPLAYER_ORANGEOutputDTO : BASICPLAYER_ORANGEOutputDTOBase { }

    [FunctionOutput]
    public class BASICPLAYER_ORANGEOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BASICPLAYER_REDOutputDTO : BASICPLAYER_REDOutputDTOBase { }

    [FunctionOutput]
    public class BASICPLAYER_REDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class DEUS_ADDRESSOutputDTO : DEUS_ADDRESSOutputDTOBase { }

    [FunctionOutput]
    public class DEUS_ADDRESSOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IS_SALE_ACTIVEOutputDTO : IS_SALE_ACTIVEOutputDTOBase { }

    [FunctionOutput]
    public class IS_SALE_ACTIVEOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BalanceOfBatchOutputDTO : BalanceOfBatchOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfBatchOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }

    public partial class IsApprovedForAllOutputDTO : IsApprovedForAllOutputDTOBase { }

    [FunctionOutput]
    public class IsApprovedForAllOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }











    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }





    public partial class UriOutputDTO : UriOutputDTOBase { }

    [FunctionOutput]
    public class UriOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}
