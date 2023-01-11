using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public float duration = 10;
    public int defense = 20;
    public GameObject shieldPrefab;
public void CreateShield()
    {
       var a=  Instantiate(shieldPrefab);  
        a.transform.position = Vector3.zero;
    }
}
