using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
	public float waitSpawnTime = 300f;
	public float repeatSpawnTime = 600f;
	public int maxPerSpawn = 4;
    public Transform[] spawnPoints;


	int totalCurrentSpaw;
    void Start ()
    {
		totalCurrentSpaw = 0;
		InvokeRepeating ("Spawn", waitSpawnTime, repeatSpawnTime);
    }


    void Spawn ()
    {
		totalCurrentSpaw++;
		if(playerHealth.currentHealth <= 0f || totalCurrentSpaw > maxPerSpawn)
        {
            return;
        }
        int spawnPointIndex = Random.Range (0, spawnPoints.Length);
        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
