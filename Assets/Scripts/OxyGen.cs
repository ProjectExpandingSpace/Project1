using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenBar : MonoBehaviour

{
    public float Oxygen = 100f;

    void Update()
    {
        Oxygen = Oxygen - Time.deltaTime;
        Debug.Log(Oxygen);
    }
}