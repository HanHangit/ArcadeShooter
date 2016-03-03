using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public int MaxLevel;
    public int StartLevel;

    private int MaxEnemy;
    private int DefeatedEnemy;
    private int CurrentEnemy;
    private int CurrentLevel;
    private int EnemyType;
	// Use this for initialization
	void Start () {
        CurrentLevel = StartLevel;
	}

    void Update()
    {
        CurrentEnemy = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (DefeatedEnemy >= MaxEnemy && CurrentEnemy == 0)
            NextLevel();
    }

    public int GetCurrLevel()
    {
        return CurrentLevel;
    }

    public int GetCurrentEnemy()
    {
        return CurrentEnemy;
    }

    public int GetDefeatedEnemy()
    {
        return DefeatedEnemy;
    }

    public int GetMaxEnemy()
    {
        return MaxEnemy;
    }

    public int GetEnemyType()
    {
        return EnemyType;
    }

    public void AddDefeatedEnemy()
    {
        DefeatedEnemy++;
    }

    public void NextLevel()
    {
        if (CurrentLevel < MaxLevel)
        {
            CurrentLevel++;
            CalculateDifficult();
        }
        else
            Debug.Log("Got It! Gewonnen!");
    }

    void CalculateDifficult()
    {
        MaxEnemy = CurrentLevel * 5;
        EnemyType = CurrentLevel / 3;
        DefeatedEnemy = 0;
    }
}
