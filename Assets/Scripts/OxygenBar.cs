using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenBar : MonoBehaviour

{

    public float Oxygen = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Oxygen = Oxygen - Time.deltaTime;
        Debug.Log(Oxygen);
    }
}
