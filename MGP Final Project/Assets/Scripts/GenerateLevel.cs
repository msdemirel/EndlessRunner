using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 20;
    public bool creatingSection = false;
    public int secNum;


    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }
    // Every 2 seconds Generate a new Section. None stop
    IEnumerator GenerateSection()
    {
        // Sellect a new section randomly
        secNum = Random.Range(0, 3);
        // Instantiate the selected section next to old section
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 20;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
