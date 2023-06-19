using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D rb2d;
    public float speed = 0f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (rb2d.velocity.magnitude < 0.1f)
        {
            ChangeDirection();
        }
    }


    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb2d.AddForce(speed * movement);
    }

    void ChangeDirection()
    {
        float randomAngle = Random.Range(0f, 360f);
        movement = Quaternion.Euler(0, 0, randomAngle) * Vector2.up;
    }
}
