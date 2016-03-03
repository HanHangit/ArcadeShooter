using UnityEngine;
using System.Collections;

public class GegnerschLife : MonoBehaviour
{

    //public
    public int ScorePunkte;
    public GameObject[] DroppingPowerups;
    public float DroppingChance;// 0 - 100


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
            SpawnPowerUp();
            Destroy(gameObject);  //Enemy zerstört
        }
    }
    void Start()
    {
        PlayerLifeInstanz = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLife>();
        LvlManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
    }


    void SpawnPowerUp()
    {
        if (DroppingChance > Random.Range(0, 100))
            Instantiate(DroppingPowerups[Random.Range(0, DroppingPowerups.Length)], transform.position, Quaternion.identity);
    }



}
