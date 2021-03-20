using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaChange : MonoBehaviour
{
    [SerializeField] AudioChange ac;
    [SerializeField] Text areatext;
    Animator areaanim;
    AreaData areaname;
    void Start() {
        areaanim = GameObject.Find("AreaNameImage").GetComponent<Animator>();
    }

    public void DrawAreaName(int AreaID) {
        areaname = Resources.Load<AreaData>("AreaData");
        areatext.text = areaname.AreaDataList[AreaID].Name;
        areaanim.SetTrigger("Trigger");
    } 
}
