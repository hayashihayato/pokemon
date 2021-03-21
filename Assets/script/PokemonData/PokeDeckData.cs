using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeDeckData : MonoBehaviour {

    DamegeCalc dc;
    MyPokeStatus Mypoke;
    PokeStatusData pokedata;
    PokeStatus pokestatus1;
    PokeMoveData movedata;

    public int hp;
    public int level;
    public int exp;


    public int Id;
    public string PokeName;
    public string Nickname;
    public int Atk;
    public int Def;
    public int SpAtk;
    public int SpDef;
    public int Speed;
    public UnityEngine.Sprite image;
    public UnityEngine.Sprite myimage;
    public PokeMove move1;
    public PokeMove move2;
    public PokeMove move3;
    public PokeMove move4;
    





    void Start()
    {   
        find();
        Init();
    }
    public void Init()
    {
        this.image = pokestatus1.image;
        this.myimage = pokestatus1.myimage;
        this.level = pokestatus1.level;
        this.PokeName = pokestatus1.Name;
        this.Nickname = pokestatus1.Name;
        this.Id = pokestatus1.ID;

        this.hp = (pokestatus1.maxHp * 2 + 31 + 0 /4) *level / 100 + level + 10;

        this.Atk = ((pokestatus1.atk * 2 + 31 + 0 / 4) * level / 100 + 5) ;
        this.Def = ((pokestatus1.def * 2 + 31 + 0 / 4) * level / 100 + 5) ;
        this.SpAtk = ((pokestatus1.spatk * 2 + 31 + 0 / 4) * level / 100 + 5) ;
        this.SpDef = ((pokestatus1.spdef * 2 + 31 + 0 / 4) * level / 100 + 5) ;
        this.Speed = ((pokestatus1.speed * 2 + 31 + 0 / 4) * level / 100 + 5) ;
        this.exp =  pokestatus1.exp * (2 * 50) / (50 + this.level + 10) ^ 2 + 1;

    }

    void find()
    {

        pokedata = Resources.Load<PokeStatusData>("PokeStatusData");
        pokestatus1 = pokedata.PokeStatusList[6];

        movedata = Resources.Load<PokeMoveData>("PokeMoveData");    // 技データ取得
        move1 = movedata.PokeMoveList[1];
        // pokestatus2 = pokedata.PokeStatusList[i];
        // pokestatus3 = pokedata.PokeStatusList[i];
        // pokestatus4 = pokedata.PokeStatusList[i];
        // pokestatus5 = pokedata.PokeStatusList[i];
        // pokestatus6 = pokedata.PokeStatusList[i];
        
        // dc = GameObject.Find("MyPokeDeckData").GetComponent<DamegeCalc>();
    }

    public void Poke1update()
    {
        Mypoke = GameObject.Find("MyPokeController").GetComponent<MyPokeStatus>();
        // hp = hp;
        level = Mypoke.Level;
        exp = Mypoke.exp;
    }

}