using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

[System.Serializable]
public class EnemyStats : MonoBehaviour
{
    public bool enemyIsAlive = true;
    public int EXPGiven;
    public int baseHP;
    public enum Type
    {
        ZOMBIE,
        BAT,
        CRAWLER,
    }
    public Type EnemyType;
    public Transform Enemy;
    //Nique toi le Z
    private float fixedZPosition = -1f;

    //Zombie stuff
    private Camera mainCamera;
    public Transform player;
    void Start()
    {
        //Zombie stuff
        mainCamera = Camera.main;
    }

    void Update()
    {

        // Ensure the Z position remains fixed
        Vector3 currentPosition = transform.position;
        currentPosition.z = fixedZPosition;
        transform.position = currentPosition;


        switch (EnemyType)
        {
            case (Type.ZOMBIE):
                ZombieBehavior();
                break;

            case (Type.BAT):
                BatBehavior();
                break;

            case (Type.CRAWLER):
                CrawlerBehavior();
                break;
        }

        void BatBehavior()
        {

            // Generate a random direction vector
            Vector3 randomDirection = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f);

            // Normalize the random direction vector to ensure constant speed
            randomDirection = randomDirection.normalized;

            // Move the character in the random direction
            transform.Translate(randomDirection * 10 * Time.deltaTime);


        }

        void ZombieBehavior()
        {
            if (player != null)
            {
                transform.LookAt(player);
                // transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward,
                // mainCamera.transform.rotation * Vector3.up);
                transform.right = player.position - transform.position;
                transform.position = Vector3.MoveTowards(transform.position, player.position, 1.5f * Time.deltaTime);
            }
        }
        // transform.LookAt(player);
        // // transform.Translate(Vector3.forward * 1.5f * Time.deltaTime);
        // transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward,
        // mainCamera.transform.rotation * Vector3.up);
        // transform.position = Vector3.MoveTowards(transform.position, player.position, 1.5f * Time.deltaTime);

    }

    void CrawlerBehavior()
    {

    }

}


