using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adab : MonoBehaviour
{
    public Animator adabb;
   
    public void ad1()
    {
        adabb.SetBool("ad1", true);
    }
    public void ad2()
    {
        adabb.SetBool("ad2", true);
    }
    public void ad3()
    {
        adabb.SetBool("ad3", true);
    }
    public void ad4()
    {
        adabb.SetBool("ad4", true);
    }
    public void ad5()
    {
        adabb.SetBool("ad5", true);
    }
    public void ad6()
    {
        adabb.SetBool("ad6", true);
    }
    public void ad7()
    {
        adabb.SetBool("sr", true);
    }
    public void ad8()
    {
        adabb.SetBool("et", true);
    }
    public void ad9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
