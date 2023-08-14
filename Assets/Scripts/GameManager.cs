using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public void PlayButtonPressed()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitButtonPressed()
    {
        Debug.Log("Exit called");
        Application.Quit();
    }
}
