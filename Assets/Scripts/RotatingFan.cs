using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingFan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isActive = true;
    public float rotationSpeed = 20f;
    void Start()
    {
        
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
                0f,
                0f,
                rotationSpeed * Time.deltaTime
            );
        }
    }
}