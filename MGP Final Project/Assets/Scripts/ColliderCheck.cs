using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{

     void OnTriggerEnter(Collider collision)
    {


        Time.timeScale = 0;
        Debug.Log("YOU HIT AN OBSTACLE");


    }
    

}
