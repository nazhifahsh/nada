using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txt : MonoBehaviour
{

    int speed = 50;
    GameObject Ayah;

    void Start()
    {
        Ayah = GameObject.Find("Ayah");
        
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(5, 379);
       
    }
}
