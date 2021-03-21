using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentArea : MonoBehaviour
{
    Charmove cm;
    public int caID = 0;
    void Start()
    {

    }
    public void find()
    {
        cm = GameObject.Find("Player").GetComponent<Charmove>();
        caID = cm.CArea;
    }
}
