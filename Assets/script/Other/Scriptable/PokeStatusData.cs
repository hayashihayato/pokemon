using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PokeStatusData : ScriptableObject
{
    public List<PokeStatus> PokeStatusList = new List<PokeStatus>();
}

[System.Serializable]
public class PokeStatus{
	public string Name;
    public int ID;
	public int level;
    public int maxHp;
	public int atk;
	public int def;
	public int spatk;
	public int spdef;
	public int speed;
	public int exp;
    public Sprite image;
    public Sprite myimage;
}

