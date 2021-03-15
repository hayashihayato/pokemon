﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMessage : MonoBehaviour
{
    [SerializeField]
    Text ctext;
    PokeStatusData pokedata;
    PokeStatus pokestatus;

    void Start(){
        find();
        Invoke("textsay1", 0.9f);
        Invoke("textsay2", 2f);
    }
    void textsay1(){
        ctext.text = "Wild " + pokestatus.Name + " appeared!";
    }
    void textsay2(){
        ctext.text = "What will Pikachu do?";
    }
    void find(){
        int PokeID = PlayerPrefs.GetInt("ENCID");
        pokedata = Resources.Load<PokeStatusData>("PokeStatusData");
        pokestatus = pokedata.PokeStatusList[PokeID];
    }
}
