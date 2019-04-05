using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChapterController : MonoBehaviour
{
    public Button Prolog, Keberangkatan, TangisNada, Bismillah, BelumTerbiasa, Sarapan, SudutPesantren, Tahfizh;
    int levelPassed;
    
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        Prolog.interactable = false;
        Keberangkatan.interactable = false;
        TangisNada.interactable = false;
        Bismillah.interactable = false;
        BelumTerbiasa.interactable = false;
        Sarapan.interactable = false;
        SudutPesantren.interactable = false;
        Tahfizh.interactable = false;

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
        TangisNada.interactable = false;
        Bismillah.interactable = false;
        BelumTerbiasa.interactable = false;
        Sarapan.interactable = false;
        SudutPesantren.interactable = false;
        Tahfizh.interactable = false;
        PlayerPrefs.DeleteAll();
    }


   
}
