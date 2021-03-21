using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuText : MonoBehaviour
{
    void Start() {
        this.gameObject.SetActive (false);
        Invoke("Open", 2f);
    }
    public void Open(){
        this.gameObject.SetActive (true);
    }
}
