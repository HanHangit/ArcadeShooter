using UnityEngine;
using System.Collections;

public class GegnerschSkrip : MonoBehaviour {

    //Public 
    public float fLife;
    public float fSpeed;
    public float fDamage;

    //Private
    GegnerschLife LebensSkript;
    Rigidbody2D Rigid2D;
    Vector2 vDirectionMove;
    Transform PlayerPosition;


    // Use this for initialization
    void Start () {

        Rigid2D = gameObject.GetComponent<Rigidbody2D>();
        LebensSkript = gameObject.GetComponent<GegnerschLife>();
        LebensSkript.Sethp(fLife);
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () { //Bei jedem Frame geupdatet
        Move();
	}

    void Move()
    {
       
        Vector2 PlayerPosition2D = new Vector2(PlayerPosition.position.x, PlayerPosition.position.y); //PositiondesSpielers von 3d auf 2d
        Vector2 GegnerschPosition2d = new Vector2(transform.position.x, transform.position.y);//PositiondesGegnersch von 3d auf 2d


        vDirectionMove = PlayerPosition2D - GegnerschPosition2d;
        
       
        
    }
    void FixedUpdate() //Update + Konstant mit der Framtime ((Alle Konstant Geupdatet)) - Alle PhysikMethoden werden Konstant geupdatet
    {
        Rigid2D.velocity = vDirectionMove.normalized * fSpeed;
    }
    void OnTriggerEnter2D(Collider2D other) //Aufgerufen, wenn BoxCollider getriggert wird(der Collider steht auf Trigger in Unity)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerLife PlayerLeben = other.GetComponent<PlayerLife>();
            PlayerLeben.AddLife(-fDamage);
            //Destroy(gameObject);
        }
    }



}
