using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackField : MonoBehaviour
{
	public void BackScene() {
        FadeManager.Instance.LoadScene ("Field", 1.0f);
	}
}