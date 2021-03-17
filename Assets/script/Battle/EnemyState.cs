using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class EnemyState : MonoBehaviour
{
    PokeStatusData pokedata;
    PokeStatus pokestatus;

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

    string PokeName;
    string Nickname;
    int Level;
    int HP;
    int Atk;
    int Def;
    int SpAtk;
    int SpDef;
    int Speed;
    int Id;
    int[] PP = new int[4];

    private void Start()
    {
        Find();
        InitPokeData();
        Draw();
    }

    void InitPokeData()
    {
        this.Level = 50;
        this.PokeName = pokestatus.Name;
        this.Nickname = pokestatus.Name;
        this.Id = pokestatus.ID;

        this.HP = (pokestatus.maxHp * 2 + 31 + 0 /4) * Level / 100 + Level + 10;
        // 能力値 = (種族値×2＋個体値＋努力値÷4)×レベル÷100＋レベル＋10
        this.Atk = ((pokestatus.atk * 2 + 31 + 0 / 4) * Level / 100 + 5) ;
        this.Def = ((pokestatus.def * 2 + 31 + 0 / 4) * Level / 100 + 5) ;
        this.SpAtk = ((pokestatus.spatk * 2 + 31 + 0 / 4) * Level / 100 + 5) ;
        this.SpDef = ((pokestatus.spdef * 2 + 31 + 0 / 4) * Level / 100 + 5) ;
        this.Speed = ((pokestatus.speed * 2 + 31 + 0 / 4) * Level / 100 + 5) ;
        // 能力値 = {(種族値×2＋個体値＋努力値÷4)×レベル÷100＋5}
    }

    void Draw()
    {
        PokeImage.sprite = pokestatus.image;

        LevelText.text = (Level.ToString());
        NameText.text = this.PokeName;
        NickNameText.text = this.Nickname;
        IDText.text = Id.ToString();

        HPText.text = HP.ToString();
        AtkText.text = Atk.ToString();
        DefText.text = Def.ToString();
        SpAtkText.text = SpAtk.ToString();
        SpDefText.text = SpDef.ToString();
        SpeedText.text = Speed.ToString();
    }

    void Find()
    {
        int PokeID = PlayerPrefs.GetInt("ENCID");
        pokedata = Resources.Load<PokeStatusData>("PokeStatusData");
        pokestatus = pokedata.PokeStatusList[PokeID];


        
        /*var guids = UnityEditor.AssetDatabase.FindAssets("t:PokeStatusData");
        if (guids.Length == 0)
        {
            throw new System.IO.FileNotFoundException("PokeData does not found");
        }

        var path = AssetDatabase.GUIDToAssetPath(guids[0]);
        pokedata = AssetDatabase.LoadAssetAtPath<PokeData>(path);*/
    }
}
