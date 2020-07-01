using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game5Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myText_, thisText;
    private Text text;
    private int clickCount = 0;
    void Start()
    {
        text = thisText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount >= 1 || Input.anyKey)
        {

            myText_.SetActive(true);
        }
        switch (Input.touchCount)
        {
            case 5:
                Debug.Log("1");
                text.text = "Wa'alaikumsalam";
                text.color = Color.blue;
                break;
            case 6:
                Debug.Log("2");
                text.text = "Sudah ketemu Ust Fauzan ?";
                text.color = Color.blue;
                break;
            case 7:
                Debug.Log("3");
                text.text = "Sudah stadz, ini kuncinya.";
                text.color = Color.black;
                break;
            case 8:
                Debug.Log("4");
                text.text = "Ini nada kabel HDMI nya";
                text.color = Color.blue;
                break;
            case 9:
                Debug.Log("5");
                text.text = "Terima kasih ust";
                text.color = Color.black;
                break;
            case 10:
                text.text = "sama-sama Nada";
                text.color = Color.blue;
                break;
            case 11:
                SceneManager.LoadScene("Game-6", LoadSceneMode.Single);
                break;
        }

    }
    public void ClickedText()
    {

        clickCount += 1;
        switch (clickCount)
        {
            case 1:
                Debug.Log("1");
                text.text = "Wa'alaikumsalam";
                text.color = Color.blue;
                break;
            case 2:
                Debug.Log("2");
                text.text = "Sudah ketemu Ust Fauzan ?";
                text.color = Color.blue;
                break;
            case 3:
                Debug.Log("3");
                text.text = "Sudah stadz, ini kuncinya.";
                text.color = Color.black;
                break;
            case 4:
                Debug.Log("4");
                text.text = "Ini nada kabel HDMI nya";
                text.color = Color.blue;
                break;
            case 5:
                Debug.Log("5");
                text.text = "Terima kasih ust";
                text.color = Color.black;
                break;
            case 6:
                text.text = "sama-sama Nada";
                text.color = Color.blue;
                break;
            case 7:
                SceneManager.LoadScene("Game-6", LoadSceneMode.Single);
                break;
            
        }
    }
}
