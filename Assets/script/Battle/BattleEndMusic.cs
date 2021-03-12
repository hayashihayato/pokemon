using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEndMusic : MonoBehaviour
{
    public AudioClip[] clips;
    AudioSource audios;

    void Start()
    {
        audios = GetComponent<AudioSource>();
    }
    public void Button1Click()
    {
        GameObject target1 = GameObject.Find ("FieldAudio");
		target1.SetActive(false);
        audios.clip = clips[0];
        audios.Play();
    }
}