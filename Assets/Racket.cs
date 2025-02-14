using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 150.0f;
    void FixedUpdate()
    {
        float horizontalDireccion = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().linearVelocity = Vector2.right * horizontalDireccion * speed;
    }
}
