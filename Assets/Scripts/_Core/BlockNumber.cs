using System.Collections;
using UnityEngine;
using Nethereum.JsonRpc.UnityClient;
using Nethereum.RPC.Eth.DTOs;

public class BlockNumber : MonoBehaviour {
    void Start() {
        StartCoroutine(GetBlockNumber());
        StartCoroutine(GetBalance());
    }

    private IEnumerator GetBlockNumber() {
        string url = "https://ropsten.infura.io/v3/7bc97ba2e3e94214b67f9b469207e28e";
        var blockNumberRequest = new EthBlockNumberUnityRequest(url);
        yield return blockNumberRequest.SendRequest();
        print(blockNumberRequest.Result.Value);
    }

    private IEnumerator GetBalance() {
        string url = "https://ropsten.infura.io/v3/7bc97ba2e3e94214b67f9b469207e28e";
        string accountAddress = "0x2B7620dc9942d8d5064dB021348224D418994bCC";
        var balanceRequest = new EthGetBalanceUnityRequest(url);
        yield return balanceRequest.SendRequest(accountAddress, BlockParameter.CreateLatest());
        print(balanceRequest.Result.Value);
    }
}