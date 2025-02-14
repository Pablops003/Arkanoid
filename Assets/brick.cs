using UnityEngine;

public class brick : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        Destroy(gameObject);
    }
}
