using UnityEngine;
public class MyBullet : MonoBehaviour
{
    public int damage = 20;
    
    public void RandomizeDamage()
    {
        if(this.tag == "Bullet")
        {
            damage = Random.Range(20, 40);
        }
        else if(this.tag == "EnemyBullet")
        {
            damage = Random.Range(10, 20);
        }
    }
     void Start()
    {
        RandomizeDamage();
    }

    public int BulletDamage()
    {
        return damage;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        {
                Destroy(gameObject);
        }
    }
}