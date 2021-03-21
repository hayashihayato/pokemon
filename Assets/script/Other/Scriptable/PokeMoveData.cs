using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PokeMoveData : ScriptableObject
{
    public List<PokeMove> PokeMoveList = new List<PokeMove>();  // 下の要素を入れたリスト作成
}

[System.Serializable]
public class PokeMove{
	public string MoveName; //技名前
    public int ID; // 技番号
    public int power; // 威力
    public int movetype;    // 物理特殊
    public int PP;      // PP
    public int type;    // 技のタイプ
}
