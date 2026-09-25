using UnityEngine;
using UnityEngine.InputSystem;

public class BrickMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int moveSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(0.01f * moveSpeed, 0, 0);
        }
    }
}
