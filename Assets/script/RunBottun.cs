using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunBottun : MonoBehaviour
{
    public AudioClip[] clips;
    AudioSource audios;

    void Start()
    {
        audios = GetComponent<AudioSource>();
    }
    public void test()
    {
        Invoke("Run",1.0f);
    }
    public void Run()
    {
        GameObject target1 = GameObject.Find ("FieldAudio");
		target1.SetActive(false);
    }
}
