using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeCalc : MonoBehaviour
{
    MyPokeStatus Mypoke;
    EnemyState Enpoke;
    PokeMoveData movedata;
    PokeMove move;
    int dmg;


    private void Start() {
        find();
    }

    public void find(){     // データ取得関連
        Mypoke = GameObject.Find("MyPokeController").GetComponent<MyPokeStatus>();  // 自分ポケモンのステータス取得
        Enpoke = GameObject.Find("EnemyController").GetComponent<EnemyState>();     // 敵ポケモンのステータス取得

        movedata = Resources.Load<PokeMoveData>("PokeMoveData");    // 技データ取得
        move = movedata.PokeMoveList[1];    // 技IDで検索かけてmoveにいれる
    }

    public void MyAtk(){    // こちらの攻撃
        if(move.movetype == 0)  {
            dmg = (((Mypoke.Level * 2 / 5 + 2) * move.power *  Mypoke.Atk / Enpoke.Def) / 50 + 2);
            Enpoke.HP = Enpoke.HP - dmg;
        }
        if(move.movetype == 1)  {
            dmg = (((Mypoke.Level * 2 / 5 + 2) * move.power *  Mypoke.SpAtk / Enpoke.SpDef) / 50 + 2);
            Enpoke.HP = Enpoke.HP - dmg;
        }
    } 
    public void EnAtk(){    // 敵の攻撃
        if(move.movetype == 0){
            dmg = (((Enpoke.Level * 2 / 5 + 2) * move.power *  Enpoke.Atk / Mypoke.Def) / 50 + 2);
            Mypoke.HP = Mypoke.HP - dmg;
        }
        if(move.movetype == 1){
            dmg = (((Enpoke.Level * 2 / 5 + 2) * move.power *  Enpoke.SpAtk / Mypoke.SpDef) / 50 + 2);
            Mypoke.HP = Mypoke.HP - dmg;
        }
    } 
}


// ダメージ = (((レベル x 2 / 5 + 2) x 技威力 x 攻撃実数値(自) x 防御実数値(敵)) / 50 + 2) x 相性補正