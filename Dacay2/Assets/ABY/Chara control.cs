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

    public float time;
    public float SpeedStat = 5;

    public float verticalMove = 0, strafeMove = 0;

    float life = 60f;

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
        if (time >=50f){
            Animations[0].SetActive(true);
            Animations[1].SetActive(false);
            Animations[2].SetActive(false);
            Animations[3].SetActive(false);
            Animations[4].SetActive(false);  
        }

        if (time <50f && time>=40f){
            Animations[0].SetActive(false);
            Animations[1].SetActive(true);
            Animations[2].SetActive(false);
            Animations[3].SetActive(false);
            Animations[4].SetActive(false);
        }
        if (time <40f && time>=30f){
            Animations[0].SetActive(false);
            Animations[1].SetActive(false);
            Animations[2].SetActive(true);
            Animations[3].SetActive(false);
            Animations[4].SetActive(false);
        }
        if (time <30f && time>=20f){
            Animations[0].SetActive(false);
            Animations[1].SetActive(false);
            Animations[2].SetActive(false);
            Animations[3].SetActive(true);
            Animations[4].SetActive(false);
        }
        if (time <20f && time>=0f){
            Animations[0].SetActive(false);
            Animations[1].SetActive(false);
            Animations[2].SetActive(false);
            Animations[3].SetActive(false);
            Animations[4].SetActive(true);
        }
    }

}



