using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiController : MonoBehaviour
{
    public void HomeButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
