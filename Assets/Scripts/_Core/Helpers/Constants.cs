using System.Numerics;
using System.Collections.Generic;

public static class Constants {
  public enum ENV_VARIABLES {
    ETH_API_KEY,
    ETH_CONTRACT_ADDRESS,
  }
  public static List<BigInteger> ERC1155_ITEMS = new List<BigInteger>() { 0, 1, 2, 3 };
  public static string getEnvVariable(ENV_VARIABLES e) {
    return e.ToString();
  }
}