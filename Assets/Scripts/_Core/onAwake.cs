using System.IO;
using UnityEngine;

public class onAwake {
  [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
  static void OnBeforeSceneLoadRuntimeMethod() {
    string root = Directory.GetCurrentDirectory();
    string dotenv = Path.Combine(root, ".env");
    DotEnv.Load(dotenv);
  }
}
