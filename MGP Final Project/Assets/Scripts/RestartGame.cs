using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public void ReatartGame()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
   
}
