using System;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 100.0f;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * speed;
    }

    float hitFactor(Vector2 ballpos, Vector2 racketPos,
        float racketWidth)
    {
        return (ballpos.x - racketPos.x) / racketWidth;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "racket_0")
        {
            float x = hitFactor(transform.position,
                col.transform.position, 
                col.collider.bounds.size.x);

            Vector2 dir = new Vector2(x, 1).normalized;

            GetComponent<Rigidbody2D>(). linearVelocity = dir * (speed * 1.2f);    
        }

    }
}
