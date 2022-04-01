using System.Collections;
using UnityEngine;
public class Enemy : MonoBehaviour {
  public int health = 100;
  public LevelControl levelControl;
  public HealthBar healthBar;
  public GameObject damagePoints;
  private int damageTaken;
  public void TakeDamage(int damage) {
    damageTaken = damage;
    health -= damage;
    healthBar.slider.value -= damage;
    if (damage > 0) {
      StartCoroutine("ShowDamage");
    }

    if (health <= 0) {
      Die();
    }
  }

  private IEnumerator ShowDamage() {
    Vector2 tempVector2 = new Vector3(transform.position.x - 3f, transform.position.y);
    GameObject points = Instantiate(damagePoints, tempVector2, Quaternion.identity) as GameObject;
    points.transform.GetChild(0).GetComponent<TextMesh>().text = damageTaken.ToString();
    yield return new WaitForSeconds(1f);
    Destroy(points);
  }

  void Die() {
    levelControl.enemyList.Remove(this);
    Destroy(gameObject);
  }
  void OnTriggerEnter2D(Collider2D hitInfo) {
    MyBullet bullet = hitInfo.GetComponent<MyBullet>();
    this.TakeDamage(bullet.BulletDamage());
  }
}
