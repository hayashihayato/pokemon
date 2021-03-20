using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AreaData : ScriptableObject
{
    public List<areadata> AreaDataList = new List<areadata>();
}

[System.Serializable]
public class areadata{
	public string Name;
    public int ID;
}
