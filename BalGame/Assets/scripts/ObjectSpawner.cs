using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject player;
    public GameObject[] trainglePrefabs;
    private Vector3 spawnObstaclePosition;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        float distanceToHorizon = Vector3.Distance(player.gameObject.transform.position, spawnObstaclePosition);
        if (distanceToHorizon < 120)
        {
            SpawnDriehoeken();
        }

        void SpawnDriehoeken()
        {
            spawnObstaclePosition = new Vector3(0, 0, spawnObstaclePosition.z + 30);
            Instantiate(trainglePrefabs[(Random.Range(0, trainglePrefabs.Length))], spawnObstaclePosition, Quaternion.identity); //Quaternion zorgt voor de ingestelde draai en alles
        }
    }
}
