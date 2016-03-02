using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {
    //Public
    public float fSpeed;
    public float fBulletSpeed;
    public GameObject BulletPrefab;
    public float AttackSpeed;

    //Private
    Rigidbody2D Rigid2D; //PhysikKörperdesPlayers
    Vector2 vDirection; //MoveDirection
    Vector2 vBulletDirection; //BulletMoveDirection
    float fAttackClock;





	// Use this for initialization
	void Start () {
        fAttackClock = 0;
        Rigid2D = gameObject.GetComponent<Rigidbody2D>(); //Referenz auf die Componente des RidgidBody
	}
	
	// Update is called once per frame
	void Update () {
        vDirection = Vector2.zero; 
        vBulletDirection = Vector2.zero;
        fAttackClock += Time.deltaTime;
        KeyBoardInPut();
	 
    }

    void FixedUpdate()
    {
        Rigid2D.velocity = vDirection.normalized * fSpeed;
    }

    void KeyBoardInPut ()
    {

        if(AttackSpeed <= fAttackClock )
        {
            
            if (Input.GetKey(KeyCode.UpArrow))
            {

                vBulletDirection += new Vector2(0, 1);
                Fire();
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                vBulletDirection += new Vector2(-1, 0);
                Fire();
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                vBulletDirection += new Vector2(1, 0);
                Fire();
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                vBulletDirection += new Vector2(0, -1);
                Fire();
            }

        }




        if (Input.GetKey(KeyCode.W))
        {
            vDirection += new Vector2(0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            vDirection += new Vector2(-1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            vDirection += new Vector2(0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            vDirection += new Vector2(1, 0);
        }
    }

    void Fire()
    {
        GameObject Bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity) as GameObject; //Bullet erstellen (PlayerPosition) - Winkel des Objektes
       Bullet.GetComponent<Rigidbody2D> ().velocity = vBulletDirection.normalized * fBulletSpeed;


        fAttackClock = 0;
    }
}


