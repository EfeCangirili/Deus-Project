using UnityEngine;
public class WeaponPickDrop : MonoBehaviour {
  public Transform handPos;
  public bool inRange;
  public bool Equipped;
  public Transform foot;
  public int offset = 2;
  public int longOffset = 10;
  [HideInInspector]
  private GameObject weapon;
  private GameObject pickedWeapon;
  private Quaternion tempVector;
  public GameObject WeaponItem;
  void Update() {
    handPos.transform.rotation = tempVector;
    PickUp();
    Drop();
  }

  private void Start() {
    tempVector = new Quaternion(handPos.rotation.x, handPos.rotation.y, handPos.rotation.z, handPos.rotation.w);
  }
  void PickUp() {
    if (inRange == true && Equipped == false) {
      if (Input.GetKeyDown(KeyCode.E)) {
        Equipped = true;
        inRange = false;
        pickedWeapon = weapon;
      }
    }
    if (Equipped == true) {
      weapon.GetComponent<Collider2D>().enabled = false;
      weapon.GetComponent<SpriteRenderer>().enabled = false;
      weapon.transform.position = handPos.position;
      WeaponItem.GetComponent<SpriteRenderer>().enabled = true;
      inRange = true;
    }
  }
  void Drop() {
    if (Equipped && Input.GetKeyDown(KeyCode.R)) {
      pickedWeapon.GetComponent<Collider2D>().enabled = false;
      pickedWeapon.transform.position = new Vector2(foot.position.x + offset, foot.position.y);
      pickedWeapon.GetComponent<SpriteRenderer>().enabled = true;
      Equipped = false;
      pickedWeapon.GetComponent<Collider2D>().enabled = true;
      WeaponItem.GetComponent<SpriteRenderer>().enabled = false;
    }
  }
  void DropWithoutPress() {
    if (Equipped) {
      pickedWeapon.GetComponent<Collider2D>().enabled = false;
      pickedWeapon.transform.position = new Vector2(foot.position.x + offset, foot.position.y);
      Equipped = false;
      inRange = true;
      pickedWeapon.GetComponent<Collider2D>().enabled = true;
    }

  }
  void OnCollisionEnter2D(Collision2D collisionInfo) {
    if (collisionInfo.gameObject.tag == "PickableObject") {
      weapon = collisionInfo.gameObject;
      inRange = true;
    }
    if (collisionInfo.gameObject.tag == "Box") {
      collisionInfo.gameObject.GetComponent<GroundBehaviour>().SetInContact(true);
    }
  }
}

