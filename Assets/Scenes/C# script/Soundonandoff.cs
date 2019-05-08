using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Soundonandoff : MonoBehaviour
{

    public Button b;
    public bool musicMute;
    public Sprite musicOn;
    public Sprite musicOff;

    void Start()
    {
        musicMute = false;
        if (AudioListener.volume == 1)
        {
            b.image.sprite = musicOn;
        }
        else
        {
            b.image.sprite = musicOff;
        }
    }

    public void Musiconandoff()
    {
        musicMute = !musicMute;
        if (musicMute)
        {
            AudioListener.volume = 0;

        }
        else if (!musicMute)
        {
            AudioListener.volume = 1;
        }
     }
 
}