using UnityEngine;

public class Arms : MonoBehaviour {
    int speed = 300;
    public Rigidbody2D rb;
    public Camera cam;
    public KeyCode mouseButton;

    void Update() {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 playerPos = new Vector3(mousePos.x, mousePos.y, mousePos.z);

        Vector3 difference = playerPos - transform.position;

        float rotation = Mathf.Atan2(difference.x, -difference.y) * Mathf.Rad2Deg;

        if (Input.GetKey(mouseButton)) {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, rotation, speed * Time.deltaTime));
        }
    }
}
