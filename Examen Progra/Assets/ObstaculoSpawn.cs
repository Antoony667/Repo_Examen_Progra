using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoSpawn : MonoBehaviour
{
    public GameObject[] obstaculos;     
    public Transform[] spawnPuntos;     
    public float spawnIntervalo = 2f;   

    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            
            int randomObstaculo = Random.Range(0, obstaculos.Length);
            int randomPunto = Random.Range(0, spawnPuntos.Length);

            Instantiate(
                obstaculos[randomObstaculo],
                spawnPuntos[randomPunto].position,
                Quaternion.identity
            );

           
            yield return new WaitForSeconds(spawnIntervalo);
        }
    }
}
