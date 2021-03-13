using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyName : MonoBehaviour
{
    [SerializeField]
    Text ctext;
    void Start()
    {
        ctext.text = "Giratina";
    }
    void Update()
    {
        
    }
}
