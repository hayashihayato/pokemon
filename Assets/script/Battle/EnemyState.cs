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
    [SerializeField] Text LevelText;

    string PokeName;
    int Level = 5;
    int HP;
    int[] PP = new int[4];

    private void Start()
    {
        Find();
        InitPokeData();
        Draw();
    }

    void InitPokeData()
    {
        this.PokeName = pokestatus.Name;
        this.HP = pokestatus.maxHp;
    }

    void Draw()
    {
        PokeImage.sprite = pokestatus.image;
        NameText.text = this.PokeName;
        LevelText.text = Level.ToString();
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
