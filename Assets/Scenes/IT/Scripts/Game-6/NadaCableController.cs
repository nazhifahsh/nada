using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NadaCableController : MonoBehaviour
{
    public Joystick joy;
    private float moveSpeed = 4f;
    public GameObject limit;
    private bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera main = FindObjectOfType<MainCamera>();
        main.status_ = true;
    }

    // Update is called once per frame
    void Update()
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
        else
        {
            GetComponent<Animator>().SetFloat("Speed", 0);
        }
        if (transform.eulerAngles.z > 88 && transform.eulerAngles.z < 270)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        if (transform.eulerAngles.z > -88 && transform.eulerAngles.z < -270)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        if (GetComponent<Collider2D>().IsTouching(limit.GetComponent<Collider2D>()))
        {
            Debug.Log("Finish");
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
