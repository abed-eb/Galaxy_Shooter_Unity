using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] powerups;
    [SerializeField] private GameObject[] enemyShipPrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawnRoutine());
        StartCoroutine(PowerupsSpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator EnemySpawnRoutine()
    {
        while (true)
        {
            Instantiate(enemyShipPrefab[0], new Vector3(Random.Range(-7f, 7f), 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
    
    IEnumerator PowerupsSpawnRoutine()
    {
        while (true)
        {
            int randomPowerup = Random.Range(0, 2);
            Instantiate(powerups[randomPowerup], new Vector3(Random.Range(-7f, 7f),7 ,0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
