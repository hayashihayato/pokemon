using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour
{
	public void BackScene() {
        GameObject target1 = GameObject.Find ("FieldAudio");
		target1.SetActive(false);
        FadeManager.Instance.LoadScene ("Title", 1.0f);
	}
}