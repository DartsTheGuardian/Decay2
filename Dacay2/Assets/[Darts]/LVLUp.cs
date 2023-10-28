using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LVLUp : MonoBehaviour
{
    public enum LVLSTATS
    {
        SPEED,
        DAMAGE,
        ATTACKSPEED,
        TIME,
    }

    public LVLSTATS LevelGain;
    public Timer LVLTimer;
    public GameObject blackScreen;

    public void LevelUp()
    {
        switch (LevelGain)
        {
            case (LVLSTATS.SPEED):
                break;

            case (LVLSTATS.DAMAGE):
                break;

            case (LVLSTATS.ATTACKSPEED):
                break;

            case (LVLSTATS.TIME):
                LVLTimer.timeValue += 15;
                break;
        }
        blackScreen.SetActive(false);
    }
}
