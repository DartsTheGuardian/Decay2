using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLUp : MonoBehaviour
{
    public Characontrol LVLSpeed;
    public attack LVLFirerate;
    public Characontrol LVLHealth;
    public HealthBehavior LVLcurHealth;
    public GameObject LVLUpScreen;
    public GameObject HealthBarSetUp;
    public GameObject EXPBarSetUp;
    public GameObject cursor;


    public void LVLUPATTACK()
    {
        //Do stuff
    }
    public void LVLUPSPEED()
    {
        LVLSpeed.SpeedStat += 3;
        HealthBarSetUp.SetActive(true);
        EXPBarSetUp.SetActive(true);
        cursor.SetActive(true);
        LVLUpScreen.SetActive(false);
        Time.timeScale = 1;
    }
    public void LVLUPFIRERATE()
    {
        LVLFirerate.AttackSpeed += 2;
        HealthBarSetUp.SetActive(true);
        EXPBarSetUp.SetActive(true);
        cursor.SetActive(true);
        LVLUpScreen.SetActive(false);
        Time.timeScale = 1;
    }
    public void LVLUPHEALTH()
    {
        LVLHealth.BaseHealth += 2;
        LVLcurHealth.cur_health +=2 ;
        HealthBarSetUp.SetActive(true);
        EXPBarSetUp.SetActive(true);
        cursor.SetActive(true);
        LVLUpScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
