using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
	public float waitSpawnTime = 300f;
	public float repeatSpawnTime = 600f;
    public Transform[] spawnPoints;


    void Start ()
    {
		InvokeRepeating ("Spawn", waitSpawnTime, repeatSpawnTime);
    }


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
