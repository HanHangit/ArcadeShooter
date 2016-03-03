using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public int MaxLevel;

    private int MaxEnemy;
    private int CurrentEnemy;
    private int CurrentLevel;
    private int EnemyType;
	// Use this for initialization
	void Start () {
        CurrentLevel = 1;
	}

    public int GetCurrLevel()
    {
        return CurrentLevel;
    }

    public int GetCurrEnemy()
    {
        return CurrentEnemy;
    }

    public int GetMaxEnemy()
    {
        return MaxEnemy;
    }

    public int GetEnemyType()
    {
        return EnemyType;
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
        CurrentEnemy = 0;
    }
}
