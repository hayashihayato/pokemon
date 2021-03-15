using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeField : MonoBehaviour
{
    void Update(){
        if(Input.GetKeyDown(KeyCode.E)) {
            FadeManager.Instance.LoadScene ("Field", 0.3f);
        }
    }
}
