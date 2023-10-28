using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.TextCore.Text;

public class Characontrol : MonoBehaviour
{
    public CharacterController character;
    public Timer DecayTime;
    public string axis = "Horizontal";
    public string axis2 = "Vertical";
    public float SpeedStat = 5;
    public int Health = 5;
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
        if (DecayTime.timeValue >=50f){
            Animations[0].SetActive(true);
            Animations[1].SetActive(false);
            Animations[2].SetActive(false);
            Animations[3].SetActive(false);
            Animations[4].SetActive(false);  
        }

        if (DecayTime.timeValue <50f && DecayTime.timeValue>=40f){
            Animations[0].SetActive(false);
            Animations[1].SetActive(true);
            Animations[2].SetActive(false);
            Animations[3].SetActive(false);
            Animations[4].SetActive(false);
        }
        if (DecayTime.timeValue <40f && DecayTime.timeValue>=30f){
            Animations[0].SetActive(false);
            Animations[1].SetActive(false);
            Animations[2].SetActive(true);
            Animations[3].SetActive(false);
            Animations[4].SetActive(false);
        }
        if (DecayTime.timeValue <30f && DecayTime.timeValue>=20f){
            Animations[0].SetActive(false);
            Animations[1].SetActive(false);
            Animations[2].SetActive(false);
            Animations[3].SetActive(true);
            Animations[4].SetActive(false);
        }
        if (DecayTime.timeValue <20f && DecayTime.timeValue>=0f){
            Animations[0].SetActive(false);
            Animations[1].SetActive(false);
            Animations[2].SetActive(false);
            Animations[3].SetActive(false);
            Animations[4].SetActive(true);
        }
    }

}



