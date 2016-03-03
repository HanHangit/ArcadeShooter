using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
    public float MinSpawnTime;
    public float MaxSpawnTime;
    public GameObject[] Enemy;

    LevelManager LvlManager;
    float Clock;
    float RandomSpawnTime;
	void Start()
    {
        RandomSpawnTime = Random.Range(MinSpawnTime, MaxSpawnTime);
        LvlManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
    }
	// Update is called once per frame
	void Update () {
        Clock += Time.deltaTime;
        if(Clock > RandomSpawnTime)
        {
            RandomSpawnTime = Random.Range(MinSpawnTime, MaxSpawnTime);
            Spawn();
            Clock = 0;
        }
	}

    void Spawn()
    {
        int i = Random.Range(0, LvlManager.GetEnemyType());
        if (i > Enemy.Length)
            i = Enemy.Length;
        if(LvlManager.GetCurrEnemy() < LvlManager.GetMaxEnemy())
            Instantiate(Enemy[i], transform.position, Quaternion.identity);
    }
}
