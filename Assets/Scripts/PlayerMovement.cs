using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * moveSpeed, 0) * Time.deltaTime);

        transform.Translate(new Vector2(0, -Input.GetAxis("Vertical") * -moveSpeed) * Time.deltaTime);
    }
}
