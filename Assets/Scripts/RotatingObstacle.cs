using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingObstacle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isActive = true;
    public float rotationSpeed = 90f;
    void Start()
    {
        Debug.Log("Rotating obstacle is running");
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            isActive = !isActive;
        }
        if (isActive)
        {
           transform.Rotate(
               rotationSpeed * Time.deltaTime,
               0f,
               0f
           );
        }
    }
}
