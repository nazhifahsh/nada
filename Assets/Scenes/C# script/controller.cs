﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{

    public Button level02Button, level03Button;
    int levelPassed;

    // Use this for initialization
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelPassed)
        {
            case 5:
                level02Button.interactable = true;
                break;
            case 6:
                level02Button.interactable = true;
                level03Button.interactable = true;
                break;
        }
    }

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPrefs()
    {
        level02Button.interactable = false;
        level03Button.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
