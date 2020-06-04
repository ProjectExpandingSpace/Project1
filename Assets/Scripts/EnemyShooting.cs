using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public int bulletAmount = 10;

    public float startAngle = 90f;
    public float endAngle = 270f;
    public float fireDelay = 2f;

    private Vector2 bulletDirection;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0f, fireDelay);
    }

    private void Shoot()
    {
        float angleStep = (endAngle - startAngle) / bulletAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletAmount + 1; i++)
        {
            float bulletX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulletY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulletMove = new Vector3(bulletX, bulletY, 0f);
            Vector2 bulletDirection = (bulletMove - transform.position).normalized;

            GameObject bullet = BulletPool.bulletPoolInstance.GetBullet();
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
                bullet.GetComponent<Bullet>().SetMoveDirection(bulletDirection);

            angle += angleStep;
        }
    }
}
