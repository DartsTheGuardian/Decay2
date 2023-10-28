using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
//!Placer spawner, génére enemy aléatoirement, avec cooldown
public class Spawner : MonoBehaviour
{
    public enum Type
    {
        ZOMBIE,
        BAT,
        CRAWLER,
    }
    public Type EnemyType;
    public GameObject EnemyToSpawn;
    public Vector3 spawnAreaCenter; // The center of the spawn area
    public Vector2 spawnAreaSize; // The size of the spawn area
    public int NumEnemy;
    private int LimitSpawn;

    //Instantiate at the player entrance

    void Update()
    {
        if (LimitSpawn < NumEnemy)
        {
            SpawnObject();
            LimitSpawn++;
        }
    }

    // Action to perform when the player enters the room

    void SpawnObject()
    {
        Vector3 spawnPosition = spawnAreaCenter + new Vector3((int)Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2), (int)Random.Range(-spawnAreaSize.y / 2, spawnAreaSize.y / 2), -1f);
        Instantiate(EnemyToSpawn, spawnPosition, Quaternion.identity);
    }

    // void Update(){
    //     OnBecameVisible();
    // }
    //     void OnBecameVisible()
    //     {
    //         Debug.Log("Object is now visible.");
    //         gameObject.tag = "Visible";
    //         if (gameObject.tag == "Visible")
    //         {
    //             if (LimitSpawn < NumEnemy)
    //             {
    //                 SpawnObject();
    //                 LimitSpawn++;
    //             }
    //         } else {
    //             gameObject.tag = "NotVisible";
    //         }
    //     }
}





