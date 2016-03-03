using UnityEngine;
using System.Collections;

public class GUIVerwalter : MonoBehaviour {

    PlayerLife PlayerInstanz;
    LevelManager LevelInstanz;

    float fLebensanzeige;
    float fRespawnanzeige;
    float fGegnerAnzeige;
    float fLevel;
    float fHighscore;
    int fScore;


	void Start () {
        PlayerInstanz = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>(); //Greift auf die Klasse Player zu
        LevelInstanz = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
       


	}
	
	// Update is called once per frame
	void Update () {
        fLebensanzeige = PlayerInstanz.GetHp();
        fScore = PlayerInstanz.GetScorePoints();
        fRespawnanzeige = PlayerInstanz.GetRespawn();
	}
    public float getLeben() {
        
        return fLebensanzeige;
    }
    public float getRespawn()
    {
        return fRespawnanzeige;
    }

    public int getScore()
    {
        return fScore;
    }

    public string GetGegnerAnzeige()
    {
        return LevelInstanz.GetDefeatedEnemy() + "/" + LevelInstanz.GetMaxEnemy();
    }


}
