using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject

    // Camera offset to adjust the position
    public Vector3 cameraOffset = new Vector3(0, 0, -10);

 
    void Update()
    {
        // Check if the player GameObject is assigned
        if (player != null)
        {
            // Get the player's position and add the camera offset
            Vector3 targetPosition = player.transform.position + cameraOffset;

            // Update the camera's position to follow the player
            Camera.main.transform.position = targetPosition;
        }
    }

}

