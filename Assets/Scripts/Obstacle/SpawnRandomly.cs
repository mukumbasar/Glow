using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomly : MonoBehaviour
{
    public GameObject obstacle;
    

    private float spawnRangeNegativeX = -0.3752834f;
    private float spawnRangePositiveX = 2.70f;

    private float startDelay = 2f;
    private float spawnInterval = 0.7f;

    private bool started = false;

    public GameObject pressSpace;
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && started == false)
        {
            started = true;
            
            InvokeRepeating("SpawnObstacles", startDelay, spawnInterval);
            
            pressSpace.SetActive(false);
        }
    
    
    }


    private void SpawnObstacles()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeNegativeX, spawnRangePositiveX), 5.5f, 0);
        Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
    }


}
