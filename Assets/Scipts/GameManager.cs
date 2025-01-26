using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public float platformCount = Mathf.Infinity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < platformCount; i++) 
        {
            spawnPosition.y += Random.Range(1.0f, 2.3f);
            spawnPosition.x = Random.Range(-2.2f, 2.2f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
