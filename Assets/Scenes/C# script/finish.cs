using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    // Start is called before the first frame update
   public void finished()
    {
        LevelControlScript.instance.youWin();
    }
}
