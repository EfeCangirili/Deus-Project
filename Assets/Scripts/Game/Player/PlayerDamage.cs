using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour {
  public GameObject player;
  void OnTriggerEnter2D(Collider2D hitInfo) {
      if (hitInfo.tag == "EnemyBullet") {
    MyBullet bullet = hitInfo.GetComponent<MyBullet>();
    player.GetComponent<PlayerHandler>().TakeDamage(10);
    }
    if(hitInfo.tag == "Box"){
        hitInfo.GetComponent<GroundBehaviour>().SetInContact(true);
    }
  }
}
