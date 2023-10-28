using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
public GameObject[] weapons;
int currentWeapon = 0;
int currentAnim = 5;

//IIIIIIIIIIIIIIIIIIIIIIII
//IIIIIIIIIIIIIIIII

public GameObject Canon ;
public GameObject Tronconneuse ;
public GameObject Spin ;

public bool enableCanon = false;
public bool enableTronconneuse = false;
public bool enableSpin = false;


    void Update()
    {
        //---------------------Rotate----------------
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);
        float angle = Mathf.Atan2(worldMousePos.y - transform.position.y, worldMousePos.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        //---------------------Weapon Select---------------
        if (Input.GetKeyDown(KeyCode.Keypad0)){
                weapons[currentWeapon].SetActive(false);
                currentWeapon = 0;
                weapons[currentWeapon].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1)){
            if (enableCanon == true)
            {
                weapons[currentWeapon].SetActive(false);
                currentWeapon = 1;
                weapons[currentWeapon].SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad2)){
            if (enableTronconneuse == true){
                weapons[currentWeapon].SetActive(false);
                currentWeapon = 2;
                weapons[currentWeapon].SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad3)){
            if (enableSpin == true){
                weapons[currentWeapon].SetActive(false);
                currentWeapon = 3;
                weapons[currentWeapon].SetActive(true);
            }
        }

       



    }
}

