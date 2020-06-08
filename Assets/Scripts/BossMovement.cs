using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float strafeSpeed = 0.1f;
    public float MaxStrafeTimer = 10f;
    public float strafeTimer = 10f;

    private bool isStopped = false;
    private bool moveRight = true;

    public GameObject healthBar;

    

    private void Start()
    {
        strafeTimer = MaxStrafeTimer;
    }

    void Update()
    {
        
        transform.Translate(0, -moveSpeed, 0 * Time.deltaTime);

        if(strafeTimer <= 0 && moveRight == true)
        {
            moveRight = false;
            strafeTimer = MaxStrafeTimer*2;
        }
        else if (strafeTimer <= 0 && moveRight == false)
        {
            moveRight = true;
            strafeTimer = MaxStrafeTimer*2;
        }

        if (isStopped == true)
        {
            strafeTimer -= Time.deltaTime;
            if (moveRight == true)
            {
                transform.position = new Vector2(transform.position.x + strafeSpeed * Time.deltaTime, transform.position.y);
            }
            else if (moveRight == false)
            {
                transform.position = new Vector2(transform.position.x - strafeSpeed * Time.deltaTime, transform.position.y);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BossStop"))
        {
            moveSpeed = 0f;
            isStopped = true;
            
        }

        if(collision.CompareTag("EnemyStart"))
        {
            healthBar.gameObject.SetActive(true);
        }
        


            
    }
}
