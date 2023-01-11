using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;
using UnityEditor;

public static class Utils 
{
   
#if UNITY_EDITOR
    [MenuItem("EBAC/Create Item")]
    public static void Create()
    {
        GameObject go = new GameObject("shieldEmpty");
    }
#endif
    public  static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}
