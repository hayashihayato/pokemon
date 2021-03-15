using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeItem : MonoBehaviour
{
    public void Open(){
        this.gameObject.SetActive (true);
    }
    public void Backmenu(){
        this.gameObject.SetActive (false);
    }
    void Update(){
        if (Input.GetMouseButton(1)){
            this.gameObject.SetActive (false);
        }
    }
}
