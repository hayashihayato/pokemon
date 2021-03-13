using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBattle : MonoBehaviour
{
	public void GameStart() {
        FadeManager.Instance.LoadScene ("Battle", 1.0f);
	}
}