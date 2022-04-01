using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onSave : MonoBehaviour {
  public GameObject s0, s1, s2, s3;
  void Start() {
    Button btn = GetComponent<Button>();
    btn.onClick.AddListener(OnClick);
  }

  void OnClick() {
    Outline s0O = s0.GetComponent<Outline>();
    Outline s1O = s1.GetComponent<Outline>();
    Outline s2O = s2.GetComponent<Outline>();
    Outline s3O = s3.GetComponent<Outline>();
    WalletData w = SystemStorage.LoadWallet();

    if (s0O.enabled == true) {
      Debug.Log("test");
      Wallet wallet = new Wallet(w.userId, w.walletId, 0);
      SystemStorage.SaveWallet(wallet);
      return;
    }
    if (s1O.enabled == true) {
      Debug.Log("test3");
      Wallet wallet = new Wallet(w.userId, w.walletId, 1);
      SystemStorage.SaveWallet(wallet);
      return;
    }
    if (s2O.enabled == true) {
      Debug.Log("test4");
      Wallet wallet = new Wallet(w.userId, w.walletId, 2);
      SystemStorage.SaveWallet(wallet);
      return;
    }
    if (s3O.enabled == true) {
      Debug.Log("test5");
      Wallet wallet = new Wallet(w.userId, w.walletId, 3);
      SystemStorage.SaveWallet(wallet);
      return;
    }

  }
}