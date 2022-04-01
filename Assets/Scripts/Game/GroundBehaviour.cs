using System.Collections;
using UnityEngine;

public class GroundBehaviour : MonoBehaviour {
  public bool canHurt;
  public int damage = 10;
  public GameObject player;
  public float chance;
  public bool inContact;
  private float time = 0;
  private float tempTime = 0;
  public void ChanceToHurt() {
    chance = Random.Range(0f, 100f);
    if (chance > 90) {
      canHurt = true;
    } else {
      canHurt = false;
      GiveWhiteColour();
    }
    if (canHurt) {
      GiveRedColour();
    }
  }
  public void giveDamage() {
    if (canHurt && inContact && TimePassed()) {
      float tempChance = chance;
      player.GetComponent<PlayerHandler>().TakeDamage(damage);
    }
  }

  public bool TimePassed() {
    if (time - tempTime < 0.5) {
      return false;
    }
    tempTime = time;
    return true;
  }

  public void SetInContact(bool contactPremise) {
    inContact = contactPremise;
  }

  public void GiveRedColour() {
    if (canHurt) {
      this.GetComponent<SpriteRenderer>().color = Color.red;
    }
  }
  public void GiveWhiteColour() {
    this.GetComponent<SpriteRenderer>().color = Color.white;
  }
  void OnTriggerExit2D(Collider2D other) {
    SetInContact(false);
  }

  private void OnTriggerEnter2D(Collider2D collision) {
    if (collision.tag == "Player") {
      SetInContact(true);
    }
  }
  private void Start() {
    tempTime = Time.deltaTime;
    InvokeRepeating("ChanceToHurt", 2.0f, 4f);
  }
  private void Update() {
    time += Time.deltaTime;
    giveDamage();
  }
}
