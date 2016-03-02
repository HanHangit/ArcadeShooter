using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {
    //Public
    public float fSpeed;

    //Private
    Rigidbody2D Rigid2D;
    Vector2 vDirection;




	// Use this for initialization
	void Start () {
        Rigid2D = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        vDirection = Vector2.zero;
        KeyBoardInPut();
	 
    }

    void FixedUpdate()
    {
        Rigid2D.velocity = vDirection.normalized * fSpeed;
    }

    void KeyBoardInPut ()
    {
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
}
