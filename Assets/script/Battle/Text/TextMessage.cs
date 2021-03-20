using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMessage : MonoBehaviour
{
    [SerializeField]
    Text ctext;
    PokeStatusData Enpokedata;
    PokeStatus Enpokestatus;
    MyPokeStatus Mypoke;
    EnemyState Enpoke;
    DamegeCalc dc;

    void Start(){
        find();
        Invoke("textsay1", 0.9f);
        Invoke("textsay2", 2f);
    }

    void textsay1(){
        ctext.text = "Wild " + Enpokestatus.Name + "\nappeared!";
    }
    public void textsay2(){
        if(Enpoke.HP > 0 & Mypoke.HP > 0)
        ctext.text = "What will \n" + Mypoke.Nickname +" do?";
    }
    public void textsay3(){
        ctext.text = dc.dmg + " damage！";
    }
    public void textsay4(){
        if(Enpoke.HP > 0 & Mypoke.HP > 0)
        ctext.text = Mypoke.Nickname + " Used " + dc.move.MoveName + "！";
    }
    public void textsay5(){
        if(Enpoke.HP > 0 & Mypoke.HP > 0)
        ctext.text = Enpokestatus.Name + " Used " + dc.move.MoveName + "！";
    }
    public void textsay6(){
        ctext.text = "Wild " + Enpokestatus.Name + " fainted！";
    }
    public void textsay7(){
        ctext.text = Mypoke.Nickname + " fainted！\nPlayer whited out...";
    }
    
    void find(){
        int PokeID = PlayerPrefs.GetInt("ENCID");
        Enpokedata = Resources.Load<PokeStatusData>("PokeStatusData");
        Enpokestatus = Enpokedata.PokeStatusList[PokeID];

        Mypoke = GameObject.Find("MyPokeController").GetComponent<MyPokeStatus>();
        Enpoke = GameObject.Find("EnemyController").GetComponent<EnemyState>();

        dc = GameObject.Find("GameSystem").GetComponent<DamegeCalc>();
    }
}
