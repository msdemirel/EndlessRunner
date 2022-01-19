using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectControl : MonoBehaviour
{
    public static int starCount;
    public GameObject starCountDisplay;

    // Update is called once per frame
    void Update()
    {
        starCountDisplay.GetComponent<Text>().text = "" + starCount;



        if (Time.timeScale == 0)
        {
            starCount = 0;
        }
    }

    
}
