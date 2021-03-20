using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PokeDexData : ScriptableObject
{
    public List<DexData> PokeStatusList = new List<DexData>();
}

[System.Serializable]
public class DexData{
	public string Name;
    public int ID;
    public Sprite image;
}

