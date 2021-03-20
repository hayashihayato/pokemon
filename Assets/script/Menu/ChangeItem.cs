using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeItem : MonoBehaviour
{
    MyPokeStatus Mypoke;
    EnemyState Enpoke;
    void Start() {

    }
    public void Open(){
        this.gameObject.SetActive (true);
    }
    public void Close(){
        this.gameObject.SetActive (false);
    }
    public void DelayOpen(){
        Mypoke = GameObject.Find("MyPokeController").GetComponent<MyPokeStatus>();  // 自分ポケモンのステータス取得
        Enpoke = GameObject.Find("EnemyController").GetComponent<EnemyState>();     // 敵ポケモンのステータス取得
        if(Enpoke.HP > 0 & Mypoke.HP > 0)
        this.gameObject.SetActive (true);
    }
    void Update(){
        if (Input.GetMouseButton(1)){
            this.gameObject.SetActive (false);
        }
    }
}
