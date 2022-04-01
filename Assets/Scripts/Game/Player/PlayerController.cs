using UnityEngine;

public class PlayerController : MonoBehaviour {
  public ParticleSystem dust;
  public Animator anim;
  public Rigidbody2D rb;
  public float jumpForce;
  public float playerSpeed;
  public Vector2 jumpHeight;
  public bool isOnGround;
  public float positionRadius;
  public LayerMask ground;
  public Transform playerPos;
  public Collider2D collider2D;
  public Color color = new Color(254, 165, 0, 1);
  void Start() {
    WalletData w = SystemStorage.LoadWallet();
    foreach (SpriteRenderer sr in GetComponentsInChildren<SpriteRenderer>()) {
      Debug.Log(w.selectedSkinId);
      switch (w.selectedSkinId) {
        case 0:
          sr.material.color = Color.black;
          break;
        case 1:
          sr.material.color = Color.red;
          break;
        case 2:
          sr.material.color = Color.blue;
          break;
        case 3:
          sr.material.color = color;
          break;
        default:
          sr.material.color = Color.white;
          break;
      }
    }
    Collider2D[] colliders = transform.GetComponentsInChildren<Collider2D>();
    for (int i = 0; i < colliders.Length; i++) {
      for (int k = i; k < colliders.Length; k++) {
        Physics2D.IgnoreCollision(colliders[i], colliders[k]);
      }
    }
  }

  void Update() {
    if (Input.GetAxisRaw("Horizontal") != 0) {
      CreateDust();
      if (Input.GetAxisRaw("Horizontal") > 0) {
        anim.Play("Walk");
        rb.AddForce(Vector2.right * playerSpeed * Time.deltaTime);
      } else {
        anim.Play("WalkBack");
        rb.AddForce(Vector2.left * playerSpeed * Time.deltaTime);
      }
    } else {
      anim.Play("Idle");
    }

    isOnGround = Physics2D.OverlapCircle(playerPos.position, positionRadius, ground);
    if (isOnGround && Input.GetKeyDown(KeyCode.Space)) {
      rb.velocity = (Vector2.up * jumpForce * Time.deltaTime);
    }
  }

  public void SetIsOnGround(bool setValue) {
    isOnGround = setValue;
  }
  void CreateDust() {
    dust.Play();
  }
  void OnTriggerEnter2D(Collider2D hitInfo) {
    if (hitInfo.tag == "Box") {
      hitInfo.GetComponent<GroundBehaviour>().SetInContact(true);
    }
  }
}
