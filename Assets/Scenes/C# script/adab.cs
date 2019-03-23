using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adab : MonoBehaviour
{
    public Animator adabb;
    bool oq = false;
    bool one=false;
    bool two =false;
    bool three=false;
    bool four = false;
    bool five = false;
    bool six = false;



   
    // Start is called before the first frame update
    public void onclick()
    {
        oq = true;
        adabb.SetBool("oq", true);
        one = true;
       
    }
    public void onclick2()
    {
        oq = true;
        adabb.SetBool("oq", true);
        two = true;

    }
    public void onclick3()
    {
        oq = true;
        adabb.SetBool("oq", true);
        three = true;
    }
    public void onclick4()
    {
        oq = true;
        adabb.SetBool("oq", true);
        four = true;
    }
    public void onclick5()
    {
        oq = true;
        adabb.SetBool("oq", true);
        five = true;
    }
    public void onclick6()
    {
        oq = true;
        adabb.SetBool("oq", true);
        six = true;
    }
    void Start()
    {
        if (one==true && two== true && three == true && four == true && five == true && six == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
