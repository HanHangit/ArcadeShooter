using UnityEngine;
using System.Collections;

public class GegnerschLife : MonoBehaviour
{

    //public
    public int ScorePunkte;



    //Priate
    float fHp;
    PlayerLife PlayerLifeInstanz;
    LevelManager LvlManager;

    public float GetHp()
    {
        return fHp;
    }
    public void Sethp(float Life)
    {
        fHp = Life;
    }

    public void AddLife(float Life)
    {
        fHp += Life;
        if (fHp <= 0)
        {
            PlayerLifeInstanz.AddScorePoints(ScorePunkte);
            LvlManager.AddDefeatedEnemy();
            Destroy(gameObject);  //Enemy zerstört
        }
    }
    void Start()
    {
        PlayerLifeInstanz = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
        LvlManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
    }



}
