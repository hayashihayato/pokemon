using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEChange : MonoBehaviour
{
    [SerializeField]
    AudioClip[] clips;
    AudioSource audios;

    void Start(){
        audios = GetComponent<AudioSource>();
    }
    public void Sound0(){   // ダメージ音
        audios.clip = clips[0];
        audios.Play();
    }
    public void Sound1(){   // しょうりBGM
        audios.clip = clips[1];
        audios.Play();
    }
}