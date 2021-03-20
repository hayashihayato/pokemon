using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeCalc : MonoBehaviour
{
    MyPokeStatus Mypoke;
    EnemyState Enpoke;
    public PokeMoveData movedata;
    public PokeMove move;
    SEChange se;
    TextMessage text;
    public int dmg;
    public int val;         // 同速乱数用
    public ChangeItem ci;   //ChangeItem
    public ChangeItem ei;   //EnemyImage
    public ChangeItem mi;   //MyPokeImage
    public AudioChange ac;  //AudioChange
    public BackField bf;    //BackField
    public float floatr;    // 乱数用float
    public float floatdmg;  // 乱数用float

    private void Start() {

        find();
        se = GameObject.Find("SEAudio").GetComponent<SEChange>();
        ac = GameObject.Find("FieldAudio").GetComponent<AudioChange>();
        text = GameObject.Find("GameSystem").GetComponent<TextMessage>();
        ci = GameObject.Find("MenuWindow").GetComponent<ChangeItem>();
        ei = GameObject.Find("EnemyImage").GetComponent<ChangeItem>();
        mi = GameObject.Find("MyPokeImage").GetComponent<ChangeItem>();
        bf = GameObject.Find("GameSystem").GetComponent<BackField>();
    }

    public void find(){     // データ取得関連
        Mypoke = GameObject.Find("MyPokeController").GetComponent<MyPokeStatus>();  // 自分ポケモンのステータス取得
        Enpoke = GameObject.Find("EnemyController").GetComponent<EnemyState>();     // 敵ポケモンのステータス取得

        movedata = Resources.Load<PokeMoveData>("PokeMoveData");    // 技データ取得
        move = movedata.PokeMoveList[1];    // 技IDで検索かけてmoveにいれる
        // mymove とEnmove 作る めも
    }

    public void MyAtkMess() {
            if(Mypoke.Speed > Enpoke.Speed) {
                    text.textsay4();
                    Invoke("MyAtk",1.5f);

                    text.Invoke("textsay5",3f);
                    Invoke("EnAtk",4.5f);
            
                if(Enpoke.HP <= 0 | Mypoke.HP <= 0) {
                    return;
                }
            }
            else if(Mypoke.Speed < Enpoke.Speed) {
                    text.textsay5();
                    Invoke("EnAtk",1.5f);
                    
                    text.Invoke("textsay4",3f);
                    Invoke("MyAtk",4.5f);

                if(Enpoke.HP <= 0 | Mypoke.HP <= 0){
                    return;
                }
            }
            else if(Mypoke.Speed == Enpoke.Speed){  // 同速だったら 0,1 でランダムに決まる
                val = Random.Range(0, 2);
                if(val == 0) {
                    text.textsay5();
                    Invoke("EnAtk",1.5f);
                    if(Enpoke.HP <= 0 | Mypoke.HP <= 0){
                        return;
                    }
                    text.Invoke("textsay4",3f);
                    Invoke("MyAtk",4.5f);
                    if(Enpoke.HP <= 0 | Mypoke.HP <= 0){
                        return;
                    }
                }
                else if(val == 1) {
                    text.textsay4();
                    Invoke("MyAtk",1.5f);
                    if(Enpoke.HP <= 0 | Mypoke.HP <= 0){
                        return;
                    }
                    text.Invoke("textsay5",3f);
                    Invoke("EnAtk",4.5f);
                    if(Enpoke.HP <= 0 | Mypoke.HP <= 0){
                        return;
                    }
                }
            }
            if(Enpoke.HP > 0 & Mypoke.HP > 0){
                text.Invoke("textsay2",6f);
                ci.Invoke("DelayOpen",6f);
            }
    }
    public void Endflag(){
        if(Enpoke.HP <= 0){
            Enpoke.HP = 0;

            ac.WinSound();
            ei.Close();
            text.textsay6();
            bf.Invoke("BcField",3f);
            ac.Invoke("FieldSound",4f);
        }
        if(Mypoke.HP <= 0){
            Mypoke.HP = 0;
            mi.Close();

            text.textsay7();
            bf.Invoke("BcTitle",3f);
            ac.Invoke("OpSound",5f);
            
        }
    }

    public void MyAtk(){    // こちらの攻撃
        if(Enpoke.HP > 0 & Mypoke.HP > 0){
            floatr = Random.Range(85,100);
            if(move.movetype == 0)  {
                dmg = (((Mypoke.Level * 2 / 5 + 2) * move.power *  Mypoke.Atk / Enpoke.Def) / 50 + 2);
                floatr = floatr / 100f;
                floatdmg = (float)dmg * floatr;
                dmg = (int)floatdmg;

                Enpoke.HP = Enpoke.HP - dmg;

                text.textsay3();
                se.Sound0();
            }
            if(Enpoke.HP <= 0 | Mypoke.HP <= 0){
                Endflag();
            }

        }
        if(move.movetype == 1)  {
            if(Enpoke.HP > 0 & Mypoke.HP > 0){
                dmg = (((Mypoke.Level * 2 / 5 + 2) * move.power *  Mypoke.SpAtk / Enpoke.SpDef) / 50 + 2);
                floatr = floatr / 100f;
                floatdmg = (float)dmg * floatr;
                dmg = (int)floatdmg;

                Enpoke.HP = Enpoke.HP - dmg;

                text.textsay3();
                se.Sound0();
            }
            if(Enpoke.HP <= 0 | Mypoke.HP <= 0){
                Endflag();
            }

        }
    } 
    public void EnAtk(){    // 敵の攻撃
        if(Enpoke.HP > 0 & Mypoke.HP > 0){
            floatr = Random.Range(85,100);
            if(move.movetype == 0){
                dmg = (((Enpoke.Level * 2 / 5 + 2) * move.power *  Enpoke.Atk / Mypoke.Def) / 50 + 2);
                floatr = floatr / 100f;
                floatdmg = (float)dmg * floatr;
                dmg = (int)floatdmg;

                Mypoke.HP = Mypoke.HP - dmg;

                text.textsay3();
                se.Sound0();
            }
            if(Enpoke.HP <= 0 | Mypoke.HP <= 0) {
                Endflag();
            }

        }
        if(move.movetype == 1){
            if(Enpoke.HP > 0 & Mypoke.HP > 0){
                dmg = (((Enpoke.Level * 2 / 5 + 2) * move.power *  Enpoke.SpAtk / Mypoke.SpDef) / 50 + 2);
                floatr = floatr / 100f;
                floatdmg = (float)dmg * floatr;
                dmg = (int)floatdmg;

                Mypoke.HP = Mypoke.HP - dmg;

                text.textsay3();
                se.Sound0();
            }
            if(Enpoke.HP <= 0 | Mypoke.HP <= 0) {
                Endflag();
            }
        }
    } 
}


// ダメージ = (((レベル x 2 / 5 + 2) x 技威力 x 攻撃実数値(自) x 防御実数値(敵)) / 50 + 2) x 相性補正