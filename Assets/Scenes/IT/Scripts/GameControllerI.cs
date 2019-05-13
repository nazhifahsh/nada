using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerI : MonoBehaviour
{
    public GameObject nada;
    public GameObject ustadzah;
    private Collider2D collider_Nada;
    private Collider2D collider_ust;
    private Rigidbody2D rigid_ust, rigid_nada;
    private bool Text_Status = false;
    public GameObject text;
    private int touch_count = 0;
    private Text texts;
    Ustadzah ustadzah_;
  

    // Start is called before the first frame update


    void Start()
    {
        collider_Nada = nada.GetComponent<Collider2D>();
        collider_ust = ustadzah.GetComponent<Collider2D>();
        rigid_ust = ustadzah.GetComponent<Rigidbody2D>();
        rigid_nada = nada.GetComponent<Rigidbody2D>();
        texts = text.GetComponentInChildren<Text>();
        ustadzah_= FindObjectOfType<Ustadzah>();
       

    }

    // Update is called once per frame
    void Update()
    {
        if (collider_Nada.IsTouching(collider_ust))
        {
            Text_Status = true;
        }
       

    }

    private void FixedUpdate()
    {
        if (Text_Status)
        {
            enabled = false;
            
            ustadzah_.speed = 0;
            rigid_ust.constraints = RigidbodyConstraints2D.FreezeAll;
            text.SetActive(true);
            Nada nada = FindObjectOfType<Nada>();
            nada.canWalk = false;
            GameObject joy = nada.joy.gameObject;
            joy.SetActive(false);
            nada.Hit.SetActive(false);
        }
      
    }
    


    public void textClicked()
    {
        touch_count += 1;
        switch (touch_count)
        {
            case 1:
                texts.text = "Waalaikumsalam Nada...";        
                break;
            case 2:
                texts.text = "";
                text.SetActive(false);
                Nada nada = FindObjectOfType<Nada>();
                GameObject joy = nada.joy.gameObject;
                joy.SetActive(true);
                nada.Hit.SetActive(true);
                nada.canWalk = true;
                Destroy(collider_ust);
                rigid_ust.constraints = ~RigidbodyConstraints2D.FreezePositionX;
                ustadzah_.speed = 1;
                ustadzah.transform.position += Vector3.left * Time.deltaTime;
                break;
        }
    }
}
