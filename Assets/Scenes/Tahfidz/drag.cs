using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    public BoxCollider a1;
    float distance = 10;
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }
    void Start()
    {
        a1 = gameObject.GetComponent<BoxCollider>();
    }
    void Update()
    {
        if (a1.transform.position.x < 2 && a1.transform.position.x > 1 && a1.transform.position.y < 29.4 && a1.transform.position.y > 28.7)
        {
            Debug.Log("BISA");
        }
    }
}
