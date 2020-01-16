using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject[] prefabs;

    // Use this for initialization
    void Start()
    {

        // infinite coin spawning function, asynchronous
        StartCoroutine(SpawnCoins());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnCoins()
    {
        while (true)
        {
      
         Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(30, Random.Range(-7,7), 15), Quaternion.identity);
           

           
            yield return new WaitForSeconds(3f);
        }
    }
}
