using UnityEngine;
using System.Collections;

public class GegnerschSkrip : MonoBehaviour {

    //Public 
    public float fLife;
   
    public float fSpeed;


    //Private
    GegnerschLife LebensSkript;
    Rigidbody2D Rigid2D;
    Vector2 vDirectionMove;
    private Transform PlayerPosition;


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


}
