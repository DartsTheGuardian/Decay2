using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
//!Placer spawner, génére enemy aléatoirement, avec cooldown
public class Spawner : MonoBehaviour
{
    public string newTag; // The new tag you want to assign
    public GameObject EnemyToSpawn;
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        int count = 0;
        while (count < count + 1)
        {

            Debug.Log("Coroutine started.");
            SpawnObject();
            yield return new WaitForSeconds(10);
            count++;
        }

    }


    // Action to perform when the player enters the room

    void SpawnObject()
    {
        Instantiate(EnemyToSpawn, this.gameObject.transform.position, Quaternion.identity);
        EnemyToSpawn.tag = newTag;
    }
}





