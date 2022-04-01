public class Wallet {
  public string userId = "";
  public string walletId = "";
  public int selectedSkinId = -1;
  public NFT[] listOfNfts;

  public Wallet(string uId, string wId, int sId) {
    userId = uId;
    walletId = wId;
    selectedSkinId = sId;
  }
}
