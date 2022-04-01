using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Nethereum.JsonRpc.UnityClient;
using Nethereum.Web3;
using DEUS;
using TMPro;

public class ConnectWallet : MonoBehaviour {
  public TMP_InputField walletAddressInput;
  Web3 web3 = new Web3();

  void Start() {
    gameObject.GetComponent<Button>().onClick.AddListener(connectWallet);
  }

  private void connectWallet() {
    saveWalletToSystemStorage();
    StartCoroutine(getBalance());
  }

  private void saveWalletToSystemStorage() {
    string walletAddress = walletAddressInput.text;
    Wallet wallet = new Wallet("12-034-5212-23", walletAddress, -1);
    SystemStorage.SaveWallet(wallet);
  }

  public IEnumerator getBalance() {
    int totalItems = Constants.ERC1155_ITEMS.Count;
    string url = Environment.GetEnvironmentVariable(Constants.getEnvVariable(Constants.ENV_VARIABLES.ETH_API_KEY));
    string contractAddress = Environment.GetEnvironmentVariable(Constants.getEnvVariable(Constants.ENV_VARIABLES.ETH_CONTRACT_ADDRESS));
    string walletAddress = walletAddressInput.text;
    List<string> accounts = new List<string>();
    accounts.AddRange(Enumerable.Repeat(walletAddress, totalItems));

    if (!Eth.IsValidAddress(walletAddress)) {
      yield return null;
    };

    var balanceRequest = new QueryUnityRequest<BalanceOfBatchFunction, BalanceOfBatchOutputDTO>(url, walletAddress);
    yield return balanceRequest.Query(new BalanceOfBatchFunction() { Accounts = accounts, Ids = Constants.ERC1155_ITEMS }, contractAddress);
    var dtoResult = balanceRequest.Result;
  }
}
