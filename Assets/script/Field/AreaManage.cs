using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaManage : MonoBehaviour
{
    public int AreaID;
    AreaChange areachange;  
    AudioChange ac;
    CurrentArea ca;
    void Start() 
    {
        areachange = GameObject.Find("GameSystem").GetComponent<AreaChange>();
        ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
        ca = GameObject.Find("CurrentArea").GetComponent<CurrentArea>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player") {
            int carea = other.GetComponent<Charmove>().CArea;
            if(carea != AreaID)
            {
                other.GetComponent<Charmove>().CArea = AreaID;
                ca.caID = AreaID;
                areachange.DrawAreaName(AreaID);
                ac.BgmChange(AreaID);
            }
        }
    }
}
