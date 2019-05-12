using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerII : MonoBehaviour
{
    public GameObject nadaObject;
    public GameObject azamObject;
    public GameObject ImageText;
    public Collider2D limitObject, limitTouch, limitTouch2;
    private Collider2D nadaCollider, azamCollider;
    private bool isTouching = false;
    private Text text_;
    private int countClick = 0;
    // Start is called before the first frame update
    void Start()
    {
        nadaCollider = nadaObject.GetComponent<Collider2D>();
        azamCollider = azamObject.GetComponent<Collider2D>();
        text_ = ImageText.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nadaCollider.IsTouching(limitTouch))
        {
            isTouching = true;
        }
      
    }
    void FixedUpdate()
    {
        if (isTouching)
        {
            enabled = false;
            Nada nada = FindObjectOfType<Nada>();
            GameObject joy = nada.joy.gameObject;
            joy.SetActive(false);
            nada.Hit.SetActive(false);
            ImageText.SetActive(true);
            nadaObject.GetComponent<Animator>().SetFloat("Speed",0) ;
            nada.canWalk = false;
        }
    }
    public void textClicked()
    {
        countClick += 1;
        switch (countClick)
        {
          
            case 1:
                text_.text = "Assalamualaikum Azam...";
                break;
            case 2:
                text_.text = "Ma Ma Ma Ma Ma Ma";
                azamObject.SetActive(false);
                text_.color = Color.red;
                break;
            case 3:
                text_.text = "Hehehehehe";
                break;
            case 4:
                Destroy(limitTouch);
                Destroy(limitTouch2);
                Nada nada = FindObjectOfType<Nada>();
                GameObject joy = nada.joy.gameObject;
                joy.SetActive(true);
                nada.Hit.SetActive(true);
                ImageText.SetActive(false);
                nada.canWalk = true;
                nadaObject.GetComponent<Animator>().SetFloat("Speed", 0);
                StartCoroutine(goScene());
                break;
        }
    }
    IEnumerator goScene()
    {
        yield return new WaitForSeconds(1.1f);
        SceneManager.LoadScene("Game-2", LoadSceneMode.Single);

    }
}
