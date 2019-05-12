using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burung : MonoBehaviour
{
    public GameObject bird;
    public float spawnTime = 3f;
    private Vector3 BeginngingPos;
    public Transform spwanPosition;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);


    }

    

    // Update is called once per frame
    void Update()
    {
        bird.transform.position += Vector3.right * Time.deltaTime;
    }
   
   
    void Spawn()
    {
        Instantiate(bird, spwanPosition.position, bird.transform.rotation);    }

}
