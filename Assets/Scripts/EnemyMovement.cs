using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   
    public float moveSpeed = 1f;

    
    void Update()
    {
        transform.Translate(0, -moveSpeed, 0 * Time.deltaTime);
        
    }

    
}
