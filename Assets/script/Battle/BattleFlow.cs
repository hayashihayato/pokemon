using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    TextMessage text;
    DamegeCalc dc;
    public ChangeItem ci;   //ChangeItem
    public ChangeItem ei;   //EnemyImage
    public ChangeItem mi;   //MyPokeImage
    public AudioChange ac;  //AudioChange
    public BackField bf;    //BackField
    public PokeDeckData pd;    //
    public AreaManage am;
    // MyPokeStatus Mypoke;
    PokeDeckData Mypoke;
    EnemyState Enpoke;
    void Start() 
    {
        find();
    }
    void find()
    {

        text = GameObject.Find("GameSystem").GetComponent<TextMessage>();
        dc = GameObject.Find("GameSystem").GetComponent<DamegeCalc>();
        // Mypoke = GameObject.Find("MyPokeController").GetComponent<MyPokeStatus>(); 
        Mypoke = GameObject.Find("MyPokeDeckData").GetComponent<PokeDeckData>(); 
        Enpoke = GameObject.Find("EnemyController").GetComponent<EnemyState>();

        ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
        text = GameObject.Find("GameSystem").GetComponent<TextMessage>();
        ci = GameObject.Find("MenuWindow").GetComponent<ChangeItem>();
        ei = GameObject.Find("EnemyImage").GetComponent<ChangeItem>();
        mi = GameObject.Find("MyPokeImage").GetComponent<ChangeItem>();
        bf = GameObject.Find("GameSystem").GetComponent<BackField>();
        pd = GameObject.Find("MyPokeDeckData").GetComponent<PokeDeckData>();

    }

        public void Atkflow() 
        {
            if(Mypoke.Speed > Enpoke.Speed) // 自分のほうが早かったら
            {
                    text.textsay4();
                    dc.Invoke("MyAtk",1.5f);

                    text.Invoke("textsay5",3f);
                    dc.Invoke("EnAtk",4.5f);
            
                if(Enpoke.HP <= 0 | Mypoke.hp <= 0) {
                    return;
                }
            }
            else if(Mypoke.Speed < Enpoke.Speed) // 相手のほうが早かったら
            {
                    text.textsay5();
                    dc.Invoke("EnAtk",1.5f);
                    
                    text.Invoke("textsay4",3f);
                    dc.Invoke("MyAtk",4.5f);

                if(Enpoke.HP <= 0 | Mypoke.hp <= 0){
                    return;
                }
            }
            else if(Mypoke.Speed == Enpoke.Speed) // 同速だったら 0,1 でランダムに決まる
            { 
                dc.val = Random.Range(0, 2);
                if(dc.val == 0) {
                    text.textsay5();
                    dc.Invoke("EnAtk",1.5f);
                    if(Enpoke.HP <= 0 | Mypoke.hp <= 0){
                        return;
                    }
                    text.Invoke("textsay4",3f);
                    dc.Invoke("MyAtk",4.5f);
                    if(Enpoke.HP <= 0 | Mypoke.hp <= 0){
                        return;
                    }
                }
                else if(dc.val == 1) {
                    text.textsay4();
                    dc.Invoke("MyAtk",1.5f);
                    if(Enpoke.HP <= 0 | Mypoke.hp <= 0){
                        return;
                    }
                    text.Invoke("textsay5",3f);
                    dc.Invoke("EnAtk",4.5f);
                    if(Enpoke.HP <= 0 | Mypoke.hp <= 0){
                        return;
                    }
                }
            }
            if(Enpoke.HP > 0 & Mypoke.hp > 0)
            {
                text.Invoke("textsay2",6f);
                ci.Invoke("DelayOpen",6f);
            }
    }
    public void Endflag()
    {
        if(Enpoke.HP <= 0){
            Enpoke.HP = 0;

            ac.WinSound();
            ei.Close();
            text.textsay6();
            bf.Invoke("BcField",3f);
            // ac.DelayArea(4.0f); // 直す
            
            // 今のHPやらexpを保存しておくのを描く
            // pd.Poke1update();
        }
        if(Mypoke.hp <= 0){
            Mypoke.hp = 0;
            mi.Close();

            text.textsay7();
            bf.Invoke("BcTitle",3f);
            ac.Invoke("OpSound",5f);
        }
    }
}
