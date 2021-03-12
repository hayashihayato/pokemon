using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
	public AudioClip[] clips;
    AudioSource audios;

    void Start()
    {
        audios = GetComponent<AudioSource>();
    }
	public void GameStart() {
		// SceneManager.LoadScene ("Field");
        FadeManager.Instance.LoadScene ("Field", 1.0f);

        GameObject target1 = GameObject.Find ("TitleAudio");
		target1.SetActive(false);
    }

}