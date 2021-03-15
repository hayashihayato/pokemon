using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour
{
	AudioChange ac;
	public void BackScene() {
        FadeManager.Instance.LoadScene ("Title", 1.0f);
		ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
        ac.OpDelay();
	}
}