using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    //Every Prefab is a GameObject, so we can use GameObject type to store the prefab reference
    public GameObject obstaclePrefab;
    public float spawnRate = 2f; //Spawns object every 2 seconds
    public float heightOffset = 2f;
    private float timer = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            float randomY = Random.Range(-heightOffset, heightOffset);

            Vector3 spawnPosition = transform.position;
            spawnPosition.y += randomY;

            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity); //Quaternion.identity means no rotation
            
            timer = 0f;
        }
    }
}
