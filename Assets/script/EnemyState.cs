using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class EnemyState : MonoBehaviour
{
    PokeData pokedata;
    [SerializeField] Image PokeImage;
    [SerializeField] Text NameText;
    [SerializeField] Text LevelText;
    int PokeID = 487;
    string PokeName;
    int Level = 5;
    int HP;
    int[] PP = new int[4];
    private void Start() {
        Find();
        InitPokeData();
        Draw();
    }
    void InitPokeData(){
        this.PokeName = pokedata.PokeName;
        this.HP = pokedata.maxHp;
    }

    void Draw(){
        var guids = UnityEditor.AssetDatabase.FindAssets(PokeID + " t:sprite");
        PokeImage.sprite = AssetDatabase.LoadAssetAtPath<Sprite>(AssetDatabase.GUIDToAssetPath(guids[0]));

        NameText.text = this.PokeName;
        LevelText.text = Level.ToString();
    }

    void Find()
    {
        var guids = UnityEditor.AssetDatabase.FindAssets(PokeID + " t:PokeData");
        if (guids.Length == 0)
        {
            throw new System.IO.FileNotFoundException("PokeData does not found");
        }

        var path = AssetDatabase.GUIDToAssetPath(guids[0]);
        var obj = AssetDatabase.LoadAssetAtPath<PokeData>(path);
    }
}