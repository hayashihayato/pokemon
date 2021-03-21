using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeCalc : MonoBehaviour
{
    // MyPokeStatus Mypoke;
    PokeDeckData Mypoke;
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
    public BattleFlow flow;    //BackField
    public float floatr;    // 乱数計算用float
    public float floatdmg;  // 乱数計算用float

    private void Start() 
    {
        find();
    }

    public void find()
    {     // データ取得関連
        Mypoke = GameObject.Find("MyPokeDeckData").GetComponent<PokeDeckData>();  // 自分ポケモンのステータス取得
        Enpoke = GameObject.Find("EnemyController").GetComponent<EnemyState>();     // 敵ポケモンのステータス取得

        movedata = Resources.Load<PokeMoveData>("PokeMoveData");    // 技データ取得
        move = movedata.PokeMoveList[1];    // 技IDで検索かけてmoveにいれる

        se = GameObject.Find("SEAudio").GetComponent<SEChange>();
        text = GameObject.Find("GameSystem").GetComponent<TextMessage>();
        flow = GameObject.Find("GameSystem").GetComponent<BattleFlow>();
        // mymove とEnmove 作る めも
    }

    public void MyAtk()
    {    // こちらの攻撃
        if(Enpoke.HP > 0 & Mypoke.hp > 0) // HPが残っていたら
        {
            floatr = Random.Range(85,100); // ダメージ乱数用
            
            if(move.movetype == 0) // 物理攻撃のダメージ計算、テキスト表示、打撃音再生
            {
                dmg = (((Mypoke.level * 2 / 5 + 2) * move.power *  Mypoke.Atk / Enpoke.Def) / 50 + 2);
                floatr = floatr / 100f;
                floatdmg = (float)dmg * floatr;
                dmg = (int)floatdmg;

                Enpoke.HP = Enpoke.HP - dmg;

                text.textsay3();
                se.Sound0();
            }
            if(Enpoke.HP <= 0 | Mypoke.hp <= 0) // エンドフラグ実行
            {
                flow.Endflag();
            }

        }
        if(Enpoke.HP > 0 & Mypoke.hp > 0) // HPが残っていたら
        {
            if(move.movetype == 1) // 特殊攻撃のダメージ計算、テキスト表示、打撃音再生
            {
                dmg = (((Mypoke.level * 2 / 5 + 2) * move.power *  Mypoke.SpAtk / Enpoke.SpDef) / 50 + 2);
                floatr = floatr / 100f;
                floatdmg = (float)dmg * floatr;
                dmg = (int)floatdmg;

                Enpoke.HP = Enpoke.HP - dmg;

                text.textsay3();
                se.Sound0();
            }
            if(Enpoke.HP <= 0 | Mypoke.hp <= 0) // エンドフラグ実行
            {
                flow.Endflag();
            }
        }
    } 
    public void EnAtk()
    {    // 敵の攻撃
        if(Enpoke.HP > 0 & Mypoke.hp > 0) // HPが残っていたら
        {
            floatr = Random.Range(85,100); // ダメージ乱数用

            if(move.movetype == 0) // 物理攻撃のダメージ計算、テキスト表示、打撃音再生
            {
                dmg = (((Enpoke.Level * 2 / 5 + 2) * move.power *  Enpoke.Atk / Mypoke.Def) / 50 + 2);
                floatr = floatr / 100f;
                floatdmg = (float)dmg * floatr;
                dmg = (int)floatdmg;

                Mypoke.hp = Mypoke.hp - dmg;

                text.textsay3();
                se.Sound0();
            }
            if(Enpoke.HP <= 0 | Mypoke.hp <= 0) // エンドフラグ実行
            {
                flow.Endflag();
            }

        }
        if(Enpoke.HP > 0 & Mypoke.hp > 0) // HPが残っていたら
        {
            if(move.movetype == 1) // 特殊攻撃のダメージ計算、テキスト表示、打撃音再生
            {
                dmg = (((Enpoke.Level * 2 / 5 + 2) * move.power *  Enpoke.SpAtk / Mypoke.SpDef) / 50 + 2);
                floatr = floatr / 100f;
                floatdmg = (float)dmg * floatr;
                dmg = (int)floatdmg;

                Mypoke.hp = Mypoke.hp - dmg;

                text.textsay3();
                se.Sound0();
            }
            if(Enpoke.HP <= 0 | Mypoke.hp <= 0) // エンドフラグ実行
            {
                flow.Endflag();
            }
        }
    } 
}