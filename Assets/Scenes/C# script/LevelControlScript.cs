﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour
{

    public static LevelControlScript instance = null;
    public static int score = 0,klik=0;

    
  
    int sceneIndex, levelPassed;

    // Use this for initialization
    void Start()
    {

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);


        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");

    }
    void Update()
    {
        if (klik==6)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            klik++;
        }
    }

    public void youWin()
    {
        if (sceneIndex == 12)
            Invoke("loadMainMenu", 1f);
        else
        {
            if (levelPassed < sceneIndex)
                PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            Invoke("loadNextLevel", 1f);
        }
    }


    public void loadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
