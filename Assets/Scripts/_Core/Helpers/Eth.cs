using UnityEngine;
using System.Text.RegularExpressions;
using Nethereum.Util;

public class Eth : MonoBehaviour {
  public static bool IsValidAddress(string address) {
    Regex r = new Regex("^(0x){1}[0-9a-fA-F]{40}$");
    if (!r.IsMatch(address))
      return false;
    else if (address == address.ToLower())
      return true;
    else
      return new AddressUtil().IsChecksumAddress(address);
  }
}
