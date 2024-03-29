﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChapterController : MonoBehaviour
{
    public Button Prolog, Keberangkatan, BelumTerbiasa, Sarapan, Tahfizh, qcb, kucingPesantren, Diariku, HPTime, TargetMenurun;
    int levelPassed;
    
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        Prolog.interactable = false;
        Keberangkatan.interactable = false;
        BelumTerbiasa.interactable = false;
        Sarapan.interactable = false;
        Tahfizh.interactable = false;
        qcb.interactable = false;
        Diariku.interactable = false;
        HPTime.interactable = false;
        kucingPesantren.interactable = false;
        TargetMenurun.interactable = false;


        switch (levelPassed)
        {
            case 7: Prolog.interactable = true;
                break;
            case 12:
                Prolog.interactable = true;
                Keberangkatan.interactable = true;
                break;
        }
        
    }
    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }


    public void resetPlayerPrefs()
    {
        Prolog.interactable = false;
        Keberangkatan.interactable = false;
        BelumTerbiasa.interactable = false;
        Sarapan.interactable = false;
        Tahfizh.interactable = false;
        qcb.interactable = false;
        Diariku.interactable = false;
        HPTime.interactable = false;
        kucingPesantren.interactable = false;
        TargetMenurun.interactable = false;

        PlayerPrefs.DeleteAll();
    }


   
}
