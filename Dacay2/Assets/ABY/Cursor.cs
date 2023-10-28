using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
Vector3 mousePos = Input.mousePosition;
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(worldMousePos.x, worldMousePos.y, 0f);
    }
}
