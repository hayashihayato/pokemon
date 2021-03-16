using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temoti : MonoBehaviour {

    [SerializeField] 
    private bool[] PokeFlag = new bool[6];
    int i = 0;
    
    public enum Pokemon {
	    poke1,poke2,poke3,poke4,poke5,poke6
    };

    void a(){
        PokeFlag [(int) Pokemon.poke1] = true;
    }
    void b(){
        if(i == 0 /*ポケモンゲット 連れてきた時*/){
            PokeFlag [(int) Pokemon.poke1] = true;
            gameObject.SetActive (true);

        }
    }
}
