using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenu : MonoBehaviour
{
    Charmove cmsc;
    void Start(){
        cmsc = GameObject.Find("player").GetComponent<Charmove>();
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E)){
            FadeManager.Instance.LoadScene ("Menu", 0.3f);
            cmsc.SetPos();
        } 
    }
}