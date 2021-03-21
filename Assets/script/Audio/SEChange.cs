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
    public void Sound(int audioid){   // しょうりBGM
        audios.clip = clips[audioid];
        audios.Play();
    }
    public void Sound0(){   // ダメージ音
        audios.clip = clips[0];
        audios.Play();
    }
    public void Sound1(){   // しょうりBGM
        audios.clip = clips[1];
        audios.Play();
    }
    public void Sound2(){   // しょうりBGM
        audios.clip = clips[2];
        audios.Play();
    }
}