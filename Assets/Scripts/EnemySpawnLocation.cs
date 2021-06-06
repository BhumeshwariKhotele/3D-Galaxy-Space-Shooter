using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnLocation : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;



    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            Vector3 spawnPos1 = new Vector3(Random.Range(-100, 100), Random.Range(-20, 20), 100);
            Instantiate(enemy1, spawnPos1, Quaternion.identity);

            Vector3 spawnPos2 = new Vector3(Random.Range(-100, 100), Random.Range(-20, 20), 100);
            Instantiate(enemy2, spawnPos2, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);

        }

    }

}

