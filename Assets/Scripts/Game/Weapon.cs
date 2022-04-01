using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float speed = 20f;
    public Transform handPos;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && IsAtHand())
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * speed, ForceMode2D.Impulse);
    }
    bool IsAtHand()
    {
        if (this.transform.position == handPos.position)
        {
            return true;
        }
        return false;
    }
}
