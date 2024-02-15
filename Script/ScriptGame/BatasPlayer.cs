using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatasPlayer : MonoBehaviour
{
    private float minX, maxX;

    void Start()
    {
        // Convert the screen width and height to world coordinates
        Vector3 coor = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        
        // Set the minimum and maximum x-axis values for the player's position
        minX = 35.0f;
        maxX = 600.0f;
    }

    void Update()
    {
        // Get the current position of the object
        Vector3 temp = transform.position;

        // Check if the x-coordinate is less than the minimum (left boundary)
        if (temp.x < minX){
            temp.x = minX;  // If true, set x to the maximum to wrap around to the right side
        }

        // Check if the x-coordinate is greater than the maximum (right boundary)
        if (temp.x > maxX){
            temp.x = maxX;  // If true, set x to the minimum to wrap around to the left side
        }

        // Update the object's position
        transform.position = temp;
    }
}
