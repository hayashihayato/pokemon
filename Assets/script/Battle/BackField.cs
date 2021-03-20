using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackField : MonoBehaviour
{
	public void BcField() {
        FadeManager.Instance.LoadScene ("Field", 1.0f);
	}
	public void BcTitle() {
        FadeManager.Instance.LoadScene ("Title", 2.0f);
	}
}