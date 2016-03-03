using UnityEngine;
using System.Collections;

public class GUIVerwalter : MonoBehaviour {

    PlayerLife Leben;

    float fLebensanzeige;


	void Start () {
        Leben = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
        
	}
	
	// Update is called once per frame
	void Update () {
        fLebensanzeige = Leben.GetHp();
	}
    public float getLeben() {
        return fLebensanzeige;
    }
}
