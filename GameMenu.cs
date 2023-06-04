using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("game started");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log(" Game ended");
    }
}
