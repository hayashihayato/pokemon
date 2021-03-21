using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MyPokeStatus : MonoBehaviour
{
    // PokeStatusData pokedata;
    PokeStatus pokestatus;
    PokeDeckData pokedata;
    public PokeMoveData movedata;
    public PokeMove move1;
    PokeMove move2;
    PokeMove move3;
    PokeMove move4;

    [SerializeField] Image PokeImage;
    [SerializeField] Text NameText;
    [SerializeField] Text NickNameText;
    [SerializeField] Text IDText;
    [SerializeField] Text LevelText;
    [SerializeField] Text HPText;
    [SerializeField] Text AtkText;
    [SerializeField] Text DefText;
    [SerializeField] Text SpAtkText;
    [SerializeField] Text SpDefText;
    [SerializeField] Text SpeedText;
    [SerializeField] Text expText;
    [SerializeField] Text Move1Text;
    [SerializeField] Text Move2Text;
    [SerializeField] Text Move3Text;
    [SerializeField] Text Move4Text;

    public string PokeName;
    public string Nickname;
    public int Level;
    public int HP;
    public int Atk;
    public int Def;
    public int SpAtk;
    public int SpDef;
    public int Speed;
    public int Id;
    public int exp;

    private void Start() {
        Find();
        InitPokeData();
    }
    private void Update() {
        Draw();
    }

    void InitPokeData()
    {
        this.Level = pokedata.level;
        this.PokeName = pokedata.name;
        this.Nickname = pokedata.name;
        this.Id = pokedata.Id;

        this.HP = pokedata.hp;

        this.Atk = pokedata.Atk;
        this.Def = pokedata.Def;
        this.SpAtk = pokedata.SpAtk;
        this.SpDef = pokedata.SpDef;
        this.Speed = pokedata.Speed;
        // this.exp =  pokestatus.exp * (2 * 敵レベル) / (敵レベル + this.Level + 10) ^ 2 + 1;


    }

    void Draw() {
        if(SceneManager.GetActiveScene().name == "Battle"){
            PokeImage.sprite = pokedata.myimage;
        }
        else {
            PokeImage.sprite = pokedata.image;
        }
        LevelText.text = (pokedata.level.ToString());
        NameText.text = pokedata.PokeName;
        NickNameText.text = pokedata.Nickname;
        IDText.text = pokedata.Id.ToString();

        HPText.text = pokedata.hp.ToString();

        AtkText.text = pokedata.Atk.ToString();
        DefText.text = pokedata.Def.ToString();
        SpAtkText.text = pokedata.SpAtk.ToString();
        SpDefText.text = pokedata.SpDef.ToString();
        SpeedText.text = pokedata.Speed.ToString();
        Move1Text.text = move1.MoveName.ToString();
    }

    void Find()
    {
        pokedata = GameObject.Find("MyPokeDeckData").GetComponent<PokeDeckData>();


        // pokedata = Resources.Load<PokeStatusData>("PokeStatusData");
        // pokestatus = pokedata.PokeStatusList[6];

        movedata = Resources.Load<PokeMoveData>("PokeMoveData");    // 技データ取得
        move1 = movedata.PokeMoveList[1];
    }
}


