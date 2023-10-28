using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public float AttackSpeed = 5f;
    public Transform targetTransform;
    public Characontrol Characontrol;
    void Update()
    {
        // transform.LookAt(targetTransform);
        // Vector3 direction = targetTransform.position - transform.position;
        // direction.z = 0f;
        // transform.up = direction.normalized;
        
        transform.Translate(Vector3.right * AttackSpeed * Time.deltaTime);
        Characontrol.enabled = false ;
        
    }
}
