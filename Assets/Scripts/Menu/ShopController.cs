using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Nethereum.JsonRpc.UnityClient;
using Nethereum.Web3;
using DEUS;

public class ShopController : MonoBehaviour {
  public GameObject s0, s1, s2, s3;
  public GameObject connectWallet;

  void Start() {
    WalletData data = SystemStorage.LoadWallet();
    if (data != null) {
      StartCoroutine(getBalance(data.walletId));
    } else {
      connectWallet.SetActive(true);
    }
  }

  private IEnumerator getBalance(String walletAddress) {
    int totalItems = Constants.ERC1155_ITEMS.Count;
    string url = Environment.GetEnvironmentVariable(Constants.getEnvVariable(Constants.ENV_VARIABLES.ETH_API_KEY));
    string contractAddress = Environment.GetEnvironmentVariable(Constants.getEnvVariable(Constants.ENV_VARIABLES.ETH_CONTRACT_ADDRESS));
    List<string> accounts = new List<string>();
    accounts.AddRange(Enumerable.Repeat(walletAddress, totalItems));
    var balanceRequest = new QueryUnityRequest<BalanceOfBatchFunction, BalanceOfBatchOutputDTO>(url, walletAddress);
    yield return balanceRequest.Query(new BalanceOfBatchFunction() { Accounts = accounts, Ids = Constants.ERC1155_ITEMS }, contractAddress);
    var dtoResult = balanceRequest.Result;
    Debug.Log("hello");
    s0.SetActive((int)dtoResult?.ReturnValue1[0] > 0);
    s1.SetActive((int)dtoResult?.ReturnValue1[1] > 0);
    s2.SetActive((int)dtoResult?.ReturnValue1[2] > 0);
    s3.SetActive((int)dtoResult?.ReturnValue1[3] > 0);
  }
}
