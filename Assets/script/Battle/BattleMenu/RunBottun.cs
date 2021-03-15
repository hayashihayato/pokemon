using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunBottun : MonoBehaviour
{
    AudioChange ac;

    void Start(){
    }
    public void test(){
        Invoke("Run",1.0f);
    }
    public void Run(){
        ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
        ac.FieldSound();
    }
}
