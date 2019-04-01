using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadee : MonoBehaviour
{
   
    public Animator duh;
    bool o = false;
    GameObject he;

    void Start()
    {
       
        he = GameObject.Find("GameObject");
    }
    void Update()
    {
        if (he.transform.position.x == 0)
        {
            o = true;
            duh.SetBool("o",true);
        }
    }
}
