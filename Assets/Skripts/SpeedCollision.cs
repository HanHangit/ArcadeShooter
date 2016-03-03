using UnityEngine;
using System.Collections;

public class SpeedCollision : MonoBehaviour {
    public float Duration;
    public float Power;
    Speed powerup;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            powerup = new Speed(Duration,Power);
            other.GetComponent<Quickslot>().AddItem(powerup);
            Destroy(gameObject);
        }
    }
}
