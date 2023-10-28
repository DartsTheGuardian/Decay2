using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TriggerEvent : MonoBehaviour
{
    // Define the tag for the player and the room
    public string playerTag = "Player";
    public string doorTag = "DoorOpen";
    public GameObject RoomToActivate;
    public GameObject RoomToDesactivate;
    public Collider other;

    // Action to perform when the player enters the room
    void Update(){
        OnTriggerEnter(other);
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag) && gameObject.CompareTag(doorTag))
        {
            Debug.Log("Player open the door.");
            // Add your custom code here
            RoomToActivate.SetActive(true);
            RoomToDesactivate.SetActive(false);

        }
    }
}