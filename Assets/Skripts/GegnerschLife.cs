using UnityEngine;
using System.Collections;

public class GegnerschLife : MonoBehaviour {

    //public
    public int ScorePunkte;



    //Priate
    float fHp;
    PlayerLife PlayerLifeInstanz;

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
        if(fHp <= 0)
        {
            PlayerLifeInstanz.AddScorePoints(ScorePunkte);
            Destroy(gameObject);  //Enemy zerstört
        }
    }
    void Start()
    {
        PlayerLifeInstanz = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
    }



}
