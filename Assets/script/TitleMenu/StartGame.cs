using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    AudioChange ac;
    AudioSource audios;
	public AudioClip[] clips;


    void Start(){
        audios = GetComponent<AudioSource>();
    }
	public void GameStart(){
        SetFirstPos();

        FadeManager.Instance.LoadScene ("Field", 2.0f);

        ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
        ac.FieldDelay();
    }
    void SetFirstPos(){
        PlayerPrefs.SetFloat("PPosX", 0.5f);
        PlayerPrefs.SetFloat("PPosY", 0.5f);
        PlayerPrefs.SetFloat("PLastX", 0f);
        PlayerPrefs.SetFloat("PLastY", -1f);
        PlayerPrefs.Save();
    }
}