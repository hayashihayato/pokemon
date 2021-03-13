using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuText : MonoBehaviour
{

    void Start()
    {
        this.GetComponent<Text>().color = new Color(0,0,0,0);
        Invoke("ColorChange", 2f);
    }

    void Update()
    {
        
    }
    void ColorChange(){
        this.GetComponent<Text>().color = new Color(0.196f,0.196f,0.196f,255);
    }
}
