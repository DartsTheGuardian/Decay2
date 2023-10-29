using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

public GameObject DeathScreen;
    public void Reload()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            DeathScreen.SetActive(false);

    }

    public void EndTheGame(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
