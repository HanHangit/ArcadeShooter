using UnityEngine;
using System.Collections;

public class GUIVerwalter : MonoBehaviour {

    PlayerLife Leben;

    float fLebensanzeige;
    float fRespawnanzeige;
    float fGegnerAnzeige;
    float fLevel;
    float fHighscore;
    float fScore;


	void Start () {
        Leben = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
        fLebensanzeige = Leben.GetHp();
	}
	
	// Update is called once per frame
	void Update () {
        fLebensanzeige = Leben.GetHp();
	}
    public float getLeben() {
        return fLebensanzeige;
    }
}
