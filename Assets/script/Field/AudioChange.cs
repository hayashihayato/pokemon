using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioChange : MonoBehaviour
{
    [SerializeField]
    AudioClip[] clips;
    AudioSource audios;

    void Start(){
        audios = GetComponent<AudioSource>();
    }
    public void FieldDelay(){
        // 2秒ディレイマサラタウン
        Invoke("FieldSound",2.0f);
    }
    
    public void OpDelay(){
        // 1秒ディレイオープニング
        Invoke("OpSound",1.0f);
    }

    public void BattleSound(){
        // 戦闘野生ポケモン
        audios.clip = clips[0];
        audios.Play();
    }
    
    public void FieldSound(){
        // マサラタウン
        audios.clip = clips[1];
        audios.Play();
    }

    public void OpSound(){
        // オープニング
        audios.clip = clips[2];
        audios.Play();
    }

    public void WinSound(){
        // 勝利
        audios.clip = clips[3];
        audios.Play();
    }
}