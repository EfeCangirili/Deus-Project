using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHandler : MonoBehaviour {
    public int health = 100;
    public LevelControl levelControl;
    public HealthBar healthBar;
    public GameObject damagePoints;
    private int damageTaken;
    public GameObject failedLevelUI;
    public void TakeDamage(int damage) {
        damageTaken = damage;
        health -= damage;
        healthBar.slider.value -= damage;
        if (damage > 0) {
            StartCoroutine("ShowDamage");
        }

        if (health <= 0) {
            FailedUI();
            Die();
        }
    }

    public void FailedUI() {
        failedLevelUI.SetActive(true);
    }

    private IEnumerator ShowDamage() {
        Vector2 tempVector2 = new Vector3(transform.position.x + 3f, transform.position.y);
        GameObject points = Instantiate(damagePoints, tempVector2, Quaternion.identity) as GameObject;
        points.transform.GetChild(0).GetComponent<TextMesh>().text = damageTaken.ToString();
        yield return new WaitForSeconds(1f);
        Destroy(points);
    }

    private IEnumerator RestartLevel() {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Die() {
        Destroy(this.GetComponentInChildren<HingeJoint2D>());
        StartCoroutine("RestartLevel");
    }
}
