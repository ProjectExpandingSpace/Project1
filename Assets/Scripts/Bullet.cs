using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Bullet : MonoBehaviour
{
    private Vector2 moveDirection;
    public int bulletLifetime = 2;
    public int bulletSpeed = 10;
    public int bulletDamage = 20;

    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("Destroy", bulletLifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * bulletSpeed * Time.deltaTime);
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().takeDamage(bulletDamage);
            Invoke("Destroy", 0);
        }
    }

}
