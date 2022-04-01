using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skin : MonoBehaviour {
  Button s;
  private Outline outline;
  void Start() {
    Button btn = GetComponent<Button>();
    outline = GetComponent<Outline>();
    btn.onClick.AddListener(OnClick);
  }

  void OnClick() {
    outline.enabled = !outline.enabled;
  }
}
