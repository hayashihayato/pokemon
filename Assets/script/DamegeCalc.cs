using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeCalc : MonoBehaviour
{
    MyPokeStatus Mypoke;
    int a;
    EnemyState Enpoke;
    private void Start() {
        find();
    }

    public void find(){
        // Mypoke = GameObject.Find(MyPokeStatus);

        Enpoke = Resources.Load<EnemyState>("EnemyState");
    }

}
