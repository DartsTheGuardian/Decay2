using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.TextCore.Text;

public class Characontrol : MonoBehaviour
{
    public CharacterController character;
    public string axis = "Horizontal";
    public string axis2 = "Vertical";
    public float SpeedStat = 5;
    public int BaseHealth = 5;
    public HealthBehavior CurHealth;
    public float verticalMove = 0, strafeMove = 0;
    public GameObject[] Animations;

    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        //--------------------------------------Move---------------------------------
        strafeMove = Input.GetAxis(axis);
        verticalMove = Input.GetAxis(axis2); 

        //!Vector3 velocity = (axisProvider.forward * verticalMove * multiplier + axisProvider.right * strafeMove * multiplier);
        Vector2 velocity = new Vector2( strafeMove ,verticalMove);
        if (velocity.magnitude > 1f)
        {
            velocity.Normalize();
        }
        character.Move(velocity * Time.deltaTime * SpeedStat);

        Vector3 mousePos = Input.mousePosition;

        //---------------------Anim---------------------------*
         // gestion anim
        if (CurHealth.cur_health / BaseHealth >= 0.80f){
            Animations[0].SetActive(true);
            Animations[1].SetActive(false);
            Animations[2].SetActive(false);
            Animations[3].SetActive(false);
            Animations[4].SetActive(false);  
        }

        if (CurHealth.cur_health / BaseHealth < 0.80f && CurHealth.cur_health / BaseHealth >= 0.60f){
            Animations[0].SetActive(false);
            Animations[1].SetActive(true);
            Animations[2].SetActive(false);
            Animations[3].SetActive(false);
            Animations[4].SetActive(false);
        }
        if (CurHealth.cur_health / BaseHealth < 0.60 && CurHealth.cur_health / BaseHealth >= 0.40){
            Animations[0].SetActive(false);
            Animations[1].SetActive(false);
            Animations[2].SetActive(true);
            Animations[3].SetActive(false);
            Animations[4].SetActive(false);
        }
        if (CurHealth.cur_health / BaseHealth < 0.40 && CurHealth.cur_health / BaseHealth >= 0.20){
            Animations[0].SetActive(false);
            Animations[1].SetActive(false);
            Animations[2].SetActive(false);
            Animations[3].SetActive(true);
            Animations[4].SetActive(false);
        }
        if (CurHealth.cur_health / BaseHealth < 0.20 && CurHealth.cur_health / BaseHealth >= 0){
            Animations[0].SetActive(false);
            Animations[1].SetActive(false);
            Animations[2].SetActive(false);
            Animations[3].SetActive(false);
            Animations[4].SetActive(true);
        }
    }

}



