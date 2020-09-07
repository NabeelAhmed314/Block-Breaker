using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagementForScenes : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Level Start: "+ PlayerPrefs.GetInt("Levels"));
        SceneManager.LoadScene("Level" + PlayerPrefs.GetInt("Levels"));
    }
    public void ResetGame()
    {
        Debug.Log("Reset Level To : " + PlayerPrefs.GetInt("Levels"));
        PlayerPrefs.SetInt("Levels", 1);
    }
}
