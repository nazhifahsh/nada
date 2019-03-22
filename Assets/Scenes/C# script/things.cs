using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class things : MonoBehaviour
{
    GameObject hp, diary, sajadah, quran, payung, mug, tas, lappy, jaket;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("hp");
    }

    // Update is called once per frame
    public void ketemu()
    {
        transform.Translate(Vector2.up * 5);
    }
}
