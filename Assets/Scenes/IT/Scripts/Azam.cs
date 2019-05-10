using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azam : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigid;
    public Collider2D collider_azam;
    public Collider2D collider_Left;
    public Collider2D collider_Right;
    private bool facingRight = true;
    public float speed;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        collider_azam = GameObject.FindGameObjectWithTag("azam").GetComponent<Collider2D>();
        collider_Left = GameObject.FindGameObjectWithTag("left ust").GetComponent<Collider2D>();
        collider_Right = GameObject.FindGameObjectWithTag("right ust").GetComponent<Collider2D>();
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (collider_azam.IsTouching(collider_Left))
        {
            flip();
        }else if (collider_azam.IsTouching(collider_Right))
        {
            flip();
        }
       
    }

    public void WalkLeft()
    {
       // GetComponent<Animator>().SetFloat("Speed", speed);
        Vector3 defaultPpos = transform.position;
        rigid.velocity = new Vector2(-1.3f, rigid.velocity.y);
        // transform.position = Vector3.MoveTowards(transform.position, new Vector3(9.4f, -1.928216f, -1),Time.deltaTime * 2f);


    }

    void flip()
    {
        // Switch the way the player is labelled as facing
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    void WalkRight()
    {
        //  GetComponent<Animator>().SetFloat("Speed", speed);
        Vector3 defaultPpos = transform.position;
        rigid.velocity = new Vector2(1.3f, rigid.velocity.y);
        // transform.position = Vector3.MoveTowards(transform.position, new Vector3(9.4f, -1.928216f, -1),Time.deltaTime * 2f);

    }
        private void FixedUpdate()
        {
            if (facingRight)
            {
                WalkLeft();
            }
            else
            {
                WalkRight();
            }
        }
    }
