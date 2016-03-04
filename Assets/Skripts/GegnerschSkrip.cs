using UnityEngine;
using System.Collections;

public class GegnerschSkrip : MonoBehaviour {

    //Public 
    public float fLife;
    public float fSpeed;
    public float fDamage;
    public Animator anim;


    //Private
    GegnerschLife LebensSkript;
    Rigidbody2D Rigid2D;
    Vector2 vDirectionMove;
    Transform PlayerPosition;
    private bool playerMoving;
    private Vector2 lastMove;


    // Use this for initialization
    void Start () {

        Rigid2D = gameObject.GetComponent<Rigidbody2D>();
        LebensSkript = gameObject.GetComponent<GegnerschLife>();
        LebensSkript.Sethp(fLife);
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () { //Bei jedem Frame geupdatet
        Move();
	}

    void Move()
    {
        playerMoving = false;
        float difx = 0;
        float dify = 0;


        Vector2 PlayerPosition2D = new Vector2(PlayerPosition.position.x, PlayerPosition.position.y); //PositiondesSpielers von 3d auf 2d
        Vector2 GegnerschPosition2d = new Vector2(transform.position.x, transform.position.y);//PositiondesGegnersch von 3d auf 2d

        difx = Mathf.Abs(PlayerPosition2D.x - GegnerschPosition2d.x);
        dify = Mathf.Abs(PlayerPosition2D.y - GegnerschPosition2d.y);
        Debug.Log(difx);
        Debug.Log(dify);

        if(PlayerPosition2D.x > GegnerschPosition2d.x && difx > dify) //Läuft nach rechts
        {
            anim.SetFloat("MoveX", 1);
            lastMove = new Vector2(1, 0);   

            


        }
         if (PlayerPosition2D.x < GegnerschPosition2d.x && difx > dify) //Läuft nach links
        {
            anim.SetFloat("MoveX", -1);
            lastMove = new Vector2(-1, 0);
        }

        if (PlayerPosition2D.y > GegnerschPosition2d.y && dify > difx) //Läuft nach unten
        {
            anim.SetFloat("MoveY", -1);
            lastMove = new Vector2(0, -1);
        }/*
        else if (PlayerPosition2D.y < GegnerschPosition2d.y && dify > difx) //Läuft nach oben
        {
            anim.SetFloat("MoveY", -1);
            lastMove = new Vector2(0, -1);
        }
        */




        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

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
