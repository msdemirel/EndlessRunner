using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    // If player hits obstacle, Game over!!
     void OnTriggerEnter(Collider collision)
     {
        Time.timeScale = 0;
        Debug.Log("YOU HIT AN OBSTACLE");
     }

}
