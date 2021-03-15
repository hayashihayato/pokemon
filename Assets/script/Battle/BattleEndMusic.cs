using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEndMusic : MonoBehaviour
{
    AudioChange ac;

    void Start(){
    }
    public void Button1Click(){
        ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
        ac.WinSound();
    }
}