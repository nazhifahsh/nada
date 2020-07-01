using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NadaKey : MonoBehaviour
{
    public GameObject nada;
    private Collider2D collider_Nada;
    public Joystick joy;
    public GameObject Hit;
    private float moveSpeed = 2f;

    private bool facingRight = true;
    Rigidbody2D rigid;
    GameObject objects;
    public GameObject limitLeft, limitBottom;
    private Collider2D colBottom, colLeft;
    // Start is called before the first frame update
    void Start()
    {
       
        rigid = nada.GetComponent<Rigidbody2D>();
        collider_Nada = nada.GetComponent<Collider2D>();
        NadaKey mario = FindObjectOfType<NadaKey>();
        objects = mario.gameObject;
        colBottom = limitBottom.GetComponent<Collider2D>();
        colLeft = limitLeft.GetComponent<Collider2D>();
        MainCamera main = FindObjectOfType<MainCamera>();
        main.status_ = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (joy.Horizontal > 0.0001f || joy.Horizontal <= -0.0001f)
        {
            nada.GetComponent<Animator>().SetFloat("Speed", 1);
            transform.Translate(new Vector3(joy.Horizontal * moveSpeed * Time.deltaTime, 0f, 0f));
            if (joy.Horizontal > 0.5f && !facingRight)
            {
                //If we're moving right but not facing right, flip the sprite and set     facingRight to true.
                Flip();
                facingRight = true;
            }

            else if (joy.Horizontal <= -0.01f && facingRight)
            {
                //If we're moving left but not facing left, flip the sprite and set facingRight to false.
                // GetComponent<Animator>().SetBool("IsJumping", false);
                Flip();
                facingRight = false;
            }
        }
        else
        {
            nada.GetComponent<Animator>().SetFloat("Speed", 0);
        }
        if (collider_Nada.IsTouching(colBottom))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        if (transform.eulerAngles.z > 88 && transform.eulerAngles.z < 270)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        if (transform.eulerAngles.z > -88 && transform.eulerAngles.z < -270)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        if (collider_Nada.IsTouching(colLeft))
        {
            SceneManager.LoadScene("Game-5", LoadSceneMode.Single);
        }
       
    }
    public void jump()
    {
       
        
            if (facingRight)
            {
              
                rigid.AddForce(new Vector2(4, 11.6f), ForceMode2D.Impulse);
            }
            else
            {
               
                rigid.AddForce(new Vector2(-4, 11.6f), ForceMode2D.Impulse);

            }


       

    }

    void Flip()
    {
        // Switch the way the player is labelled as facing
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
