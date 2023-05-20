using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar : MonoBehaviour
{
    public AudioSource coinFX;

    // On trigger enter play coin collect sound and start Counting stars. And set false stars
     void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectControl.starCount += 1;
        this.gameObject.SetActive(false);

        
    }
}
