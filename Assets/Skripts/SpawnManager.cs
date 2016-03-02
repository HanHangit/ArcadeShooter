using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
    public float MinSpawnTime;
    public float MaxSpawnTime;
    public GameObject Enemy;

    float Clock;
    float RandomSpawnTime;
	void Start()
    {
        RandomSpawnTime = Random.Range(MinSpawnTime, MaxSpawnTime);
    }
	// Update is called once per frame
	void Update () {
        Clock += Time.deltaTime;
        if(Clock > RandomSpawnTime)
        {
            RandomSpawnTime = Random.Range(MinSpawnTime, MaxSpawnTime);
            Instantiate(Enemy, transform.position, Quaternion.identity);
            Clock = 0;
        }
	}
}
