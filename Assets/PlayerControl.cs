using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speedX;
    public float speedY;
    public float directionX;
    public float directionY;

    // Start is called before the first frame update
    void Start()
    {
        speedX = 3;
        speedY = 3;
        directionX = 0;
        directionY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            directionY = 1;
            directionX = 0;
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            directionY = -1;
            directionX = 0;
        }
        else if (Input.GetKey(KeyCode.D) == true)
        {
            directionX = 1;
            directionY = 0;
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            directionX = -1;
            directionY = 0;
        }
        else
        {
            directionX = 0;
            directionY = 0;
        }
        transform.position = new Vector2(transform.position.x + speedX * directionX * Time.deltaTime, transform.position.y + speedY * directionY * Time.deltaTime);
    }
}
