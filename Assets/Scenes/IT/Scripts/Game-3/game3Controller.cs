
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game3Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject nada, fauzan;
    private Collider2D colNada, colFauzan;
    private bool isTouching = false;
    public GameObject ImageText;
    private Text myText;
    private int clickCount = 0;
    void Start()
    {
        colNada = nada.GetComponent<Collider2D>();
        myText = ImageText.GetComponentInChildren<Text>();
        colFauzan = fauzan.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (colNada.IsTouching(colFauzan))
        {
            isTouching = true;
        }
    }
    private void FixedUpdate()
    {
        if (isTouching)
        {
            NadaIII nada = FindObjectOfType<NadaIII>();
            nada.canWalk = false;
            GameObject joy = nada.joy.gameObject;
            joy.SetActive(false);
            nada.Hit.SetActive(false);
            ImageText.SetActive(true);
            Fauzan fauzan = FindObjectOfType<Fauzan>();
            fauzan.IsLaugh = false;
        }
    }
    public void clicked()
    {
        clickCount += 1;
        switch (clickCount)
        {
            case 1:
                myText.text = "Wa'alaikumusalam"+System.Environment.NewLine+"Ada apa Nada ?";
                myText.color = Color.blue;
                break;
            case 2:
                myText.text = "Stadz, pimjam kunci lemari laptop";
                myText.color = Color.black;
                break;
            case 3:
                myText.text = "Mau untuk apa Nada ?";
                myText.color = Color.blue;
                break;
            case 4:
                myText.text = "Mau ambil kabel HDMI Stadz.";
                myText.color = Color.black;
                break;
            case 5:
                myText.text = "Owh itu, ini kuncinya";
                myText.color = Color.blue;
                break;
            case 6:
                SceneManager.LoadScene("Game-4", LoadSceneMode.Single);
                break;

        }
    }
}
