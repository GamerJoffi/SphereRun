using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject[] obstaclePrefab;
    public float spawnTime = 0;
    private float timer = 0;



    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnTime)
        {
            int rand = Random.Range(0, obstaclePrefab.Length);
            
            GameObject obs = Instantiate(obstaclePrefab[rand]);
            obs.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(obs, 10);

            timer = 0;
        }

  

        timer += Time.deltaTime;
    }

    
}
