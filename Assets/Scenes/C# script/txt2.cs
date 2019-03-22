using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txt2 : MonoBehaviour
{
    public Rigidbody2D rb2;
    public static txt2 instance = null;
    int speed = 20000;

    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void txtt2()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(0, -500);

        if (Input.GetMouseButtonDown(0))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
            if (transform.position.y > 788)
            {
                transform.Translate(Vector2.right * Time.deltaTime * speed);
               
            }
        }
    }
}
