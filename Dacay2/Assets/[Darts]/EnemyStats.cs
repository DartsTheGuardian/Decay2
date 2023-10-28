using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

[System.Serializable]
public class EnemyStats : MonoBehaviour
{
    public int EXPGiven;
    public int baseHP;
    private float fixedZPosition = -1f;
    private Camera mainCamera;
    public Transform player;
    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z = fixedZPosition;
        transform.position = currentPosition;
        HandleObjectByTag(this.gameObject);
    }
    void HandleObjectByTag(GameObject obj)
    {
        if (obj.CompareTag("Zombie"))
        {
            baseHP = 10;
            transform.LookAt(player);
            transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward,
            mainCamera.transform.rotation * Vector3.up);
            //transform.right = player.position - transform.position;
            transform.position = Vector3.MoveTowards(transform.position, player.position, 1.5f * Time.deltaTime);
        }
        else if (obj.CompareTag("Bat"))
        {
            baseHP = 5;
            // Generate a random direction vector
            Vector3 randomDirection = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f);

            // Normalize the random direction vector to ensure constant speed
            randomDirection = randomDirection.normalized;
            //Follow the player
            transform.LookAt(player);
            transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward, mainCamera.transform.rotation * Vector3.up);
            transform.position = Vector3.MoveTowards(transform.position, player.position, 1.5f * Time.deltaTime);

            // Move the character in the random direction
            transform.Translate(randomDirection * 10 * Time.deltaTime);
        }
        // else if (obj.CompareTag("Crawler"))
        // {
        //     Debug.Log("Perform actions for Obstacle object.");
        //     // Add actions for Obstacle
        // }
        // else
        // {
        //     Debug.Log("No actions defined for this tag.");
        // }
    }
}


