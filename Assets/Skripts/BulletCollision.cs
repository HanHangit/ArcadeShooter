using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {

    //2Aufgaben: zerstören wenn außerhalb der Kamera
    //Zerstören wenn Gegnertrifft

    public float Damage;


    void IsInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other) //Aufgerufen, wenn BoxCollider getriggert wird(der Collider steht auf Trigger in Unity)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GegnerschLife EnemyLife = other.GetComponent<GegnerschLife>();
            EnemyLife.AddLife(-Damage);
            Destroy(gameObject);
        }
    }








}
