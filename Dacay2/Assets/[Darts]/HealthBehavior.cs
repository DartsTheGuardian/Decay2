using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehavior : MonoBehaviour
{
    public Characontrol PlayerHealth;
    public Image ProgressHPBar;
    public Text HPText;
    public float cur_health;
    public GameObject DeathScreen;
    // Start is called before the first frame update
    void Start()
    {
        cur_health = PlayerHealth.BaseHealth;
    }

    // Update is called once per frame
    void Update()
    {
    HPText.text = "Health : " + cur_health + " / " + PlayerHealth.BaseHealth;
            if (cur_health > 0){
            UpgradeHealthBar();
            } else {
                Time.timeScale = 1;
                DeathScreen.SetActive(true);
            }
         

    }
     void UpgradeHealthBar()
    {
        float calc_health = cur_health / PlayerHealth.BaseHealth;
        ProgressHPBar.transform.localScale = new Vector3(Mathf.Clamp(calc_health, 0, 1), ProgressHPBar.transform.localScale.y, ProgressHPBar.transform.localScale.z);
    }
}
