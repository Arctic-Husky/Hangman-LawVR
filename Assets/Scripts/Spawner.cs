using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject [] inimigosPrefab;
    void Start()
    {   
        SpawnInimigo();
    }

    public void SpawnInimigo () {
        Instantiate (inimigosPrefab[Random.Range(0, inimigosPrefab.Length)], transform.position, Quaternion.identity);
    }
}
