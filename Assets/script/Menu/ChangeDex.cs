﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDex : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenDex(){
        this.gameObject.SetActive (true);
    }
    public void Backmenu(){
        this.gameObject.SetActive (false);
    }
    void Update(){
        if (Input.GetMouseButton(1)){
            this.gameObject.SetActive (false);
        }
    }
}
