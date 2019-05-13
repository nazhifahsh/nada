using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nada : MonoBehaviour
{

    private Collider2D collider_Nada;
    private Rigidbody2D rb;
    public Joystick joy;
    public GameObject Hit;
    private Animator anim;
    private float moveSpeed = 2f;

    private bool facingRight = true;
    Rigidbody2D rigid;
    GameObject objects;
    bool move = false;
    public GameObject limitLeft;
    public Collider2D collider_azam;
    public Collider2D collider_Left;
    public bool canWalk = true;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        collider_Nada = GetComponent<Collider2D>();
        Nada mario = FindObjectOfType<Nada>();
        objects = mario.gameObject;
        collider_azam = GameObject.FindGameObjectWithTag("azam").GetComponent<Collider2D>();
        collider_Left = GameObject.FindGameObjectWithTag("left ust").GetComponent<Collider2D>();

    }

    void Update()
    {

        StartCoroutine(come());
        if (move)
        {
            StopAllCoroutines();
            GetComponent<Animator>().SetFloat("Speed", 0);

        }
        if (canWalk)
        {
            if (joy.Horizontal > 0.0001f || joy.Horizontal <= -0.0001f)
            {
                GetComponent<Animator>().SetFloat("Speed", 1);
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
        }
       

        //  Debug.Log("V "+joy.Vertical);


       
        //Variables for the animator to use as params
        //  anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        //anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

    }
   

    IEnumerator come()
    {
        GetComponent<Animator>().SetFloat("Speed", 1);
        yield return new WaitForSeconds(0.1f);
        rigid.velocity = new Vector2(1.3f, rigid.velocity.y);
        //objects.transform.position = Vector3.MoveTowards(objects.transform.position, new Vector3(1.06f, -1.995003f, -1f), Time.deltaTime * moveSpeed);
      
        yield return new WaitForSeconds(2.1f);
        
        move = true;
        GameObject stick = joy.gameObject;
        stick.SetActive(true);
          Hit.SetActive(true);
        //limitLeft.transform.position = new Vector3(-1f, 1.5f);
        MainCamera main = FindObjectOfType<MainCamera>();
        main.status_ = true;
        limitLeft.SetActive(true);

    }

    public void jump()
    {
        if (GetComponent<Animator>().GetFloat("Speed") >= 0.001)
        {

        }
        else
        {
            if (facingRight)
            {
                GetComponent<Animator>().Play("Jump");
                rigid.AddForce(new Vector2(0.7f, 11.7f), ForceMode2D.Impulse);
            }
            else
            {
                GetComponent<Animator>().Play("Jump");
                rigid.AddForce(new Vector2(-0.7f, 11.7f), ForceMode2D.Impulse);
            }
           
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

