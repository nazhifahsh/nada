using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVer2 : MonoBehaviour
{
    public GameObject audioOnIcon;
    public GameObject audioOffIcon;

    void start()
    {

    }

    void update()
    {

    }

    public void ToggleSound()
    {
        if(PlayerPrefs.GetInt("Muted",0) == 0)
        {

        }
    }
}
