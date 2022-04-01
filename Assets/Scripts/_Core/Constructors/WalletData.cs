
public class NFT {
  string NFTId;
  bool owned;
}

[System.Serializable]
public class WalletData {
  public string userId = "";
  public string walletId = "";
  public int selectedSkinId = -1;

  public NFT[] listOfNfts;

  public WalletData(Wallet wallet) {
    userId = wallet.userId;
    walletId = wallet.walletId;
    listOfNfts = wallet.listOfNfts;
    selectedSkinId = wallet.selectedSkinId;
  }
}
