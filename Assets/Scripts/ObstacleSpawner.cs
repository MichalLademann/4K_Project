using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public float spawnXRange = 8f;
    public float spawnY = 5f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnInterval, spawnInterval);
    }

    void SpawnObstacle()
    {
        float randomX = Random.Range(-spawnXRange, spawnXRange);
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0);

        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
