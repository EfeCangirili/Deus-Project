using UnityEngine;

public class EnemyWeapon : MonoBehaviour {
  public Transform firePoint;
  public GameObject bulletPrefab;
  public float speed = 20f;
  public Transform handPos;
  public GameObject enemy;
  public GameObject player;
  public Renderer rend;
  public float enemyViewRange = 100;

  void Start() {
    InvokeRepeating("IsInRange", 1.0f, 1.0f);
  }

  private void Update() {
    IsEnemyAlive();
  }

  public void IsInRange() {

    float distance = Vector3.Distance(player.transform.position, enemy.transform.position);
    if (distance <= enemyViewRange) {
      Shoot();

    }
  }

  void Shoot() {
    GameObject bullet = Instantiate(bulletPrefab, firePoint.position, player.transform.rotation);
    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    rb.AddForce(firePoint.right * speed, ForceMode2D.Impulse);
  }

  bool IsAtHand() {
    return this.transform.position == handPos.position;
  }

  void IsEnemyAlive() {
    if (enemy == null) {
      rend = GetComponent<Renderer>();
      rend.enabled = false;
      Destroy(this);
    }
  }
}
