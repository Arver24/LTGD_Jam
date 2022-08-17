using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] float speed;
    float currAngle;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 xMovement = new Vector2(1, 0);
        Vector2 yMovement = new Vector2(0, 1);
        currAngle = rb.rotation;

        if (Input.GetKey(KeyCode.W))
        {
            rb.position += yMovement * speed * Time.fixedDeltaTime;
            rb.MoveRotation(0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.position += -yMovement * speed * Time.fixedDeltaTime;
            rb.MoveRotation(180);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.position += -xMovement * speed * Time.fixedDeltaTime;
            rb.MoveRotation(90);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.position += xMovement * speed * Time.fixedDeltaTime;
            rb.MoveRotation(-90);
        }
        

        //rb.AddForce(force*speed*Time.deltaTime);
        //Horizontal movement
        //rb.position += xMovement * speed * Time.deltaTime;
        //rb.position += yMovement * speed * Time.deltaTime;

        //Vertical Movement

    }
}
