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
    private string PlayerTag = "Player";

    void Start()
    {
        mainCamera = Camera.main;

    }
    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z = fixedZPosition;
        transform.position = currentPosition;
        HandleObjectByTag(this.gameObject);
        GameObject[] players = GameObject.FindGameObjectsWithTag(PlayerTag);
        if (players.Length > 0)
        {
            player = players[0].transform; // Assign the first player found
        }
    }
    void HandleObjectByTag(GameObject obj)
    {
        if (obj.CompareTag("Zombie"))
        {
            baseHP = 10;
            if (player != null)
            {
                transform.LookAt(player);
                transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward,
mainCamera.transform.rotation * Vector3.up);
                transform.position = Vector3.MoveTowards(transform.position, player.position, 1.5f * Time.deltaTime);
            }
        }
        else if (obj.CompareTag("Bat"))
        {
            baseHP = 5;
            if (player != null)
            {
                Vector3 randomDirection = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f).normalized;
                transform.LookAt(player);
                transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward,
mainCamera.transform.rotation * Vector3.up);
                transform.position = Vector3.MoveTowards(transform.position, player.position, 1.5f * Time.deltaTime);
                transform.Translate(randomDirection * 5 * Time.deltaTime);
            }
        }
    }
}


