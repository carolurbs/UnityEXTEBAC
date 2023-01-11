using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Shield))]
public class ShieldEditor : Editor
{
    public override void OnInspectorGUI()
    {
       // base.OnInspectorGUI();
       Shield myTarget = (Shield)target;
        myTarget.shieldPrefab =(GameObject) EditorGUILayout.ObjectField(myTarget.shieldPrefab, typeof(GameObject), true);
        myTarget.defense= EditorGUILayout.IntField("Minha Defesa", myTarget.defense);
        myTarget.duration= EditorGUILayout.FloatField("Duração", myTarget.duration);
        GUI.color = Color.black;
        if(GUILayout.Button("Create Shield"))
        {
            myTarget.CreateShield();
        }
    }
}
