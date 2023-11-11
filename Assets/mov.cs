using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{

    public float moveSpeed = 5f; // Adjust this to control the movement speed
    public float sensitivity = 2f; // Adjust this to control the mouse sensitivity

    void Update()
    {
        // Move the camera based on user input
        MoveCamera();

        // Rotate the camera based on mouse input
        RotateCamera();
    }

    void MoveCamera()
    {
        // Get input from arrow keys or other input method
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // Normalize the movement vector to ensure consistent speed in all directions
        movement.Normalize();

        // Move the camera
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    void RotateCamera()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the camera based on mouse input
        transform.Rotate(Vector3.up, mouseX * sensitivity);

        // Rotate the camera vertically based on mouse input (inverted for more natural feel)
        transform.Rotate(Vector3.left, mouseY * sensitivity);
    }
}
