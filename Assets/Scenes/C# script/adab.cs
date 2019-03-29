using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adab : MonoBehaviour
{
    public Animator adabb;
    bool oq = false;
   


   
    // Start is called before the first frame update
    public void onclick()
    {
        oq = true;
        adabb.SetBool("oq", true);
        LevelControlScript.klik += 1;
    }
  

}
