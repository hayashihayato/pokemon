using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleStart : MonoBehaviour
{
	public void Start(){
        FadeManager.Instance.LoadScene ("TitleMenu", 1.0f);
	}
}

 