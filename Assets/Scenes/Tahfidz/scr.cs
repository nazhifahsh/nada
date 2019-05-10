using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr : MonoBehaviour
{
    // Start is called before the first frame update
 
    // Update is called once per frame
    void Update()
    {
        if (drag.yay==true && drag2.yay == true && drag3.yay == true && drag4.yay == true && drag5.yay == true && drag6.yay == true && drag7.yay == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
