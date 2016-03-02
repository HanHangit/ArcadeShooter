using UnityEngine;
using System.Collections;

public class ShieldCollision : MonoBehaviour
{
    public float Duration;

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerLife>().ActivateShield(Duration);
            Destroy(gameObject);
        }
    }
}
