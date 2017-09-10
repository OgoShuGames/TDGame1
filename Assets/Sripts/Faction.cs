using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Faction : ScriptableObject
{
    public List<Faction> enemies;

#if UNITY_EDITOR
    [MenuItem("Assets/Create/Faction")]
    public static void CreateFaction()
    {
        SOCreate.CreateAsset<Faction>();
    }
#endif
}
