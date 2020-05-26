using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float LoadDelay = 2f;
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    {
        StartCoroutine(LoadGameOverDelay());
    }

    IEnumerator LoadGameOverDelay()
    {
        yield return new WaitForSeconds(LoadDelay);
        SceneManager.LoadScene("Game Over");
    }

    public void LoadQuit()
    {
        Application.Quit();
    }
}
