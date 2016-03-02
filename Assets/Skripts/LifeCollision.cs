using UnityEngine;
using System.Collections;

public class LifeCollision : MonoBehaviour
{
    public float Leben;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerLife>().AddLife(Leben);
            Destroy(gameObject);
        }
    }
}
