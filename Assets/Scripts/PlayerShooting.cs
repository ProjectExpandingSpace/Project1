using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    
    public GameObject bullet;
    public float fireRate = 1f;
    private float nextShot = 0f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (nextShot > 0)
        {
            nextShot -= fireRate * Time.deltaTime;
        }
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.Space) && nextShot <= 0)
        {
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
            nextShot = 1;
        }
    }
}
