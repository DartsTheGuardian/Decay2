using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;

public class EXPBehavior : MonoBehaviour
{
    private int TotalEXP = 4;
    public int TotalEXPReceived = 0;
    private int LVL = 0;
    public GameObject blackScreen;
    public Text EXPText;
    public EnemyStats ES;
    //public Text curEXP;
    //public Image ProgressBar;
    void Start()
    {
        EXPText.text = "EXP : " + TotalEXPReceived + " / " + TotalEXP;
    }
    void Update()
    {
        EXPText.text = "EXP : " + TotalEXPReceived + " / " + TotalEXP;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TotalEXPReceived += ES.EXPGiven;
            Destroy(GameObject.FindGameObjectWithTag("EnemyTag"));
        }


        if (TotalEXPReceived == TotalEXP)
        {
            LVL++;
            blackScreen.SetActive(true);
            Debug.Log("Current LVL is : " + LVL);
            TotalEXP = TotalEXP * 2;
            TotalEXPReceived = 0;
        }
    }




}

