using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fauzan : MonoBehaviour
{
    private Animator anim;
    public bool IsLaugh = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("IsLaugh", IsLaugh);
    }
}
