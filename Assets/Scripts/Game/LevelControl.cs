using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LevelControl : MonoBehaviour
{
    public GameObject completeLevelUI;
    private bool gameHasEnded = false;
    public List<Enemy> enemyList;
    void Update()
    {
        if(gameEnder())
        {
            CompleteUI();
            StartCoroutine("LoadNextScene");
        }
    }

    private IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CompleteUI()
    {
        completeLevelUI.SetActive(true);
    }

    public bool gameEnder()
    {
        if(enemyList.Count == 0)
        {
            gameHasEnded = true;
            return gameHasEnded;
        }
        return gameHasEnded;
    }

    public bool GameState()
    {
        return gameHasEnded;
    }
}
