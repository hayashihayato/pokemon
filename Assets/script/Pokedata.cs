using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptable/Create EnemyData")]
public class EnemyData : ScriptableObject {
	public string PokeName;
	public int maxHp;
	public int atk;
	public int def;
	public int spatk;
	public int spdef;
	public int speed;
}