using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasicAttack : MonoBehaviour
{
    public string button = "Fire1";

    public float cooldown = 0;
    public GameObject prefab;
    public Transform parent;
    public float fireRate = 0.5f;
    public Transform transform_position_rotation;
    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if(Input.GetButton(button) && cooldown <= 0){
            GameObject.Instantiate(prefab, transform_position_rotation.position, transform_position_rotation.rotation, parent);
                cooldown += 1f/fireRate;

        }
    }
}
