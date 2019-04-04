using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class imm : MonoBehaviour
{
   
        public static imm instance = null;
        public static int score = 0;
        public Animator gee;

        void Start()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);
        }


        void Update()
        {
            if (score == 6)
            {
                yo();
            }

        }
        public void yo()
        {
            gee.SetBool("yea", true);
        }
        public void yoi()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    
}
