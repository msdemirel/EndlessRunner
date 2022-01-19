using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar : MonoBehaviour
{
    public AudioSource coinFX;
     void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectControl.starCount += 1;
        this.gameObject.SetActive(false);

        
    }
}
