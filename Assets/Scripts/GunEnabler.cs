using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEnabler : MonoBehaviour
{
    public GameObject shootPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyStart"))
        {
            shootPoint.SetActive(true);
            Debug.Log("Yep cock");
        }
    }
}
