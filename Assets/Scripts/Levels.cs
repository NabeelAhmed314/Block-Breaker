using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("Levels") <= 0)
        {
            PlayerPrefs.SetInt("Levels", 1);
        }
    }
}
