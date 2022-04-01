using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SystemStorage {

  public static void SaveWallet(Wallet wallet) {
    BinaryFormatter formatter = new BinaryFormatter();
    try {
      string path = Application.persistentDataPath + "/wallet.deus";
      FileStream stream = new FileStream(path, FileMode.Create);
      WalletData data = new WalletData(wallet);
      formatter.Serialize(stream, data);
      stream.Close();
    } catch (Exception err) {
      Debug.Log($"An error occurred while trying to save data to system: {err} ");
    }
  }

  public static WalletData LoadWallet() {
    string path = Application.persistentDataPath + "/wallet.deus";
    Debug.Log(path);
    if (File.Exists(path)) {
      try {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);
        WalletData data = formatter.Deserialize(stream) as WalletData;
        stream.Close();
        return data;
      } catch (Exception err) {
        Debug.Log($"An error occurred while trying to load data from system: {err} ");
      }
      return null;
    } else {
      return null;
    }
  }
}
