using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game2Controller : MonoBehaviour
{
    public GameObject myText_;
    private Text text;
    private int clickCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = myText_.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount >= 1 || Input.anyKey)
        {

            myText_.SetActive(true);
                }
    }
    public void ClickedText()
    {
       
        clickCount += 1;
        switch (clickCount)
        {
            case 1:
                text.text = "Wa'alaikumsalam";
                text.color = Color.blue;
                break;
            case 2:
                text.text = "Ada apa Nada ?";
                text.color = Color.blue;
                break;
            case 3:
                text.text = "Ma'af ustadz, saya mau pinjam kabel HDMI";
                text.color = Color.black;
                break;
            case 4:
                text.text = "Boleh, tapi lemarinya terkunci.";
                text.color = Color.blue;
                break;
            case 5:
                text.text = "Kuncinya ada di Ust Fauzan";
                text.color = Color.blue;
                break;
            case 6:
                text.text = "baik ustadz, akan saya ambil kuncinya.";
                text.color = Color.black;
                break;
            case 7:
                text.text = "baik ustadz, akan saya ambil kuncinya.";
                text.color = Color.black;
                break;
            case 8:
              
                SceneManager.LoadScene("Game-3", LoadSceneMode.Single);
                break;
        }
    }

}
