using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public  float moveSpeed = 5;
    public float leftRightSpeed = 5;
    private float screenWidth;
    public GameObject player;

    private void Start()
    {
        screenWidth = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        // Go forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        int i = 0;
        while (i < Input.touchCount)
        {
            // Cut the screen half. If touch right, go right
            if (Input.GetTouch( i ).position.x > screenWidth / 2)
            {
                moveRight();
            }
            // If left, go left
            if (Input.GetTouch(i).position.x < screenWidth / 2)
            {
                moveLeft();
            }
            ++i;
        }

    }    

    private void moveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
        // Set the barrier for the game
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 1f, 6.5f), transform.position.y, transform.position.z);
    }
    private void moveRight()
    {
        transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 1f, 6.5f), transform.position.y, transform.position.z);
    }

    

    



}