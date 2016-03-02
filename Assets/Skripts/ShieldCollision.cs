using UnityEngine;
using System.Collections;

public class ShieldCollision : MonoBehaviour
{
    public float Duration;
    Shield powerup;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            powerup = new Shield(Duration);
            other.GetComponent<Quickslot>().AddItem(powerup);
            Destroy(gameObject);
        }
    }
}
