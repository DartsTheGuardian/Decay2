using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EXPBehavior : MonoBehaviour
{
    public int TotalEXP = 4;
    public int TotalEXPReceived = 0;
    public int LVL = 0;
    public Text EXPText;
    public EnemyStats ES;
    public Image ProgressBar;
    private float cur_EXP = 0f;
    public string sceneName;
    private int MaxLevel = 5;

    void Update()
    {
        switch (LVL)
        {
            case 1:
                TotalEXP = 8;
                break;
            case 2:
                TotalEXP = 16;
                break;
            case 3:
                TotalEXP = 32;
                break;
            case 4:
                TotalEXP = 64;
                break;
            case 5:
                TotalEXP = 100;
                break;

        }

        EXPText.text = "EXP : " + TotalEXPReceived + " / " + TotalEXP;
        UpgradeProgressBar();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TotalEXPReceived += ES.EXPGiven;
            Destroy(GameObject.FindGameObjectWithTag("EnemyTag"));
        }


        if (TotalEXPReceived == TotalEXP)
        {
            LVL++;
            Debug.Log(LVL);
            TotalEXPReceived = 0;
            //Time.timeScale = 0;
            SceneManager.LoadScene(sceneName);
            // LVLWasGained();

        }
    }

    // void LVLWasGained(){
    //     for(int i = 0; i < MaxLevel; i++){
    //         TotalEXP += TotalEXP;
    //     }
    // }

    void UpgradeProgressBar()
    {
        cur_EXP = TotalEXPReceived;
        float calc_exp = cur_EXP / TotalEXP;
        ProgressBar.transform.localScale = new Vector3(Mathf.Clamp(calc_exp, 0, 1), ProgressBar.transform.localScale.y, ProgressBar.transform.localScale.z);
    }


}

