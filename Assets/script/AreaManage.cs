using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaManage : MonoBehaviour
{
    public int AreaID; 
    AreaChange areachange;  
    AudioChange ac;
    void Start() {
        areachange = GameObject.Find("GameSystem").GetComponent<AreaChange>();
        ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            int carea = other.GetComponent<Charmove>().CArea;
            if(carea != AreaID){
                other.GetComponent<Charmove>().CArea = AreaID;
                areachange.DrawAreaName(AreaID);
                ac.BgmChange(AreaID);
            }
        }
    }
}
