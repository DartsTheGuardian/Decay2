using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLUp : MonoBehaviour
{
    public string sceneName;
    public Characontrol LVLSpeed;
    public attack LVLFirerate;
    public Characontrol LVLHealth;


    public void LVLUPATTACK(){
        //Do stuff
    }
    public void LVLUPSPEED(){
        LVLSpeed.SpeedStat += 2;
                SceneManager.LoadScene(sceneName);
    }
    public void LVLUPFIRERATE(){
        LVLFirerate.AttackSpeed+=2;
        SceneManager.LoadScene(sceneName);
    }
    public void LVLUPHEALTH()
    {
        LVLHealth.Health += 2;
        SceneManager.LoadScene(sceneName);
    }
}
