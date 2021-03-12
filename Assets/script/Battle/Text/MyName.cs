using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyName : MonoBehaviour
{
    [SerializeField]
    Text ctext;
    void Start()
    {
        ctext.text = "Pikachu";
    }
    void Update()
    {
        
    }
}
