using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMessage : MonoBehaviour
{
    [SerializeField]
    Text ctext;

    void Start(){
        Invoke("textsay1", 0.9f);
        Invoke("textsay2", 2f);
    }
    void textsay1(){
        ctext.text = "Wild Giratina appeared!";
    }
    void textsay2(){
        ctext.text = "What will Pikachu do?";
    }
}
