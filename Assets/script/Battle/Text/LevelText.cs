using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyLevelText : MonoBehaviour
{
    [SerializeField]
    Text ctext;
    void Start()
    {
        ctext.text = "5";
    }
    void Update()
    {
        
    }
}
