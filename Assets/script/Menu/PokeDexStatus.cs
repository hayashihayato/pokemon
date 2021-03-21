using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class PokeDexStatus : MonoBehaviour
{
    PokeDexData dexdata;
    DexData dexstatus;
    public int i = 1;

    [SerializeField] Image DexPokeImage;
    

    private void Start() {
        Find();
    }
    private void Update() {
        Draw();
        turnpage();
        buckpage();
    }


    void Draw() {
        DexPokeImage.sprite = dexstatus.image;
        dexdata = Resources.Load<PokeDexData>("PokeDexData");
        dexstatus = dexdata.PokeStatusList[i];
    }

    void Find()
    {
        dexdata = Resources.Load<PokeDexData>("PokeDexData");
        dexstatus = dexdata.PokeStatusList[i];
    }
    public void turnpage(){
        i = i++;
    }
    public void buckpage(){
        i = i--;
    }
}


