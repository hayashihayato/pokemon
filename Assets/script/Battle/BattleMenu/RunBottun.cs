using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunBottun : MonoBehaviour
{
    AudioChange ac;
    SEChange se;

    void Start(){
        ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
        se = GameObject.Find("SEAudio").GetComponent<SEChange>();
    }
    public void main(){
        FadeManager.Instance.LoadScene ("Field", 1.0f);
        // ac.DelayArea(1.0f);
        se.Invoke("Sound2",0.1f);
    }
}
